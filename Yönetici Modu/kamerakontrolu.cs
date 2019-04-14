using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace MostemA___Gelistirme
{
    public partial class kamerakontrolu : MetroFramework.Forms.MetroForm
    {
        private FilterInfoCollection webcam;

        private VideoCaptureDevice cam;
        
        public kamerakontrolu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cam = new

            VideoCaptureDevice(webcam[metroComboBox1.SelectedIndex].MonikerString); //başlaya basıldığıdnda yukarda tanımladığımız cam değişkenine comboboxta seçilmş olan kamerayı atıyoruz.

            cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);

            cam.Start(); //kamerayı başlatıyoruz.
        }

        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone(); //kısaca bu eventta kameradan alınan görüntüyü picturebox a atıyoruz.

            pictureBox1.Image = bmp;
            pictureBox2.Image = bmp;
            pictureBox3.Image = bmp;
            pictureBox4.Image = bmp;

        }
        
        private void kamerakontrolu_Load(object sender, EventArgs e)
        {
            webcam = new

            FilterInfoCollection(FilterCategory.VideoInputDevice); //webcam dizisine mevcut kameraları dolduruyoruz.

            foreach (FilterInfo item in webcam)
            {

                metroComboBox1.Items.Add(item.Name); //kameraları combobox a dolduruyoruz.

            }

            metroComboBox1.SelectedIndex = 0;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SaveFileDialog swf = new SaveFileDialog();

            swf.Filter = "(*.jpg)|*.jpg|Bitma*p(*.bmp)|*.bmp";

            DialogResult dialog = swf.ShowDialog();  //resmi çekiyoruz ve aşağıda da kaydediyoruz.


            if (dialog == DialogResult.OK)
            {

                pictureBox1.Image.Save(swf.FileName);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
