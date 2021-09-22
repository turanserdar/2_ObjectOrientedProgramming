using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k5_Polymorphism
{
    class Ekmek : Urun
    {

        public double Gramaj { get; set; }
        public string Turu { get; set; }
        public override double KdvliFiyatGetir()
        {
            return BirimFiyat*1.01;
        }


    }
}
