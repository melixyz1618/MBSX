using System;
using System.Drawing;
using System.Windows.Forms;

namespace MBSX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            YeniKay�tSe�imFormu yeniKay�tSe�im = new YeniKay�tSe�imFormu();
            yeniKay�tSe�im.ShowDialog(); // Se�im formunu g�ster
        }


        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kay�t g�ncelleme ekran� a��lacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kay�t arama ekran� a��lacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
