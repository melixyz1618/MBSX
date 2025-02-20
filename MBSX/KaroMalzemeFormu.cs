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
        private List<string> selectedImages = new List<string>(); // Seçilen resimlerin dosya yollarını tutar

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
                    string queryShowroom = "SELECT ShowroomAdi FROM Showroom";
                    using (OleDbCommand cmd = new OleDbCommand(queryShowroom, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbxshowroom.Items.Add(reader["ShowroomAdi"].ToString());
                            }
                        }
                    }
                    // 🟢 Showroom tablosundan veri çekme
                    string queryDepo = "SELECT rafNo FROM Depo";
                    using (OleDbCommand cmd = new OleDbCommand(queryDepo, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbxDepo.Items.Add(reader["rafNo"].ToString());
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<string> eksikAlanlar = new List<string>();

            if (string.IsNullOrWhiteSpace(textBox2.Text)) eksikAlanlar.Add("Ürün Kodu");
            if (string.IsNullOrWhiteSpace(textBox3.Text)) eksikAlanlar.Add("Ürün İsmi");
            if (string.IsNullOrWhiteSpace(textBox4.Text)) eksikAlanlar.Add("Brüt Fiyat");
            if (string.IsNullOrWhiteSpace(textBox15.Text)) eksikAlanlar.Add("Boyut");

            if (cmbxiskonto.SelectedIndex == -1) eksikAlanlar.Add("İskonto");
            if (cmbxkdv.SelectedIndex == -1) eksikAlanlar.Add("KDV");
            if (cmbxdonem.SelectedIndex == -1) eksikAlanlar.Add("Dönem");
            if (cmbxshowroom.SelectedIndex == -1) eksikAlanlar.Add("Showroom");

            if (eksikAlanlar.Count > 0)
            {
                MessageBox.Show("Lütfen aşağıdaki alanları doldurun:\n\n" + string.Join("\n", eksikAlanlar),
                    "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // **Formdan gelen verileri alalım**
            string seriModel = textBox1.Text.Trim();
            string urunKodu = textBox2.Text.Trim();
            string urunIsmi = textBox3.Text.Trim();
            decimal brutFiyat = Convert.ToDecimal(textBox4.Text.Trim());
            string boyut = textBox15.Text.Trim();
            int iskonto = Convert.ToInt32(cmbxiskonto.SelectedItem);
            int kdv = Convert.ToInt32(cmbxkdv.SelectedItem);
            int donem = Convert.ToInt32(cmbxdonem.SelectedItem);
            string selectedShowroom = cmbxshowroom.SelectedItem.ToString();
            int showroomId = 0;
            string rafNo = cmbxDepo.SelectedItem.ToString();

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Veritabanı\MBSX.mdb;";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // **Showroom ID'yi bulma**
                    string showroomQuery = "SELECT id FROM Showroom WHERE ShowroomAdi = ?";
                    using (OleDbCommand cmdShowroom = new OleDbCommand(showroomQuery, conn))
                    {
                        cmdShowroom.Parameters.AddWithValue("?", selectedShowroom);
                        object result = cmdShowroom.ExecuteScalar();
                        if (result != null)
                        {
                            showroomId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Seçilen showroom veritabanında bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // **Resim Yolunu Belirleme**
                    string resimYolu = selectedImages.Count > 0 ? selectedImages[0] : "";

                    // **Ürünü Veritabanına Kaydetme**
                    string queryUrun = @"INSERT INTO Urun 
            (SeriModel, UrunKodu, UrunIsmi, BrutFiyat, Boyut, Iskonto, KDV, Donem, ShowroomId, ResimYolu,rafNo) 
            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?)";

                    using (OleDbCommand cmdUrun = new OleDbCommand(queryUrun, conn))
                    {
                        cmdUrun.Parameters.AddWithValue("?", seriModel);
                        cmdUrun.Parameters.AddWithValue("?", urunKodu);
                        cmdUrun.Parameters.AddWithValue("?", urunIsmi);
                        cmdUrun.Parameters.AddWithValue("?", brutFiyat);
                        cmdUrun.Parameters.AddWithValue("?", boyut);
                        cmdUrun.Parameters.AddWithValue("?", iskonto);
                        cmdUrun.Parameters.AddWithValue("?", kdv);
                        cmdUrun.Parameters.AddWithValue("?", donem);
                        cmdUrun.Parameters.AddWithValue("?", showroomId);
                        cmdUrun.Parameters.AddWithValue("?", resimYolu);
                        cmdUrun.Parameters.AddWithValue("?", rafNo);

                        cmdUrun.ExecuteNonQuery();
                    }

                    MessageBox.Show("Ürün başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 📌 **Ekranı Temizle**
                    FormuTemizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void FormuTemizle()
        {
            // Tüm textboxları temizle
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Clear();
                }
                else if (ctrl is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1; // Combobox'ları sıfırla
                }
                else if (ctrl is PictureBox pic)
                {
                    pic.Image = null; // PictureBox'ı temizle
                }
            }
        }
        private void ResmiYukle(int urunId)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Veritabanı\MBSX.mdb;";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // **Seçili ürüne ait ilk resmi getir**
                    string query = "SELECT ResimYolu FROM Resimler WHERE UrunId = ? LIMIT 1";
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", urunId);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string imagePath = result.ToString();
                            if (File.Exists(imagePath)) // Dosya varsa göster
                            {
                                pictureBox1.Image = Image.FromFile(imagePath);
                            }
                            else
                            {
                                MessageBox.Show("Resim dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bu ürüne ait resim bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp",
                Multiselect = true // 🔹 Birden fazla dosya seçmeye izin ver
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImages.Clear(); // Önceki seçilenleri temizle

                foreach (string filePath in openFileDialog.FileNames)
                {
                    string imageFolder = @"C:\MBSX_Resimler"; // Resimler buraya kaydedilecek
                    if (!Directory.Exists(imageFolder))
                    {
                        Directory.CreateDirectory(imageFolder);
                    }

                    string fileName = Path.GetFileName(filePath);
                    string newImagePath = Path.Combine(imageFolder, fileName);

                    // 🔹 Aynı isimde dosya varsa üzerine yazmasın
                    if (!File.Exists(newImagePath))
                    {
                        File.Copy(filePath, newImagePath);
                    }

                    // 📌 İlk resmi PictureBox'a göster
                    if (pictureBox1.Image == null)
                    {
                        pictureBox1.Image = Image.FromFile(newImagePath);
                    }

                    // 📌 Seçilen resimleri listeye kaydet
                    selectedImages.Add(newImagePath);
                }
            }
        }

        private void KaroMalzemeFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
