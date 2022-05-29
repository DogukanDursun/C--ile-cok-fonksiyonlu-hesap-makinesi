using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapla
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            int toplam, sayı1, sayı2;
            sayı1 = Convert.ToInt32(metroTextBox1.Text);
            sayı2 = Convert.ToInt32(metroTextBox2.Text);
            toplam = sayı1 + sayı2;
            metroLabel3.Text = Convert.ToString(toplam);
            metroTextBox1.Text = ("");
            metroTextBox2.Text = ("");

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            int toplam, sayı1, sayı2;
            sayı1 = Convert.ToInt32(metroTextBox1.Text);
            sayı2 = Convert.ToInt32(metroTextBox2.Text);
            toplam = sayı1 - sayı2;
            metroLabel3.Text = Convert.ToString(toplam);
            metroTextBox1.Text = ("");
            metroTextBox2.Text = ("");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
            int toplam, sayı1, sayı2;
            sayı1 = Convert.ToInt32(metroTextBox1.Text);
            sayı2 = Convert.ToInt32(metroTextBox2.Text);
            toplam = sayı1 * sayı2;
            metroLabel3.Text = Convert.ToString(toplam);
            metroTextBox1.Text = ("");
            metroTextBox2.Text = ("");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
          
            int toplam, sayı1, sayı2;
            sayı1 = Convert.ToInt32(metroTextBox1.Text);
            sayı2 = Convert.ToInt32(metroTextBox2.Text);
            toplam = sayı1 / sayı2;
            metroLabel3.Text = Convert.ToString(toplam);
            metroTextBox1.Text = ("");
            metroTextBox2.Text = ("");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Hesapla hesaplasec = new Hesapla();
            hesaplasec.Show();

            this.Hide();
        }
    }
}
