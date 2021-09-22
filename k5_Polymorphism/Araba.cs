using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k5_Polymorphism
{
    class Araba:Urun
    {

        public string Model { get; set; }
        public int MotorHacmi { get; set; }

        public override double KdvliFiyatGetir()
        {
            //return BirimFiyat * 1.45; // base siniftaki %18  burada %45

            var kdvOrani = 0; // Default ta 0 ile tanimladik

            if (MotorHacmi>=1000&&MotorHacmi<2000)
            {
                return BirimFiyat * 1.45;
            }
            else if (MotorHacmi>2000&&MotorHacmi>2500)
            {
                return BirimFiyat * 2.5;
            }
            else if (MotorHacmi>2500)
            {
                return BirimFiyat * 4;
            }

            return 0;
        }
      

    }
}
