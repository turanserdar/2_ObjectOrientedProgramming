using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciKayitEkrani
{
    public partial class OgrencıBılgıSıstemı : Form
    {
        public OgrencıBılgıSıstemı()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrencıKayıtEkranı kayitEkraniGecis = new OgrencıKayıtEkranı();
            kayitEkraniGecis.ShowDialog(); // Bilgi sisteminden kayit ekranina gecis icin

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciSorgulamaEkrani sorgulamaGecis = new OgrenciSorgulamaEkrani();
            sorgulamaGecis.ShowDialog(); // Kodlar henuz tamamlanmadi.
        }
    }
}
