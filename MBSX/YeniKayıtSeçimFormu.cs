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
                ShowroomForm showroomForm = new ShowroomForm(form1);

                Form formContainer = new Form
                {
                    Text = "Showroom Ekleme",
                    Size = new System.Drawing.Size(500, 400),
                    StartPosition = FormStartPosition.CenterScreen
                };
                showroomForm.Dock = DockStyle.Fill;
                formContainer.Controls.Add(showroomForm);
                formContainer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ana form bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUrun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün ekleme işlemi seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            // Geri tuşuna basınca önceki ekranı göster
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
