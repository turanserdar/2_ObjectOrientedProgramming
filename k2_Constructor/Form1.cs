using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2_Constructor
{
    public partial class Form1 : Form
    {

        /*
           Constructor: Yapici metot(Sinifa ozel bir metotdur.)
        Oncelikle her zaman constructor calisir. Daha sonra digerleri calisir.
        Bir siniftan instance alirken bos bir sekilde instance aliyoruz.
        Random rnd = new Random();//bu constructor calistirir.


        Sinifin instance i olusturuldugunda constructor metot bu sekilde cagrilir.
        Constructor o sinifin ram uzerinde olusturulmasinda gorevli.
        Sinifi olusturmak icin gerekli.

        Sinif ilk acildiginda gerekli olan degerlerle birlikte gelmesini saglayan constructor dir.

        Constructor sinif olusturmakla gorevlidir. Birden Fazla overload'u yazilabilir.
        Eger constructor ozellikle tanimlanmazsa arkada calisan bir constructor bulunur.

        Sinif ile ayni isimde olmak zorundadir.Iceriye bir parametre alabilir. Return olarak kullanilmaz. Geriye bir deger dondurmez.
        Normalde metotlari tanimlarken geriye deger dondurm
        1.Sinifla ayni isimde
        2.Geriye bir deger dondurmuyor. 
        Yukaridaki iki madde diger metotlardan farkidir.


        Her sinifin mutlaka bir yapici metodu olur.

        Load formu doldurur. Formu doldurmak istedigimizde load i kullanalim.


        */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student ogrenci = new Student();
            ogrenci.Name = "ali mert";
            ogrenci.Surname = "celik";
            //ogrenci.TCKN = "1234132432421";

            //2.tanimlama yontemi
            Student ogrenci2 = new Student("bahar", "tasbas", "123456");
        }
    }
}
