using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k1_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenciOlustur_Click(object sender, EventArgs e)
        {
            // Ogrenci sinifindan bir kopya olustrarak bir ogrencinin detay bilgisini girelim.

            //

            Ogrenci ogr = new Ogrenci();

            ogr._ad = "Serdar";
            ogr._soyad = "Turan";
            ogr._bolum = "Insaat Muhendisligi";
            ogr._kanGrubu = "A";
            ogr._ogrenciNUmarasi = "200";
            ogr._adres = "Ankara";

            Ogrenci ogr1 = new Ogrenci();
            ogr1._ad = "Batuhan";
            ogr1._soyad = "Engez";
            ogr1._kanGrubu = "0Rh+";
            ogr1._ogrenciNUmarasi = "203";
            ogr1._bolum = "bilgisayar programciligi";
            ogr1._adres = "Istanbul";


            // Nesnenin elemanlarini formdaki labellarda gosterelim
            //  lblAd.Text = "serdar"; yapmak istedigim seyi boyle yapmak degil. Bunu daha once yaptim

            lblAd.Text = ogr._ad;
            lblSoyad.Text = ogr._soyad;
            lblAdres.Text = ogr._adres;
            lblKanGrubu.Text = ogr._kanGrubu;
            lblBolum.Text = ogr._bolum;



        
        }

        private void btnAraba_Click(object sender, EventArgs e)
        {
            var  audi1 = new Araba();

            var audi2 = new Araba();
            audi2._marka = "Audi";
            audi2._model = "A6";
            audi2._manelMi =true;




        }
    }
}
