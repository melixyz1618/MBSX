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
            // Form açýldýðýnda yapýlacak iþlemler buraya yazýlabilir
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            if (this.panelContainer != null)
            {
                this.panelContainer.Controls.Clear();

                YeniKayýtSeçimFormu yeniKayitSecim = new YeniKayýtSeçimFormu(this);
                yeniKayitSecim.Dock = DockStyle.Fill;

                this.panelContainer.Controls.Add(yeniKayitSecim);
                yeniKayitSecim.BringToFront();
            }
            else
            {
                MessageBox.Show("panelContainer bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show("Kayýt güncelleme ekraný açýlacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKayitAra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayýt arama ekraný açýlacak.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }


}
