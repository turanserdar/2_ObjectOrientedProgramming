using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_Class
{
    class Ogrenci
    {
        // Sinifin icersiinde veri tutmak icin olusturulan degiskenlere field ismi verilir
        // Fieldlar isimlendirilirken degisken isimlendirme kurallari gecerlidir. Tek fark degisken ismi onunde _(alt tire) bulunur
        // _ ile bir degisken tanimlandigini gorurseniz bir field tanimlandigini anlarsiniz.
        // Field da bir degisken ama ozel bir degisken.
        // camelCase
        // _ olmasi program acisindan bir fark yaratmaz. Sonuc olarak degisken olarak gorur. Bu sadece yazilimcinin bunu tanimasi icin.

        // Ogrenci icin hangi bilgiler bize lazim. Musteriden aldigim bilgilere gore sekillenir.





        public string _ad;
        public string Ad
        {
            get
            {
                //Disaridan field in degeri istendigi zaman buradan gonderim islemi yapilir.
                return _ad;
            }
            set
            {
                _ad = value; // Disaridan alinan verinin kontrol edilerek field a atanmasi islemi burada yapilir,value ile
            }
        }
        public string _soyad;


        public string SoyAd
        {
            get
            {
                return _soyad;
            }
            set
            {
                _soyad = value;
            }
        }

        public string _ogrenciNUmarasi;

        public string OgrenciNumarasi
        {
            get { return _ogrenciNUmarasi; } // Gonderdigi degeri isterse
            set { _ogrenciNUmarasi = value; } //yazilimcinin gonderdigi degeri atiyorum
        }

        public string _adres;
        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        public string _kanGrubu;
        public string KanGrubu
        {
            get { return _kanGrubu; }
            set { _kanGrubu = value; }
        }
        public string _bolum;
        public string Bolum
        {
            get { return _bolum; }
            set { _bolum = value; }
        }
        private int _yas;
        //public int Yas
        //{
        //    get
        //    {
        //        return _yas;
        //    }
        //    set
        //    {
        //        if (value < 15 || value > 18)
        //        {
        //            throw new Exception("Yas degerine 15-18 araliginda bir deger atamaniz gerekmektedir.");
        //        }
        //        _yas = value;
        //    }
        //}
        public int Yas
        {
            get
            {
                var simdikiZaman = DateTime.Now;
                var fark = simdikiZaman - DogumTarihi;
                _yas = fark.Days / 365;
                return _yas;
            }
        }
        private DateTime _dogumTarihi;
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }
        private string _cinsiyet;

        public string cinsiyet {
            get { return _cinsiyet; }
            set { _cinsiyet = value; }

            // Sinifin bir sablondur . Direk kendisini kullanmayiz hic bir zaman. Bu sinifin bir kopyasini olustrurum. 

            //OOP'nin encapsulation kurali dogrultusunda fieldlar sinif icerisinde private olarak tanimlanmalidir.
            //Property ile fieldlara degerleri kontrollu bir sekilde aktarabiliriz veya field in tasidigi degeri kullaniciya gonderebiliriz
            //Erisim belirleyicisi public olma






        }
    } }
