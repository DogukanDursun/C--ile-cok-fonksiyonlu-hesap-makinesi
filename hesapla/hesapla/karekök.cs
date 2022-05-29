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
    public partial class karekök : MetroFramework.Forms.MetroForm
    {
        public karekök()
        {
            InitializeComponent();
        }

        private void karekök_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            double sayı1;
            sayı1 = Convert.ToInt32(metroTextBox1.Text);
            double karakok1 = Math.Sqrt(sayı1);
            metroLabel2.Text = Convert.ToString("sonuç = "+karakok1);

        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            Hesapla hesaplasec = new Hesapla();
            hesaplasec.Show();

            this.Hide();
        }
    }
}
