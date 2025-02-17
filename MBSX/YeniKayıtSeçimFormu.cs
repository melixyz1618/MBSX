using System;
using System.Windows.Forms;

namespace MBSX
{
    public partial class YeniKayıtSeçimFormu : UserControl
    {
        private Form1 form1;

        public YeniKayıtSeçimFormu(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
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
            // Yeni içeriği kaldır
            this.Parent.Controls.Clear();

            // Form1 içindeki butonları tekrar göster
            Form1 anaForm = (Form1)Application.OpenForms["Form1"];
            if (anaForm != null)
            {
                anaForm.btnYeniKayit.Visible = true;
                anaForm.btnKayitGuncelle.Visible = true;
                anaForm.btnKayitAra.Visible = true;
            }
        }


        private void YeniKayıtSeçimFormu_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde çalışacak kodlar buraya yazılabilir
        }

    }
}
