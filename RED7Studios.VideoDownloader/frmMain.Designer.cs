
namespace YouTube_Music_Downloader
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnYouTube = new RED7Studios.UI.Controls.ModernButton();
            this.btnFacebook = new RED7Studios.UI.Controls.ModernButton();
            this.modernButton1 = new RED7Studios.UI.Controls.ModernButton();
            this.SuspendLayout();
            // 
            // btnYouTube
            // 
            this.btnYouTube.CustomColorScheme = false;
            this.btnYouTube.Location = new System.Drawing.Point(14, 46);
            this.btnYouTube.Name = "btnYouTube";
            this.btnYouTube.Size = new System.Drawing.Size(83, 33);
            this.btnYouTube.TabIndex = 0;
            this.btnYouTube.Text = "YouTube";
            this.btnYouTube.UseVisualStyleBackColor = true;
            this.btnYouTube.Click += new System.EventHandler(this.modernButton1_Click);
            // 
            // btnFacebook
            // 
            this.btnFacebook.CustomColorScheme = false;
            this.btnFacebook.Location = new System.Drawing.Point(103, 46);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(83, 33);
            this.btnFacebook.TabIndex = 1;
            this.btnFacebook.Text = "Facebook";
            this.btnFacebook.UseVisualStyleBackColor = true;
            this.btnFacebook.Click += new System.EventHandler(this.modernButton2_Click);
            // 
            // modernButton1
            // 
            this.modernButton1.CustomColorScheme = false;
            this.modernButton1.Location = new System.Drawing.Point(192, 46);
            this.modernButton1.Name = "modernButton1";
            this.modernButton1.Size = new System.Drawing.Size(83, 33);
            this.modernButton1.TabIndex = 2;
            this.modernButton1.Text = "SoundCloud";
            this.modernButton1.UseVisualStyleBackColor = true;
            this.modernButton1.Click += new System.EventHandler(this.modernButton1_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 93);
            this.ColorScheme.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(64)))), ((int)(((byte)(101)))));
            this.ColorScheme.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(100)))), ((int)(((byte)(158)))));
            this.ColorScheme.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(189)))));
            this.ColorScheme.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.modernButton1);
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.btnYouTube);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMain";
            this.Text = "Service Picker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RED7Studios.UI.Controls.ModernButton btnYouTube;
        private RED7Studios.UI.Controls.ModernButton btnFacebook;
        private RED7Studios.UI.Controls.ModernButton modernButton1;
    }
}