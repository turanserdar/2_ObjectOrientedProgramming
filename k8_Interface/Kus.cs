using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k8_Interface
{
    class Kus // Base olarak bu siniftan turetelim
    {

        public string TuyRengi { get; set; }
        public double GagaBoyu { get; set; }

        public double KanatUzunlugu { get; set; }

        //class Tavuk:Kus // Boyle de yapabilirsin
        //{

        //}

        public UzunlukBirimi GagaBoyuBirimi { get; set; }

      

        public UzunlukBirimi KanatUzunlukBirimi { get; set; }

        public bool AyagiPerdeliMi { get; set; }
    }
}
