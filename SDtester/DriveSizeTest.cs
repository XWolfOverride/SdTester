using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDtester
{
    public class DriveSizeTest
    {
        private const int PATTERN_SIZE = 1024 * 1024 * 10;//10MB
        private const int MAX_BLOCK_SIZE = 1024 * 1024 * 5; // 1MB
        private const string TEST_FILE = "testfile.bin";

        public delegate bool DriveSizeCallback(long progress, long max, bool verifing, DriveTestResult result);

        private readonly byte[] patternA;
        private readonly byte[] patternB;
        private readonly byte[] patternC;
        private readonly byte[] patternD;

        public DriveSizeTest(int seed = 0)
        {
            if (seed == 0)
                seed = new Random().Next();
            Random r = new Random(seed);
            patternA = new byte[PATTERN_SIZE];
            patternB = new byte[PATTERN_SIZE + 1];
            patternC = new byte[PATTERN_SIZE + 2];
            patternD = new byte[PATTERN_SIZE + 3];
            r.NextBytes(patternA);
            r.NextBytes(patternB);
            r.NextBytes(patternC);
            r.NextBytes(patternD);
            Seed = seed;
        }

        #region Drive list
        public static List<DriveInfo> ListDrives()
        {
            List<DriveInfo> result = new List<DriveInfo>();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
                if (drive.DriveType == DriveType.Removable)
                    result.Add(drive);
            return result;
        }
        #endregion

        public DriveTestResult Test(DriveInfo d, DriveSizeCallback updater)
        {
            string fpath = Path.Combine(d.Name, TEST_FILE);
            byte[] block = new byte[MAX_BLOCK_SIZE];
            var result = new DriveTestResult();
            using (FileStream fs = new FileStream(fpath, FileMode.Create, FileAccess.ReadWrite))
            {
                fs.SetLength(0);
                long max = d.AvailableFreeSpace;
                if (max == 0)
                    throw new Exception("No Free Space");
                result.Size = max;
                if (Write(fs, max, block, updater, result))
                {
                    fs.Position = 0;
                    Verify(fs, max, block, updater, result);
                }
                return result;
            }
        }

        public void DropTestFile()
        {
            try
            {
                File.Delete(TEST_FILE);
            }
            catch { }
        }

        private bool Write(FileStream fs, long max, byte[] block, DriveSizeCallback updater, DriveTestResult result)
        {
            while (fs.Position < max)
            {
                DataBlock(fs.Position, block);
                int toWrite = (int)Math.Min(max - fs.Position, MAX_BLOCK_SIZE);
                fs.Write(block, 0, toWrite);
                result.InformWrite(fs.Position);
                if (!updater(fs.Position, max, false, result))
                    return false;
            }
            return true;
        }

        private void Verify(FileStream fs, long max, byte[] block, DriveSizeCallback updater, DriveTestResult result)
        {
            byte[] rd = new byte[block.Length];
            while (fs.Position < max)
            {
                DataBlock(fs.Position, block);
                int toRead = (int)Math.Min(max - fs.Position, MAX_BLOCK_SIZE);
                if (fs.Read(rd, 0, toRead) != toRead)
                {
                    result.InformValidationEOF(fs.Position);
                    return;
                }
                bool resultActual = true;
                for (int i = 0; i < rd.Length; i++)
                    if (rd[i] != block[i])
                    {
                        resultActual = false;
                        break;
                    }
                result.InformRead(fs.Position, resultActual);
                if (!updater(fs.Position, max, true, result))
                    return;
            }
        }

        private void DataBlock(long pos, byte[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                long posi = pos + 1;
                int posA = (int)(posi % patternA.Length);
                int posB = (int)(posi % patternB.Length);
                int posC = (int)(posi % patternC.Length);
                int posD = (int)(posi % patternD.Length);
                result[i] = (byte)(patternA[posA] ^ patternB[posB] ^ patternC[posC] ^ patternD[posD]);
            }
        }

        public int Seed { get; private set; }
    }

    public class DriveTestResult
    {
        private readonly DriveTestStatistics statWrite = new DriveTestStatistics();
        private readonly DriveTestStatistics statRead = new DriveTestStatistics();
        private readonly DriveTestStatus[] status = new DriveTestStatus[2000];

        public DriveTestResult()
        {
            for (int i = 0; i < status.Length; i++)
                status[i] = DriveTestStatus.None;
        }

        internal void InformRead(long at, bool valid)
        {
            SetStatusUpdate(StatusIndex(statRead.Position), StatusIndex(at), valid ? DriveTestStatus.Verified : DriveTestStatus.Error);
            statRead.Update(at);
            Valid = Valid && valid;
            if (Valid)
                ValidUntil = at;
        }

        internal void InformWrite(long at)
        {
            SetStatusUpdate(StatusIndex(statWrite.Position), StatusIndex(at), DriveTestStatus.Written);
            statWrite.Update(at);
        }

        internal void InformValidationEOF(long at)
        {
            statRead.Update(at);
            EofProblem = true;
        }

        private void SetStatusUpdate(int from, int to, DriveTestStatus st)
        {
            if (from > to)
                from = to;
            for (int i = from; i <= to; i++)
                if (status[i] != DriveTestStatus.Error)
                    status[i] = st;
        }

        private int StatusIndex(long at)
        {
            int result = (int)(at * status.Length / Size);
            if (result == status.Length)
                result = status.Length - 1;
            return result;
        }

        public bool Valid { get; private set; } = true;
        public long ValidUntil { get; private set; } = 0;
        public long Written => statWrite.Position;
        public double WriteRatio => Written / (double)Size;
        public long WriteSpeed => statWrite.PerSecond;
        public long Verified => statRead.Position;
        public double VerifyRatio => Verified / (double)Size;
        public long VerifySpeed => statRead.PerSecond;
        public long Size { get; internal set; }
        public DriveTestStatus[] Status => status;
        public bool EofProblem { get; private set; }
    }

    class DriveTestStatistics
    {
        private DateTime lastTime = DateTime.Now;
        private long lastPosition = 0;
        private TimeSpan timeSpan = TimeSpan.FromSeconds(0);
        private long ammount = 0;

        public void Update(long at)
        {
            if (lastTime != null)
            {
                timeSpan = DateTime.Now - lastTime;
                if (at > lastPosition)
                    ammount = at - lastPosition;
            }
            lastTime = DateTime.Now;
            lastPosition = at;
        }

        public long PerSecond => ammount == 0 ? 0 : (long)(ammount / timeSpan.TotalSeconds);
        public long Position => lastPosition;
    }

    public enum DriveTestStatus
    {
        None = 0, Written = 1, Verified = 2, Error = 3
    }
}
