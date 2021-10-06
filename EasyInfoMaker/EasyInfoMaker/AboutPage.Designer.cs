namespace EasyInfoMaker
{
    partial class AboutPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPage));
            this.exit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutText = new System.Windows.Forms.Label();
            this.eMail = new System.Windows.Forms.Label();
            this.gMail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Image = global::EasyInfoMaker.Properties.Resources.Exit;
            this.exit.Location = new System.Drawing.Point(187, 322);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(97, 29);
            this.exit.TabIndex = 3;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Back
            // 
            this.Back.Image = global::EasyInfoMaker.Properties.Resources.Back;
            this.Back.Location = new System.Drawing.Point(0, 322);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(97, 29);
            this.Back.TabIndex = 2;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyInfoMaker.Properties.Resources.EasyInfoMaker;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // aboutText
            // 
            this.aboutText.Location = new System.Drawing.Point(10, 80);
            this.aboutText.Name = "aboutText";
            this.aboutText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aboutText.Size = new System.Drawing.Size(260, 142);
            this.aboutText.TabIndex = 4;
            this.aboutText.Text = resources.GetString("aboutText.Text");
            // 
            // eMail
            // 
            this.eMail.AutoSize = true;
            this.eMail.Location = new System.Drawing.Point(12, 222);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(112, 13);
            this.eMail.TabIndex = 5;
            this.eMail.Text = "ertebpor@yahoo.com";
            // 
            // gMail
            // 
            this.gMail.AutoSize = true;
            this.gMail.Location = new System.Drawing.Point(12, 245);
            this.gMail.Name = "gMail";
            this.gMail.Size = new System.Drawing.Size(110, 13);
            this.gMail.TabIndex = 6;
            this.gMail.Text = "kyoosefid@gmail.com";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 283);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(255, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "طراح و برنامه نویس:            کیارش یوسفی دماوندی";
            // 
            // AboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 351);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gMail);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.aboutText);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درباره";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label aboutText;
        private System.Windows.Forms.Label eMail;
        private System.Windows.Forms.Label gMail;
        private System.Windows.Forms.Label label1;
    }
}