using System;
using System.Windows.Forms;

namespace MBSX
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowroom_Click(object sender, EventArgs e)
        {
            var showroomForm = new ShowroomForm(this);
            showroomForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(showroomForm);
        }



        private void LoadForm(UserControl form)
        {
            if (panelContainer != null) // panelContainer'ın null olmadığını doğrula
            {
                panelContainer.Controls.Clear(); // Önce paneli temizle
                form.Dock = DockStyle.Fill; // Paneli tam kaplasın
                panelContainer.Controls.Add(form); // Yeni formu panele ekle
                form.BringToFront(); // Öne getir
            }
            else
            {
                MessageBox.Show("Panel bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
