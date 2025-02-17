using System;
using System.Windows.Forms;

namespace MBSX
{
    public partial class DigerMalzemeFormu : UserControl
    {
        private Form1 form1;
        private UrunCesitSecimFormu previousScreen;

        public DigerMalzemeFormu(Form1 form1, UrunCesitSecimFormu previousScreen)
        {
            InitializeComponent();
            this.form1 = form1;
            this.previousScreen = previousScreen;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (form1 != null && previousScreen != null)
            {
                form1.panelContainer.Controls.Clear();
                form1.panelContainer.Controls.Add(previousScreen);
                previousScreen.BringToFront();
            }
            else
            {
                MessageBox.Show("Önceki ekran bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
