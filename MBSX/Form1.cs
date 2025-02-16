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
            // Yeni bir Form olu�tur ve i�ine `YeniKay�tSe�imFormu` ekle
            Form yeniKayitForm = new Form
            {
                Text = "Yeni Kay�t Se�imi",
                Size = new System.Drawing.Size(800, 500),
                StartPosition = FormStartPosition.CenterScreen
            };

            YeniKay�tSe�imFormu yeniKayitSecim = new YeniKay�tSe�imFormu();
            yeniKayitSecim.Dock = DockStyle.Fill;

            yeniKayitForm.Controls.Add(yeniKayitSecim);
            yeniKayitForm.ShowDialog(); // Yeni formu a�
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
