using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MBSX
{
    public partial class ShowroomForm : UserControl
    {
        private Form1 form1; // MainForm yerine Form1 kullanıyoruz
        private YeniKayıtSeçimFormu previousScreen; // Önceki ekranı sakla

        public ShowroomForm(Form1 form1, YeniKayıtSeçimFormu previousScreen)
        {
            InitializeComponent();
            this.form1 = form1;
            this.previousScreen = previousScreen;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string showroomAdi = txtShowroomAdi.Text.Trim();

            if (string.IsNullOrWhiteSpace(showroomAdi))
            {
                MessageBox.Show("Lütfen showroom adını girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Veritabanı\MBSX.mdb;";
            string query = "INSERT INTO showroom (Showroom_Adi, Kayit_Zamani) VALUES (@isim, @tarih)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@isim", showroomAdi);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 1️⃣ Önce panelContainer'ı temizle
                        if (form1 != null)
                        {
                            form1.panelContainer.Controls.Clear();

                            // 2️⃣ Ana ekrandaki butonları tekrar göster
                            form1.btnYeniKayit.Visible = true;
                            form1.btnKayitGuncelle.Visible = true;
                            form1.btnKayitAra.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnShowroomGeri_Click(object sender, EventArgs e)
        {
            if (form1 != null && previousScreen != null)
            {
                form1.panelContainer.Controls.Clear(); // Showroom ekranını kaldır
                form1.panelContainer.Controls.Add(previousScreen); // `YeniKayıtSeçimFormu` geri yükle
                previousScreen.BringToFront();
            }
        }
    }
}
