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
    public partial class frmYouTube : ModernForm
    {
        public frmYouTube()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            string strCmdText;

            if (cbFormat.Text == "mp3")
            {
                strCmdText = @"/C bin\youtube-dl -o " + textBox1.Text + @"\%(title)s.%(ext)s --extract-audio --audio-format " + cbFormat.Text + " " + tbURL.Text;
            }
            else
            {
                strCmdText = "/C bin\\youtube-dl -i -f " + cbFormat.Text + " -o " + textBox1.Text + @"\%(title)s.%(ext)s " + tbURL.Text;
            }

            Console.WriteLine(strCmdText);
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modernButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Path.GetDirectoryName(openFileDialog1.FileName);
                using (StreamWriter sw = new StreamWriter("bin\\youtubedir.txt"))
                {
                    sw.WriteLine(Path.GetDirectoryName(openFileDialog1.FileName));
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("bin\\youtubedir.txt"))
            {
                textBox1.Text = File.ReadAllText("bin\\youtubedir.txt");
            }
        }
    }
}
