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
        public string _soyad;
        public string _ogrenciNUmarasi;
        public string _adres;
        public string _kanGrubu;
        public string _bolum;

        // Sinifin bir sablondur . Direk kendisini kullanmayiz hic bir zaman. Bu sinifin bir kopyasini olustrurum. 


    }
}
