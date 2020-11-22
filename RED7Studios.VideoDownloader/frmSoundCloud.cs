using RED7Studios.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTube_Music_Downloader
{
    public partial class frmSoundCloud : ModernForm
    {
        public frmSoundCloud()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = @"/C bin\youtube-dl -o " + textBox1.Text + @"\%(title)s.%(ext)s -f mp4 " + tbURL.Text;

            Console.WriteLine(strCmdText);
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("bin\\soundclouddir.txt"))
            {
                textBox1.Text = File.ReadAllText("bin\\soundclouddir.txt");
            }
        }

        private void modernButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Path.GetDirectoryName(openFileDialog1.FileName);
                using (StreamWriter sw = new StreamWriter("bin\\soundclouddir.txt"))
                {
                    sw.WriteLine(Path.GetDirectoryName(openFileDialog1.FileName));
                }
            }
        }
    }
}
