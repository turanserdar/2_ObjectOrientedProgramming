using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k5_Polymorphism
{
    class Urun
    {



        public double BirimFiyat { get; set; }

        public int StokMiktari { get; set; }

        public virtual double KdvliFiyatGetir()
        {
            //Tum urunlerde %18 lik bir KDV artisi ile urunun fiyatini donen bir metot yazdik.

            return BirimFiyat * 1.18;
        }

        

    }
}
