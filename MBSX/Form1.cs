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
            YeniKayýtSeçimFormu yeniKayýtSeçim = new YeniKayýtSeçimFormu();
            yeniKayýtSeçim.ShowDialog(); // Seçim formunu göster
        }


        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayýt güncelleme ekraný açýlacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayýt arama ekraný açýlacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
