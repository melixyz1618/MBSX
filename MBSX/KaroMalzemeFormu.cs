using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MBSX
{
    public partial class KaroMalzemeFormu : UserControl
    {
        private Form1 form1;
        private UrunCesitSecimFormu previousScreen;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Veritabanı\MBSX.mdb;";

        public KaroMalzemeFormu(Form1 form1, UrunCesitSecimFormu previousScreen)
        {
            InitializeComponent();
            this.form1 = form1;
            this.previousScreen = previousScreen;

            if (previousScreen == null)
            {
                MessageBox.Show("previousScreen değeri NULL! Lütfen kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 📌 Comboboxları doldur
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // 🟢 Showroom tablosundan veri çekme
                    string queryShowroom = "SELECT Showroom_Adi FROM Showroom";
                    using (OleDbCommand cmd = new OleDbCommand(queryShowroom, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbxshowroom.Items.Add(reader["Showroom_Adi"].ToString());
                            }
                        }
                    }

                    // 🟢 Iskonto tablosundan veri çekme
                    string queryIskonto = "SELECT Iskonto FROM Iskonto";
                    using (OleDbCommand cmd = new OleDbCommand(queryIskonto, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbxiskonto.Items.Add(reader["Iskonto"].ToString());
                            }
                        }
                    }

                    // 🟢 KDV tablosundan veri çekme
                    string queryKDV = "SELECT KDV FROM KDV";
                    using (OleDbCommand cmd = new OleDbCommand(queryKDV, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbxkdv.Items.Add(reader["KDV"].ToString());
                            }
                        }
                    }

                    // 🟢 Donem tablosundan veri çekme
                    string queryDonem = "SELECT Donem FROM Donem";
                    using (OleDbCommand cmd = new OleDbCommand(queryDonem, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbxdonem.Items.Add(reader["Donem"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
