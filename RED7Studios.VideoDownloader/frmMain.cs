using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTube_Music_Downloader
{
    public partial class frmMain : ModernForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void modernButton1_Click(object sender, EventArgs e)
        {
            frmYouTube youtube = new frmYouTube();
            youtube.Show();
        }

        private void modernButton2_Click(object sender, EventArgs e)
        {
            frmFacebook facebook = new frmFacebook();
            facebook.Show();
        }

        private void modernButton1_Click_1(object sender, EventArgs e)
        {
            frmSoundCloud soundcloud = new frmSoundCloud();
            soundcloud.Show();
        }
    }
}
