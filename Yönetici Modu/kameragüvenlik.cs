using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MostemA___Gelistirme
{
    public partial class kameragüvenlik : MetroFramework.Forms.MetroForm
    {
        
        public kameragüvenlik()
        {
            InitializeComponent();
            metroTextBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void kameragüvenlik_Load(object sender, EventArgs e)
        {
            metroTextBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text == "admin" && metroTextBox2.Text == "admin")
            {
                this.Close();
                kamerakontrolu kamerakontrolu = new kamerakontrolu();
                kamerakontrolu.ShowDialog();

            }

            else if (metroTextBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Girmediniz");
            }

            else if (metroTextBox2.Text == "")
            {
                MessageBox.Show("Şifreyi Girmediniz");
            }

            else
            {
                MessageBox.Show("Hatalı Giriş...");
            }
        }
    }
}
