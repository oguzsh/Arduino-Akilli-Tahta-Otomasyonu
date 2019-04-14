namespace MostemA___Gelistirme
{
    partial class kameralar
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
            this.kapat = new System.Windows.Forms.PictureBox();
            this.kaydet = new System.Windows.Forms.PictureBox();
            this.durdur = new System.Windows.Forms.PictureBox();
            this.devamET = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaydet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durdur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devamET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kapat
            // 
            this.kapat.Image = global::MostemA___Gelistirme.Properties.Resources.error1;
            this.kapat.Location = new System.Drawing.Point(0, 163);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(70, 39);
            this.kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kapat.TabIndex = 6;
            this.kapat.TabStop = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // kaydet
            // 
            this.kaydet.Image = global::MostemA___Gelistirme.Properties.Resources.save;
            this.kaydet.Location = new System.Drawing.Point(0, 118);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(70, 39);
            this.kaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kaydet.TabIndex = 5;
            this.kaydet.TabStop = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // durdur
            // 
            this.durdur.Image = global::MostemA___Gelistirme.Properties.Resources.stop_1;
            this.durdur.Location = new System.Drawing.Point(0, 73);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(70, 39);
            this.durdur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.durdur.TabIndex = 4;
            this.durdur.TabStop = false;
            this.durdur.Click += new System.EventHandler(this.durdur_Click);
            // 
            // devamET
            // 
            this.devamET.Image = global::MostemA___Gelistirme.Properties.Resources.restart;
            this.devamET.Location = new System.Drawing.Point(0, 28);
            this.devamET.Name = "devamET";
            this.devamET.Size = new System.Drawing.Size(70, 39);
            this.devamET.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.devamET.TabIndex = 3;
            this.devamET.TabStop = false;
            this.devamET.Click += new System.EventHandler(this.devamET_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // kameralar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 405);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.durdur);
            this.Controls.Add(this.devamET);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "kameralar";
            this.Text = "Kamera Kontrol Paneli";
            this.Load += new System.EventHandler(this.kameralar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaydet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durdur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devamET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox devamET;
        private System.Windows.Forms.PictureBox durdur;
        private System.Windows.Forms.PictureBox kaydet;
        private System.Windows.Forms.PictureBox kapat;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}