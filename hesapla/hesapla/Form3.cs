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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int sonuç,sayı1,sayı2;
            sayı1 = Convert.ToInt32(metroTextBox1.Text);
            sayı2 = Convert.ToInt32(metroTextBox2.Text);
            sonuç = ((sayı1 * sayı2)/100);
            metroLabel3.Text = Convert.ToString(sonuç);
            metroTextBox1.Text = ("");
            metroTextBox2.Text = ("");

        }

        private void metroLabel2_Click(object sender, EventArgs e)
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
