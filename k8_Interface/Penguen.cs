using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    class Penguen:Kus,IYuzebilir
    {

        public double YuruyusHizi { get; set; }

        #region Bu kisim interface'den geldi

        public  double MaxInebilecegiDerinlik { get; set; }
        #endregion

        public void Yuz()
        {
            //Yuzme stili tanimlanir.
        }

    }
}
