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
            btnYeniKayit.Visible = false;
            btnKayitGuncelle.Visible = false;
            btnKayitAra.Visible = false;

            YeniKay�tSe�imFormu yeniKayitSecim = new YeniKay�tSe�imFormu(this);
            LoadUserControl(yeniKayitSecim);
        }



        private void btnShowroom_Click(object sender, EventArgs e)
        {
            if (this.panelContainer != null)
            {
                this.panelContainer.Controls.Clear();

                // �nce YeniKay�tSe�imFormu'nu olu�tur
                YeniKay�tSe�imFormu yeniKayitSecim = new YeniKay�tSe�imFormu(this);

                // �imdi ShowroomForm'u, YeniKay�tSe�imFormu referans�yla birlikte ba�lat
                ShowroomForm showroomForm = new ShowroomForm(this, yeniKayitSecim);
                showroomForm.Dock = DockStyle.Fill;

                this.panelContainer.Controls.Add(showroomForm);
                showroomForm.BringToFront();
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
