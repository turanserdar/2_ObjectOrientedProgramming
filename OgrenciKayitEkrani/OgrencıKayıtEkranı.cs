using System;
using System.Windows.Forms;

namespace OgrenciKayitEkrani
{
    public partial class OgrencıKayıtEkranı : Form
    {
        public OgrencıKayıtEkranı()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Kan gruplarinin combox a atanmasi

            cmbKanGrubu.Items.Add("A Rh+");
            cmbKanGrubu.Items.Add("A Rh-");
            cmbKanGrubu.Items.Add("B Rh+");
            cmbKanGrubu.Items.Add("B Rh-");
            cmbKanGrubu.Items.Add("AB Rh+");
            cmbKanGrubu.Items.Add("AB Rh-");
            cmbKanGrubu.Items.Add("0 Rh+");
            cmbKanGrubu.Items.Add("0 Rh-");

            //Cinsiyet

            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadin");



            //Ogrenim Tipi

            cmbOgrenimTipi.Items.Add("Normal Öğretim");
            cmbOgrenimTipi.Items.Add("İkinci Öğretim");
            cmbOgrenimTipi.Items.Add("Uzaktan Öğretim");




            //Kayit Tipi

            cmbKayitTipi.Items.Add("Yeni Kayıt");
            cmbKayitTipi.Items.Add("Yatay Geçiş");
            cmbKayitTipi.Items.Add("Dikey Geçiş");







        }




        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUyruk_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                opnFilePhoto.ShowDialog();
                opnFilePhoto.Filter = "Png Dosyalari |*.png|Jpg Dosyalari |*.jpg";
                pbxFoto.ImageLocation = opnFilePhoto.FileName;

