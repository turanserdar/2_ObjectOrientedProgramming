﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k3_Inheritance
{
    class Insan  //Base Sinif
    {

        /*public int MyProperty { get; set; }*/ //prop 2 defa taba basarsaniz otomatik property olusturulur

        // Insana ait ozellikleri dusunelim
        // her insanin ismi var ama her insanin tc alamiyoruz

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public string TenRengi { get; set; }
    }
}
