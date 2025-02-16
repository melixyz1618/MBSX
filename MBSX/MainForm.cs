using System;
using System.Windows.Forms;

namespace MBSX
{
    public partial class MainForm : Form
    {
        // panelContainer'ı public yaparak dışarıdan erişilebilir hale getirdim.
        public Panel panelContainer;

        public MainForm(Panel panelContainer)
        {
            this.panelContainer = panelContainer;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowroom_Click(object sender, EventArgs e)
        {
            LoadForm(new ShowroomForm());
        }

        private void LoadForm(UserControl form)
        {

            object value = panelContainer.Controls.Clear(); // Önce paneli temizle
            form.Dock = DockStyle.Fill; // Paneli tam kaplasın
            object value1 = panelContainer.Controls.Add(form); // Yeni formu panele ekle
            form.BringToFront(); // Öne getir
        }
    }
}
