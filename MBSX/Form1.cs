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
            // Yeni bir Form oluþtur ve içine `YeniKayýtSeçimFormu` ekle
            Form yeniKayitForm = new Form
            {
                Text = "Yeni Kayýt Seçimi",
                Size = new System.Drawing.Size(800, 500),
                StartPosition = FormStartPosition.CenterScreen
            };

            YeniKayýtSeçimFormu yeniKayitSecim = new YeniKayýtSeçimFormu();
            yeniKayitSecim.Dock = DockStyle.Fill;

            yeniKayitForm.Controls.Add(yeniKayitSecim);
            yeniKayitForm.ShowDialog(); // Yeni formu aç
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
