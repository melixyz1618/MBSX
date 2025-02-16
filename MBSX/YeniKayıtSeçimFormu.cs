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

        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }

        private void btnShowroom_Click(object sender, EventArgs e)
        {
            ShowroomForm showroomForm = new ShowroomForm(); // Form nesnesi oluştur
            showroomForm.ShowDialog(); // Modsal olarak aç
        }


        private void btnUrun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün ekleme işlemi seçildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Formu kapat
        }

        private void YeniKayıtSeçimFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
