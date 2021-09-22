using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k2_Constructor
{
    class Student
    {
        #region Constructors

        public Student()
        {

        }//Constructor yazilmazsa bunu arka tarafta bunu otomatik bos bir sekilde tanimlar.
        //Default degerlerle acilsin istersem icine bir sey yazabilirim.

        public Student(string name, string surname, string tckn)
        {
            this.Name = name;
            this.Surname = surname;
            //this.TCKN = tckn;
        }


        #endregion





        //Ogrencinin adi soyadi

        #region Properties

        //private string _name;


        //public string Name { get { return _name; } set { _name = value; } }  //_name aslinda arka tarafta bir field olusturuluyor

        //Kisa hali
        public string Name { get; set; }
        public string Surname { get; set; }
        public string tckn { get; set; }
        // Bu sekilde default constructor tanimlamalari yaptik




        #endregion

    }
}
