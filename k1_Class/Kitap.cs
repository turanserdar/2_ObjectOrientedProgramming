using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k1_Class
{
    class Kitap
    {




        #region Field


        private string _kitapAdi;
        private string _yazarAdi;
        private double _fiyat;
        private string _tur;
        private string _yayinevi;
        private DateTime _basimTarihi;
        private string _sayfaSayisi; //matematiksel bir islem yapacagimi dusunmedigim icin string aldim


        #endregion
        #region Property

        public string KitapAdi
        {

            get { return _kitapAdi; }
            set { _kitapAdi = value; }
        }

        public string YazarAdiSoyadi
        {

            get { return _yazarAdi; }
            set { _yazarAdi = value; }
        }

        public double Fiyat
        {

            get { return _fiyat; }
            set { _fiyat = value; }
        }

        public string Turu
        {

            get { return _tur; }
            set { _tur = value; }
        }

        public string Yayinevi
        {
            get { return _yayinevi; }
            set { _yayinevi = value; }
        }

        public DateTime BasimTarihi
        {
            get { return _basimTarihi; }
            set { _basimTarihi = value; }
        }
        public string SayfaSayisi
        {
            get { return _sayfaSayisi; }
            set { _sayfaSayisi = value; }
        }


        #endregion

    }
}
