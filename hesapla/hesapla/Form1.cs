using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapla
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {

        }
     
        private double vihesapla(double boy,double kilo)
        {
            return kilo / (boy * boy);
        }
        private void vücutindeksi(double boy, double kilo)
        {
            {
                double sonuç = vihesapla(boy / 100, kilo);
                sonuç = NewMethod(sonuç);
                double kiloal = 18.5 - sonuç;
                double kiloalhesap = ((kiloal * (boy * boy)) / 100) / 100;
                double kilover = sonuç - 25;
                double kiloverhesap = ((kilover * (boy * boy)) / 100) / 100;
                if (sonuç <= 18.4)
                {
                    listBox1.Items.Add("Vücut Indeksiniz : " + sonuç + " - 18.4 : Zayıf ");
                    listBox1.Items.Add(kiloalhesap + "Kilo Alman Gerekiyor");
                }
                if (sonuç >= 18.5 && sonuç <= 25)
                {
                    listBox1.Items.Add("Vücut Indeksiniz : " + sonuç + " - 18.5-24.9 arası : Normal ");

                }
                if (sonuç >= 25 && sonuç <= 29.9)
                {
                    listBox1.Items.Add("Vücut Indeksiniz : " + sonuç + " 25-29.9 arası : fazla kilolu ");
                    listBox1.Items.Add(kiloalhesap + "Kilo vermen Gerekiyor");
                }
                if (sonuç >= 30 && sonuç <= 34.9)
                {
                    listBox1.Items.Add("Vücut Indeksiniz : " + sonuç + " 30-34.9 arası : Şişman(obez) ");
                    listBox1.Items.Add(kiloalhesap + "Kilo vermen Gerekiyor");
                }

                if (sonuç >= 35 && sonuç <= 44.9)
                {
                    listBox1.Items.Add("Vücut Indeksiniz : " + sonuç + " 35-44.9 arası : Şişman(obez) -2.sınıf ");
                    listBox1.Items.Add(kiloalhesap + "Kilo vermen Gerekiyor");
                }


                if (sonuç >= 45)
                {
                    listBox1.Items.Add("Vücut Indeksiniz : " + sonuç + " 45 :  Aşırı şişman(obez) -3.sınıf ");
                    listBox1.Items.Add(kiloalhesap + "Kilo vermen Gerekiyor");
                }

            }
        }
        private static double NewMethod(double sonuc)
        {
            sonuc = Math.Round(sonuc, 2);
            return sonuc;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {

            double boy = Convert.ToInt32(metroTextBox1.Text);
            double kilo = Convert.ToInt32(metroTextBox2.Text);
            double sonuc = vihesapla(boy / 100, kilo);

            vücutindeksi(boy, kilo);

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

            Hesapla hesaplasec = new Hesapla();
            hesaplasec.Show();

            this.Hide();
        }
    }
}

