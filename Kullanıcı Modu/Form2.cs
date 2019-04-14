using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace MostemA___Gelistirme
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
            serialPort1.PortName = ("COM4");
            serialPort1.BaudRate = 9600;
            serialPort1.Open();

        }



        private void Form2_Load(object sender, EventArgs e)
        {

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);

        }



        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                string sonuc = serialPort1.ReadExisting();
                label1.Text = sonuc + "";

                if (label1.Text == "A")
                {
                    
                    Application.SetSuspendState(PowerState.Suspend, false, false);
                }
                if (label1.Text == "B")
                {

                    System.Diagnostics.Process.Start("shutdown", "-s -f -t 0");


                }
            }

            catch
            {
                this.Close();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sonuc = serialPort1.ReadExisting();
            label1.Text = sonuc + "";

            if (label1.Text == "A")
            {
                Application.SetSuspendState(PowerState.Suspend, false, false);
            }

            if (label1.Text == "B")
            {
                System.Diagnostics.Process.Start("shutdown", "-s -f -t 0");
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0 = Gelen Veriyi Gösteren Ekrandır.", "Bilgi");
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}