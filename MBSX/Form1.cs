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
            btnYeniKayit.Visible = false;
            btnKayitGuncelle.Visible = false;
            btnKayitAra.Visible = false;

            YeniKayýtSeçimFormu yeniKayitSecim = new YeniKayýtSeçimFormu(this);
            LoadUserControl(yeniKayitSecim);
        }



        private void btnShowroom_Click(object sender, EventArgs e)
        {
            if (this.panelContainer != null)
            {
                this.panelContainer.Controls.Clear();

                // Önce YeniKayýtSeçimFormu'nu oluþtur
                YeniKayýtSeçimFormu yeniKayitSecim = new YeniKayýtSeçimFormu(this);

                // Þimdi ShowroomForm'u, YeniKayýtSeçimFormu referansýyla birlikte baþlat
                ShowroomForm showroomForm = new ShowroomForm(this, yeniKayitSecim);
                showroomForm.Dock = DockStyle.Fill;

                this.panelContainer.Controls.Add(showroomForm);
                showroomForm.BringToFront();
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
        public void LoadUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        internal void LoadUserControl(object previousScreen)
        {
            throw new NotImplementedException();
        }
    }


}
