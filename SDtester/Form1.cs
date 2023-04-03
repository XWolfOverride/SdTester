using SDtester.i18n;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shell;

namespace SDtester
{
    public partial class Form1 : Form
    {
        private const int PROGRESSBAR_RESOLUTION = 10000;

        private DriveSizeTest tester;
        private bool active = false;
        private TaskbarItemInfo tb;
        private string oTitle;
        private DriveTestResult result;
        private StatusProgressImage spi = new StatusProgressImage();

        public Form1()
        {
            InitializeComponent();
            lbDrive.Text = I18n.Get().LabelDrive;
            cbDrive.Left = lbDrive.Right + 5;
            lbHint.Text = I18n.Get().LabelExplain;
            tb = new TaskbarItemInfo();
            oTitle = Text;
            pbTotal.Maximum = PROGRESSBAR_RESOLUTION;
            Finish();
            lbProgress.Text = I18n.Get().StatusGoHint;
            lbWriteSpeed.Text = I18n.Get().LabelWriteSpeed;
            lbWriteSpeedValue.Text = string.Empty;
            lbReadSpeed.Text = I18n.Get().LabelReadSpeed;
            lbReadSpeedValue.Text = string.Empty;
            UpdateDrives();
        }

        private void UpdateDrives()
        {
            cbDrive.Items.Clear();
            foreach (var d in DriveSizeTest.ListDrives())
                cbDrive.Items.Add(d);
            if (cbDrive.Items.Count > 0)
                cbDrive.SelectedIndex = 0;
        }

        private void Finish()
        {
            Text = oTitle;
            tb.ProgressState = TaskbarItemProgressState.None;
            btGo.Text = I18n.Get().ButtonGo;
            if (tester != null)
                if (result.Valid)
                    tester.DropTestFile();
                else if (MessageBox.Show(I18n.Get().MsgValidErrorText, I18n.Get().MsgValidErrorTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    tester.DropTestFile();
            if (tester != null)
                tester = null;
        }

        private void Stop()
        {
            lbProgress.Text = I18n.Get().StatusCancelled + lbProgress.Text;
            active = false;
        }

        private void Start()
        {
            lbProgress.ForeColor = SystemColors.ControlText;
            lbProgress.Text = I18n.Get().StatusStarting;
            btGo.Text = I18n.Get().ButtonCancel;
            if (tester == null)
            {
                tb.ProgressState = TaskbarItemProgressState.Normal;
                Application.DoEvents();
                active = true;
                tester = new DriveSizeTest();
                try
                {
                    tester.Test(cbDrive.SelectedItem as DriveInfo, TestUpdate);
                }
                catch (Exception ex)
                {
                    lbProgress.Text = ex.GetType().Name + ": " + ex.Message;
                    lbProgress.ForeColor = Color.Red;
                    MessageBox.Show(lbProgress.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Finish();
                }
            }
        }

        private bool TestUpdate(long progress, long max, bool verif, DriveTestResult result)
        {
            Application.DoEvents();
            double pcn = (progress / (max * 2.0)) * 100;
            if (verif)
                pcn += 50.0;
            string pcns = $"{pcn.ToString("0.###")}%";
            lbProgress.Text = $"{(verif ? I18n.Get().StatusVerifying : I18n.Get().StatusWriting)} {FBytes(progress)} / {FBytes(max)} ({pcns})";
            tb.ProgressValue = pcn;
            pbTotal.Value = (int)((pcn / 100.0) * PROGRESSBAR_RESOLUTION);
            Text = $"{oTitle} [{pcns}]";
            lbWriteSpeedValue.Text = FBytes(result.WriteSpeed);
            lbReadSpeedValue.Text = FBytes(result.VerifySpeed);
            this.result = result;
            ppbstatus.Invalidate();
            return active;
        }

        private string FBytes(long sz)
        {
            if (sz == 0)
                return string.Empty;
            string tail = "bytes";
            if (sz > 1024)
            {
                tail = "KB";
                sz /= 1024;
            }
            if (sz > 1024)
            {
                tail = "MB";
                sz /= 1024;
            }
            if (sz > 1024)
            {
                tail = "GB";
                sz /= 1024;
            }
            if (sz > 1024)
            {
                tail = "TB";
                sz /= 1024;
            }
            if (sz > 1024)
            {
                tail = "PB";
                sz /= 1024;
            }
            return $"{sz}{tail}";
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            if (tester == null)
                Start();
            else
                Stop();
        }

        private void lbHint_Resize(object sender, EventArgs e)
        {
            ppbstatus.Invalidate();
        }

        private void ppbstatus_Paint(object sender, PaintEventArgs e)
        {
            spi.Size = ppbstatus.Size;
            e.Graphics.DrawImage(spi.Draw(result?.Status), 0, 0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tester != null)
                Stop();
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            FAbout fa = new FAbout();
            fa.ShowDialog();
        }
    }
}
