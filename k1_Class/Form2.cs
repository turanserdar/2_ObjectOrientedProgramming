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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            //Ogrenci sinifi olusturalim
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Ad = "Serdar";
            ogrenci1.SoyAd = "Turan";
            

            MessageBox.Show(ogrenci1.Ad);
        }
    }
}
