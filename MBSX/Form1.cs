using System;
using System.Drawing;
using System.Runtime.Versioning;
using System.Windows.Forms;
using System.Runtime.Versioning;

namespace MBSX
{
    [SupportedOSPlatform("windows")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            // E�er panelContainer varsa, i�eri�ini temizleyip yeni UserControl ekle
            if (this.panelContainer != null)
            {
                this.panelContainer.Controls.Clear();

                YeniKay�tSe�imFormu yeniKayitSecim = new YeniKay�tSe�imFormu();
                yeniKayitSecim.Dock = DockStyle.Fill; // Paneli tam kaplas�n

                this.panelContainer.Controls.Add(yeniKayitSecim);
                yeniKayitSecim.BringToFront(); // Kullan�c�ya g�ster
            }
            else
            {
                MessageBox.Show("panelContainer bulunamad�!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
