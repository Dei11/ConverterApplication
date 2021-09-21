
namespace ConverterApplication
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.txtBoxFileName = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.cmbBox = new System.Windows.Forms.ComboBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(200, 56);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(54, 30);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "Url: ";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(200, 118);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(123, 30);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "File Name: ";
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBoxUrl.Location = new System.Drawing.Point(335, 56);
            this.txtBoxUrl.Multiline = true;
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(154, 30);
            this.txtBoxUrl.TabIndex = 3;
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBoxFileName.Location = new System.Drawing.Point(335, 118);
            this.txtBoxFileName.Multiline = true;
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(154, 30);
            this.txtBoxFileName.TabIndex = 4;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(205, 165);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(122, 32);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // cmbBox
            // 
            this.cmbBox.FormattingEnabled = true;
            this.cmbBox.Items.AddRange(new object[] {
            "Mp3",
            "Mp4"});
            this.cmbBox.Location = new System.Drawing.Point(368, 165);
            this.cmbBox.Name = "cmbBox";
            this.cmbBox.Size = new System.Drawing.Size(121, 21);
            this.cmbBox.TabIndex = 6;
            this.cmbBox.Text = "Mp3";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::ConverterApplication.Properties.Resources.mp3_icon;
            this.picBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(182, 185);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 301);
            this.Controls.Add(this.cmbBox);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtBoxFileName);
            this.Controls.Add(this.txtBoxUrl);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.picBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouTube to MP3/MP4 converter";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.TextBox txtBoxFileName;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ComboBox cmbBox;
    }
}

