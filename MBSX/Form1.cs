using System;
using System.Windows.Forms;

namespace MBSX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form a��ld���nda yap�lacak i�lemler buraya yaz�labilir
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (this.panelContainer != null)
            {
                this.panelContainer.Controls.Clear();

                YeniKay�tSe�imFormu yeniKayitSecim = new YeniKay�tSe�imFormu(this);
                yeniKayitSecim.Dock = DockStyle.Fill;

                this.panelContainer.Controls.Add(yeniKayitSecim);
                yeniKayitSecim.BringToFront();
            }
            else
            {
                MessageBox.Show("panelContainer bulunamad�!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowroom_Click(object sender, EventArgs e)
        {
            var showroomForm = new ShowroomForm(this);
            showroomForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(showroomForm);
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kay�t g�ncelleme ekran� a��lacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kay�t arama ekran� a��lacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}
