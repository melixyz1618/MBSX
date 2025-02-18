using System;
using System.Windows.Forms;

namespace MBSX
{
    public partial class UrunCesitSecimFormu : UserControl
    {
        private Form1 form1;
        private YeniKayıtSeçimFormu previousScreen; // Önceki ekranı saklamak için

        public UrunCesitSecimFormu(Form1 form1, YeniKayıtSeçimFormu previousScreen)
        {
            InitializeComponent();
            this.form1 = form1;
            this.previousScreen = previousScreen;
        }

        public UrunCesitSecimFormu(Form1 form1)
        {
            this.form1 = form1;
        }

        private void btnKaro_Click(object sender, EventArgs e)
        {
            if (form1 != null)
            {
                form1.panelContainer.Controls.Clear();
                KaroMalzemeFormu karoFormu = new KaroMalzemeFormu(form1, this); // 📌 Burada `this` gönderiyoruz
                karoFormu.Dock = DockStyle.Fill;
                form1.panelContainer.Controls.Add(karoFormu);
                karoFormu.BringToFront();
            }
            else
            {
                MessageBox.Show("Ana form bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnBanyo_Click(object sender, EventArgs e)
        {
            if (form1 != null)
            {
                form1.panelContainer.Controls.Clear();
                BanyoMalzemeFormu banyoFormu = new BanyoMalzemeFormu(form1, this);
                banyoFormu.Dock = DockStyle.Fill;
                form1.panelContainer.Controls.Add(banyoFormu);
                banyoFormu.BringToFront();
            }
            else
            {
                MessageBox.Show("Ana form bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDiger_Click(object sender, EventArgs e)
        {
            if (form1 != null)
            {
                form1.panelContainer.Controls.Clear();
                DigerMalzemeFormu digerFormu = new DigerMalzemeFormu(form1, this);
                digerFormu.Dock = DockStyle.Fill;
                form1.panelContainer.Controls.Add(digerFormu);
                digerFormu.BringToFront();
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
                form1.panelContainer.Controls.Clear();
                form1.panelContainer.Controls.Add(previousScreen);
                previousScreen.BringToFront();
            }
        }
    }
}
