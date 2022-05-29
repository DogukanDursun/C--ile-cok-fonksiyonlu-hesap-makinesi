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
    public partial class Hesapla : MetroFramework.Forms.MetroForm
    {
        public Hesapla()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form2 form2sec = new Form2();
                      form2sec.Show();
              
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form3 form3sec = new Form3();
            form3sec.Show();

            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();

            this.Hide();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            karekök kare = new karekök();
            kare.Show();
            this.Hide();
        }
    }
}
