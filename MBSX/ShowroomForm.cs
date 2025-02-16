using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MBSX
{
    public partial class ShowroomForm : UserControl
    {
        public ShowroomForm()
        {
            InitializeComponent();
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
                        ((MainForm)this.ParentForm).panelContainer.Controls.Clear(); // Paneli temizle
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veri tabanı hatası -- Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
