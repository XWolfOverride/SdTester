using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDtester
{
    internal class StatusProgressImage
    {
        private Size size;
        private Bitmap bmp;
        private Pen p_border;
        private Pen p_written;
        private Pen p_valid;
        private Pen p_error;

        public StatusProgressImage()
        {
            Resize(new Size());
            p_border = new Pen(Color.DarkSlateGray, 1);
            p_written = new Pen(Color.CornflowerBlue, 1);//new Pen(Color.CadetBlue, 1);
            p_valid = new Pen(Color.LawnGreen, 1);
            p_error = new Pen(Color.LightCoral, 1);
        }

        private void Resize(Size sz)
        {
            if (sz == size)
                return;
            size = sz;
            if (bmp != null)
            {
                bmp.Dispose();
                bmp = null;
            }
            if (size.Width > 0 || size.Height > 0)
                bmp = new Bitmap(size.Width, size.Height);
        }

        public Bitmap Draw(DriveTestStatus[] sta)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                int h = size.Height - 1;
                int w = size.Width - 1;
                g.DrawLine(p_border, 1, 0, w-1, 0);
                g.DrawLine(p_border, 1, h, w-1, h);
                g.DrawLine(p_border, 0, 1, 0, h-1);
                g.DrawLine(p_border, w, 1, w, h-1);
                if (sta != null)
                {
                    w--;
                    h--;
                    int lastpos = 0;
                    for (int i = 0; i < w; i++)
                    {
                        int pos = (i * sta.Length) / w;
                        DriveTestStatus st;
                        if (lastpos < pos)
                        {
                            //Priority for error in block
                            lastpos++;
                            st = sta[lastpos];
                            for (var j = lastpos; j < pos; j++)
                            {
                                st = sta[j];
                                if (st == DriveTestStatus.Error)
                                    break;
                            }
                            lastpos = pos;
                        }
                        else
                            st = sta[lastpos];
                        Pen p;
                        switch (st)
                        {
                            case DriveTestStatus.Error:
                                p = p_error;
                                break;
                            case DriveTestStatus.Verified:
                                p = p_valid;
                                break;
                            case DriveTestStatus.Written:
                                p = p_written;
                                break;
                            default:
                                continue;
                        }
                        g.DrawLine(p, i+1, 1, i+1, h);
                    }
                }
            }
            return bmp;
        }

        public Size Size { get => size; set => Resize(value); }

    }
}
