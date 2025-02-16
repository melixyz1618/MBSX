using System;
using System.Windows.Forms;

namespace MBSX
{
    public partial class YeniKayıtSeçimFormu : UserControl
    {
        public YeniKayıtSeçimFormu()
        {
            InitializeComponent();
        }

        private void btnShowroom_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is MainForm mainForm)
            {
                ShowroomForm showroomForm = new ShowroomForm(mainForm);

                // ShowroomForm'u yeni bir form içine alıp göster
                Form formContainer = new Form
                {
                    Text = "Showroom Ekleme",
                    Size = new System.Drawing.Size(500, 400),
                    StartPosition = FormStartPosition.CenterScreen
                };
                showroomForm.Dock = DockStyle.Fill;
                formContainer.Controls.Add(showroomForm);
                formContainer.ShowDialog(); // Yeni formu aç
            }
            else
            {
                MessageBox.Show("Ana form bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün ekleme işlemi seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Form kapatma işlemi
            if (this.ParentForm != null)
            {
                this.ParentForm.Close();
            }
            else
            {
                this.Dispose();
            }
        }

        private void YeniKayıtSeçimFormu_Load(object sender, EventArgs e)
        {
            // Gerekli başlangıç işlemleri burada yapılabilir.
        }
    }
}