                MessageBox.Show("Fotoğraf Eklendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Olustu");
            }
        }

        private void btnDeğiştir_Click(object sender, EventArgs e)
        {
            try
            {

                opnFilePhoto.ShowDialog();
                opnFilePhoto.Filter = "Png Dosyalari |*.png|Jpg Dosyalari |*.jpg";
                pbxFoto.ImageLocation = opnFilePhoto.FileName;

                MessageBox.Show("Fotoğraf Eklendi.");


            }
            catch (Exception )
            {
                MessageBox.Show("Hata Olustu");

            }
        }

        Ogrenci[] kayitlar = new Ogrenci[0];
        Ogrenci kayit = new Ogrenci();

        private void btnYeniKayıtEkle_Click(object sender, EventArgs e)
        {

            try
            {


                BosBirakma();
                kayit.Adi = txtAd.Text;
                kayit.SoyAdi = txtSoyad.Text;
                kayit.BabaAdi = txtBabaAdi.Text;
                kayit.AnneAdi = txtAnneAdi.Text;
                kayit.DogumYeri = txtDogumYeri.Text;
                kayit.DogumTarihi = dtpDogumTarihi.Value;
                kayit.KanGrubu = cmbKanGrubu.SelectedItem.ToString();
                kayit.Uyrugu = txtUyruk.Text;
                kayit.Cinsiyeti = cmbCinsiyet.SelectedItem.ToString();
                kayit.MedeniHali = txtMedeniHali.Text;

                //iletisim bilgileri

                kayit.Telefon = txtTelefon.Text;
                kayit.Gsm = txtGsm.Text;
                kayit.EMail = txtEmail.Text;
                kayit.Adres = txtAdres.Text;

                // Nufusa kayitli old.

                kayit.Il = txtIl.Text;
                kayit.Ilce = txtIlce.Text;
                kayit.Mahalle = txtMahalle.Text;
                kayit.CiltNo = txtCiltNo.Text;
                kayit.AileSiraNo = txtAileSiraNo.Text;
                kayit.SiraNo = txtSiraNo.Text;

                //Egitim bilgileri

                kayit.Numara = txtNumara.Text;
                kayit.Sinifi = txtSinif.Text;
                kayit.Bolum = txtBolum.Text;
                kayit.Fakulte = txtFakulte.Text;
                kayit.OgrenimTipi = cmbOgrenimTipi.SelectedItem.ToString();
                
                kayit.KayitTarihi = dtpKayitTarihi.Value;
                kayit.KayitTipi = cmbKayitTipi.SelectedItem.ToString();
                kayit.GeldigiOkul = txtGeldigiOkul.Text;

                //Ulasilabilecek Yakin Bilgisi

                kayit.YakinAd = txtYakinAdi.Text;
                kayit.YakinSoyAd = txtYakinSoyadi.Text;
                kayit.YakinlikDerecesi = txtYakinlikDerecesi.Text;
                kayit.YakinTelefon = txtYakinTelefonu.Text;
                kayit.YakinGsm = txtYakinGsm.Text;
               
                kayit.YakinAdres = txtYakinAdres.Text;

                kayit.Not = txtNot.Text;

                Array.Resize(ref kayitlar, kayitlar.Length + 1);
                kayitlar[kayitlar.Length - 1] = kayit;

                foreach (var kayit2 in kayitlar)
                {
                    lstBilgi.Items.Add(kayitlar[kayitlar.Length - 1]);
                }



            }
            catch (Exception)
            {

                MessageBox.Show("Hicbir veri bos birakilamaz");
            }


        }
        private void BosBirakma()
        {
            foreach (var control in Controls)
            {

                if (control is TextBox)
                {
                    var txt = (TextBox)control;

                    if (txt.ToString() == "")
                    {
                        MessageBox.Show("Hicbir veri bos birakilamaz");
                    }
                }





                if (control is ComboBox)
                {
                    var cmb = (ComboBox)control;
                    if (cmb.SelectedIndex is -1)
                    {
                        MessageBox.Show("Hicbir veri bos birakilamaz");
                    }
                }


                if (control is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)control;

                    if (dtp.Value == DateTime.Today)
                    {
                        MessageBox.Show("Gecerli bir tarih giriniz");
                    }


                }
            }
        }

        private void FormuTemizle()
        {
            foreach (var control in Controls)
            {

                if (control is TextBox)
                {
                    var txt = (TextBox)control;
                    txt.Clear();

                }
                if (control is ComboBox)
                {
                    var cmb = (ComboBox)control;
                    cmb.SelectedIndex = -1;
                }
                if (control is DateTimePicker)
                {
                    var dtp = (DateTimePicker)control;
                    dtp.Value = DateTime.Now;
                }

                if (control is PictureBox)
                {
                    var pbx = (PictureBox)control;
                    pbx.Image = null;
                }
            }
        }


        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void lstBilgi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilenEleman = (Ogrenci)lstBilgi.SelectedItem;

            txtAd.Text = secilenEleman.Adi;
            txtSoyad.Text = secilenEleman.SoyAdi;
            txtBabaAdi.Text = secilenEleman.BabaAdi;
            txtAnneAdi.Text = secilenEleman.AnneAdi;
            txtDogumYeri.Text = secilenEleman.DogumYeri;
            dtpDogumTarihi.Value = secilenEleman.DogumTarihi;
            cmbKanGrubu.SelectedItem = secilenEleman.KanGrubu;
            txtUyruk.Text = secilenEleman.Uyrugu;
            cmbCinsiyet.SelectedItem = secilenEleman.Cinsiyeti;
            txtMedeniHali.Text = secilenEleman.MedeniHali;

            //iletisim bilgileri
            txtTelefon.Text = secilenEleman.Telefon;
            txtGsm.Text = secilenEleman.Gsm;
            txtEmail.Text = secilenEleman.EMail;
            txtAdres.Text = secilenEleman.Adres;


            // Nufusa kayitli old.
            txtIl.Text = secilenEleman.Il;
            txtIlce.Text = secilenEleman.Ilce;
            txtMahalle.Text = secilenEleman.Mahalle;
            txtCiltNo.Text = secilenEleman.CiltNo;
            txtAileSiraNo.Text = secilenEleman.AileSiraNo;
            txtSiraNo.Text = secilenEleman.SiraNo;

            //Egitim bilgileri
            txtNumara.Text = secilenEleman.Numara;
            txtSinif.Text = secilenEleman.Sinifi;
            txtBolum.Text = secilenEleman.Bolum;
            txtFakulte.Text = secilenEleman.Fakulte;
            cmbOgrenimTipi.SelectedItem = secilenEleman.OgrenimTipi;
            cmbKayitTipi.SelectedItem = secilenEleman.KayitTipi;
            dtpKayitTarihi.Value = secilenEleman.KayitTarihi;
         

            cmbKayitTipi.SelectedItem = secilenEleman.KayitTipi;
            txtGeldigiOkul.Text = secilenEleman.GeldigiOkul;


            //Ulasilabilecek Yakin Bilgisi
            txtYakinAdi.Text = secilenEleman.YakinAd;
            txtYakinSoyadi.Text = secilenEleman.YakinSoyAd;
            txtYakinlikDerecesi.Text = secilenEleman.YakinlikDerecesi;
            txtYakinTelefonu.Text = secilenEleman.YakinTelefon;
            txtYakinGsm.Text = secilenEleman.YakinGsm;
            txtYakinAdres.Text = secilenEleman.YakinAdres;
            txtNot.Text = secilenEleman.Not;


        }

        
    }
}




