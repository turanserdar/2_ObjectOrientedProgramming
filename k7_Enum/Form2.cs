using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k7_Enum
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //string[] ekmekTurleri = Enum.GetNames(typeof(EkmekTuru));
            //cmbEkmekTuru.Items.AddRange(ekmekTurleri);
        }
    }
}
