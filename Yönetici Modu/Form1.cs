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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();            
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
            if (serialPort1.IsOpen) serialPort1.Close();
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form2 yeniform = new Form2();
            yeniform.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            webkonferans webkonferans = new webkonferans();
            webkonferans.ShowDialog();
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            kameragüvenlik kameragüvenlik = new kameragüvenlik();
            kameragüvenlik.ShowDialog();
        }
    }
}
