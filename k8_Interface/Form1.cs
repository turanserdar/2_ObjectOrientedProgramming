using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k8_Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* 
             Bir sinif sadece bir base siniftan miras alabilir.
             C# da bu boyle baska programlama dillerinde farkli olabilir.

            Bu sinifa ek ozellik/yetenek kazandirilmak isteniyorsa bu durumda interface yapisi ile sorunu cozebiliyoruz.
            Interface'ler implemente edilerek kullanilir.
           
            Tanimlanirken :
            
            *Basina buyuk I harfi ondan sonra interface in adi seklinde isimlendirilir.
            I bununla baslayan hersey interface dir. Bu bir kural degil standarttir.
            IInterface adi

            *Isimlendirirken -able- yetenek ekleri getirilir.
            *Interface icindeki elemanlara erisim belirleyici tanimlanmaz.Cunku kendi icersinde default olarak hepsini public olarak goruyor.
            *Interface icinde tanimlanan metot veya property lerin govdeleri tanimlanmaz. Abstractmis gibi tanimlaniyor. Interface ozel bir sey oldugu icin bu sekilde tanimlaniyor.
            *
             
             */


            Penguen p1 = new Penguen();
            p1.MaxInebilecegiDerinlik = 10;
            
            p1.GagaBoyu = 1.2;
            p1.GagaBoyuBirimi = UzunlukBirimi.santimetre;
            MessageBox.Show($"Penguenin gaga boyu{ p1.GagaBoyu}{ p1.GagaBoyuBirimi}");
            p1.Yuz();

            Marti m1 = new Marti();
            m1.MaxInebilecegiDerinlik = 2;
            m1.Birimi = UzunlukBirimi.metre;
            m1.KanatUzunlugu = 1;
            m1.KanatUzunlukBirimi = UzunlukBirimi.metre;
            m1.Yuz();

            //jet brains reSharper



        }
    }
}
