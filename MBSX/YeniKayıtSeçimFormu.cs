using System;
using System.Windows.Forms;

namespace MBSX
{
    public partial class YeniKayıtSeçimFormu : UserControl
    {
        private Form1 form1;
        private Form1 previousScreen; // Önceki ekranı sakla

        public YeniKayıtSeçimFormu(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.previousScreen = previousScreen;
        }

        private void btnShowroom_Click(object sender, EventArgs e)
        {
            if (form1 != null)
            {
                form1.panelContainer.Controls.Clear();
                ShowroomForm showroomForm = new ShowroomForm(form1, this); // Şu anki ekranı gönder
                showroomForm.Dock = DockStyle.Fill;
                form1.panelContainer.Controls.Add(showroomForm);
                showroomForm.BringToFront();
            }
            else
            {
                MessageBox.Show("Ana form bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnUrun_Click(object sender, EventArgs e)
        {
            if (form1 != null)
            {
                form1.panelContainer.Controls.Clear();
                UrunCesitSecimFormu urunCesitSecimFormu = new UrunCesitSecimFormu(form1, this);
                urunCesitSecimFormu.Dock = DockStyle.Fill;
                form1.panelContainer.Controls.Add(urunCesitSecimFormu);
                urunCesitSecimFormu.BringToFront();
            }
            else
            {
                MessageBox.Show("Ana form bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (form1 != null && previousScreen != null)
            {
                form1.panelContainer.Controls.Clear(); // Showroom ekranını kaldır
                form1.panelContainer.Controls.Add(previousScreen); // `YeniKayıtSeçimFormu` geri yükle
                previousScreen.BringToFront();
            }
        }   


        private void YeniKayıtSeçimFormu_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde çalışacak kodlar buraya yazılabilir
        }

    }
}
