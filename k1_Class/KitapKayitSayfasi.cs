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
    public partial class KitapKayitSayfasi : Form
    {
        public KitapKayitSayfasi()
        {
            InitializeComponent();
        }

        private void KitapKayitSayfasi_Load(object sender, EventArgs e)
        {
            //cmb icini turlerle doldurmamiz gerekiyor
            // string[] turler = {"gerilim", "roman", "hikaye"};
            //cmbTuru.Items.AddRange(turler) /// Bu sekilde veya asagidaki sekilde yazabilirsiniz

            cmbTuru.Items.Add("Gerilim");
            cmbTuru.Items.Add("Roman");
            cmbTuru.Items.Add("Hikaye");
            cmbTuru.Items.Add("Tarih");
            cmbTuru.Items.Add("Akademik");
            // cmbx in sayfa acildigi zaman dolu olarak gelmesini istiyorsak yukaridaki gibi iki yontemle yapabiliriz.
        }
        Kitap[] kitaplar = new Kitap[0];
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();

            kitap.KitapAdi = txtKitapAdi.Text;
            kitap.YazarAdiSoyadi = txtYazarAdiSoyadi.Text;
            kitap.Fiyat = Convert.ToDouble(txtFiyat.Text);
            kitap.Turu = cmbTuru.SelectedItem.ToString();
            kitap.Yayinevi = txtYayinevi.Text;
            kitap.BasimTarihi = dtpBasimTarihi.Value;
            kitap.SayfaSayisi = txtSayfaSayisi.Text;

            Array.Resize(ref kitaplar, kitaplar.Length + 1);
            kitaplar[kitaplar.Length - 1] = kitap;





            // Temizle butonuna basarak
        }

    } 
}
