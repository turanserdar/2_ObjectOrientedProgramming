using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciKayitEkrani
{
    class Ogrenci
    {

        #region Field


   

        // KIMLIK BILGILERI 
        private string _adi;
        private string _soyAdi;
        private string _babaAdi;
        private string _anneAdi;
        private string _dogumYeri;
        private DateTime _dogumTarihi;

        private string _kanGrubu;
        private string _uyrugu;
        private string _cinsiyeti; // erkek, kadin /checkbox seklinde olsun
        private string _medeniHali;

        //Nufusa Kayitli Bilgileri
        private string _il;
        private string _ilce;
        private string _mahalle;
        private string _ciltNo;
        private string _aileSiraNo;
        private string _siraNo;

        // Iletisim Bilgileri

        private string _telefon; // Basinda sifir olmadan girilecek.
        private string _gsm; // Basinda sifir olmadan girilecek.
        private string _email;
        private string _adres;
       



        // Okulla ilgili bilgiler

        private string _bolum;
        private string _fakulte;
        private string _ogrenimTipi; // Orgun, 2.ogretim, uzaktan cmbx kullan
        private string _sinifi; // cmbx kullan 1.sinif 1. donem gibi secsin
        private string _kayitTipi; // Yeni kayit mi? Yatay gecis mi? Dikey Gecis mi?
        private string _geldigiOkul; // Yatay gecis veya dikey gecis se burayi girmek zorunda olsun. Yoksa enabled kismina bak.
        private string _numara;
        private DateTime _kayitTarihi;    // Otomatik now girilsin

        // Ulasilabilecek bir yakin bilgisi

        private string _yakinAd;
        private string _yakinSoyAd;
        private string _yakinlikDerecesi;
        private string _yakinTelefon;
        private string _yakinGsm;
        private string _yakinAdres;

        private string _not;  // Asagi dogru satirlari inen textbox olacak

        #endregion

        #region Property
        // KIMLIK BILGILERI 
        public string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }
        public string SoyAdi
        {
            get { return _soyAdi; }
            set { _soyAdi = value; }
        }

        public string BabaAdi
        {
            get { return _babaAdi; }
            set { _babaAdi = value; }
        }

        public string AnneAdi
        {
            get { return _anneAdi; }
            set { _anneAdi = value; }
        }

        public string DogumYeri
        {
            get { return _dogumYeri; }
            set { _dogumYeri = value; }
        }

        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }

        public string KanGrubu
        {
            get { return _kanGrubu; }
            set { _kanGrubu = value; }
        }

        public string Uyrugu
        {
            get { return _uyrugu; }
            set { _uyrugu = value; }
        }

        public string Cinsiyeti
        {
            get { return _cinsiyeti; }
            set { _cinsiyeti = value; }
        }

        public string MedeniHali
        {
            get { return _medeniHali; }
            set { _medeniHali = value; }
        }

        //Iletisim Bilgileri

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }
        public string Gsm
        {
            get { return _gsm; }
            set { _gsm = value; }
        }
        public string EMail
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        //Nufusa Kayitli Bilgileri

        public string Il
        {
            get { return _il; }
            set { _il = value; }
        }
        public string Ilce
        {
            get { return _ilce; }
            set { _ilce = value; }
        }

        public string Mahalle
        {
            get { return _mahalle; }
            set { _mahalle = value; }
        }
        public string CiltNo
        {
            get { return _ciltNo; }
            set { _ciltNo = value; }
        }

        public string AileSiraNo
        {
            get { return _aileSiraNo; }
            set { _aileSiraNo = value; }
        }

        public string SiraNo
        {
            get { return _siraNo; }
            set { _siraNo = value; }
        }


        // Okulla ilgili bilgiler

    
        public string Bolum
        {
            get { return _bolum; }
            set { _bolum = value; }

        }

        public string Fakulte
        {
            get { return _fakulte; }
            set { _fakulte = value; }
        }
        
        public string OgrenimTipi
        {
            get { return _ogrenimTipi; }
            set { _ogrenimTipi = value; }
        }

        public string Sinifi
        {
            get { return _sinifi; }
            set { _sinifi = value; }
        }
        
        public string KayitTipi
        {
            get { return _kayitTipi; }
            set { _kayitTipi = value; }
        }
        public string GeldigiOkul
        {
            get { return _geldigiOkul; }
            set { _geldigiOkul = value; }
        }

        public string Numara
        {
            get { return _numara;}
            set { _numara = value; }
        }

        public DateTime KayitTarihi
        {
            get { return _kayitTarihi; }
            set { _kayitTarihi = value; }

        }

        // Ulasilabilecek bir yakin bilgisi

        
        public string YakinAd
        {
            get { return _yakinAd; }
            set { _yakinAd = value; }
        }

        public string YakinSoyAd
        {
            get { return _yakinSoyAd; }
            set { _yakinSoyAd = value; }
        }

        public string YakinlikDerecesi
        {
            get { return _yakinlikDerecesi; }
            set { _yakinlikDerecesi = value; }

        }
        public string YakinTelefon
        {
            get { return _yakinTelefon; }
            set { _yakinTelefon = value; }
        }
        public string YakinGsm
        {
            get { return _yakinGsm; }
            set { _yakinGsm = value; }
        }

        public string YakinAdres
        {
            get { return _yakinAdres; }
            set { _yakinAdres = value; }
        }

        public string Not
        {
            get { return _not; }
            set { _not = value; }
        }

        #endregion
        public override string ToString()
        {
            return this.Adi+this.SoyAdi+this.KayitTarihi;
        }
    }
}
