using SDtester.i18n;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDtester
{
    public partial class FAbout : Form
    {
        public FAbout()
        {
            InitializeComponent();
            Text = I18n.Get().AboutTitle;
            lbInfo.Text = I18n.Get().AboutText;
            lbTranslation.Text = I18n.Get().AboutTranslation;
        }

        private void llGO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/XWolfOverride/SdTester");
        }

        private void llIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://lukaszadam.com/");
        }
    }
}
