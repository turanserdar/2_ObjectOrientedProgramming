using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    class Marti:Kus,IYuzebilir
    {
        public double YuzmeDerinligi { get; set; }

        #region Bu kisim interface den geldi
        public int MyProperty { get; set; }
        public double MaxInebilecegiDerinlik { get ; set ; }
        public UzunlukBirimi Birimi { get; set; }

        public void Yuz()
        {

        }



        #endregion

    }
}
