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
            // Eðer panelContainer varsa, içeriðini temizleyip yeni UserControl ekle
            if (this.panelContainer != null)
            {
                this.panelContainer.Controls.Clear();

                YeniKayýtSeçimFormu yeniKayitSecim = new YeniKayýtSeçimFormu();
                yeniKayitSecim.Dock = DockStyle.Fill; // Paneli tam kaplasýn

                this.panelContainer.Controls.Add(yeniKayitSecim);
                yeniKayitSecim.BringToFront(); // Kullanýcýya göster
            }
            else
            {
                MessageBox.Show("panelContainer bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
