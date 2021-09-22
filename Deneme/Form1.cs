using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student ogrenci = new Student();

            ogrenci.Name = "Serdar";
            ogrenci.Surname = "Turan";
            ogrenci.TCKN = "123123213";
        }
    }
}
