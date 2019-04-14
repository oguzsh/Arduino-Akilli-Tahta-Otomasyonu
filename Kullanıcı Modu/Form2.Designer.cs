namespace MostemA___Gelistirme
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar3 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(145, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "0";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(123, 114);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Gelen Veri";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(82, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(163, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Akıllı Tahta Kullanıcı";
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(-7, 79);
            this.metroProgressBar2.Minimum = 100;
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(740, 13);
            this.metroProgressBar2.TabIndex = 6;
            this.metroProgressBar2.Value = 100;
            // 
            // metroProgressBar3
            // 
            this.metroProgressBar3.Location = new System.Drawing.Point(-7, 234);
            this.metroProgressBar3.Minimum = 100;
            this.metroProgressBar3.Name = "metroProgressBar3";
            this.metroProgressBar3.Size = new System.Drawing.Size(740, 12);
            this.metroProgressBar3.TabIndex = 7;
            this.metroProgressBar3.Value = 100;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(137, 256);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "oguzsh";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(332, 290);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroProgressBar3);
            this.Controls.Add(this.metroProgressBar2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}