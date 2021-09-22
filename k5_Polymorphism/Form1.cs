using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k5_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba a1 = new Araba();
            a1.BirimFiyat = 10000;
            var arabaninFiyati = a1.KdvliFiyatGetir();

            var araba1 = new Araba();
            araba1.BirimFiyat = 50000;
            var arabaninSatisFiyati = araba1.KdvliFiyatGetir();


            Ekmek e1 = new Ekmek;
            e1.Turu = "beyaz ekmek";
            e1.Gramaj = 50;
            e1.StokMiktari = 1000;
            e1.BirimFiyat = 1.5;
            var ekmeginSatisFiyati = e1.KdvliFiyatGetir();//1.51


            Ekmek e2 = new Ekmek;
            e2.Turu = "tam bugday ekmegi";
            e2.Gramaj = 100;
            e2.BirimFiyat = 5;
            var tamBugdaySatisFiyati = e2.KdvliFiyatGetir();//5.05

            Televizyon t1 = new Televizyon();
            //t1.BirimFiyat = 4500;

           
        }
    }
}
