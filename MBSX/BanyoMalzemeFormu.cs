using System;
using System.Windows.Forms;

namespace MBSX
{
    public partial class BanyoMalzemeFormu : UserControl
    {
        private Form1 form1;
        private UrunCesitSecimFormu previousScreen;

        public BanyoMalzemeFormu(Form1 form1, UrunCesitSecimFormu previousScreen)
        {
            InitializeComponent();
            this.form1 = form1;
            this.previousScreen = previousScreen;

            if (previousScreen == null)
            {
                MessageBox.Show("previousScreen değeri NULL! Lütfen kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
