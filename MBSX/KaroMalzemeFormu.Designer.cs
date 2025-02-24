
using System.Data.OleDb;

namespace MBSX
{
    partial class KaroMalzemeFormu
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            btnGeri = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            textBox15 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            btnKaydet = new Button();
            label19 = new Label();
            cmbxshowroom = new ComboBox();
            cmbxiskonto = new ComboBox();
            cmbxkdv = new ComboBox();
            cmbxdonem = new ComboBox();
            pictureBox1 = new PictureBox();
            btnResimSec = new Button();
            label20 = new Label();
            textBox16 = new TextBox();
            label21 = new Label();
            cmbxDepo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(753, 57);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(94, 29);
            btnGeri.TabIndex = 0;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 67);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Seri / Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 114);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Ürün Kodu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 162);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 3;
            label3.Text = "Ürün İsmi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 211);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 4;
            label4.Text = "Brüt Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 259);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 5;
            label5.Text = "Ürün Grubu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 307);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 6;
            label6.Text = "Birim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 358);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 7;
            label7.Text = "Kalınlık";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 403);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 8;
            label8.Text = "Kutu İçi Adet";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(289, 66);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 9;
            label9.Text = "Kutu içi m2";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(311, 114);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 10;
            label10.Text = "Kutu Kg";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(275, 162);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 11;
            label11.Text = "Palet İçi Kutu";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(284, 210);
            label12.Name = "label12";
            label12.Size = new Size(85, 20);
            label12.TabIndex = 12;
            label12.Text = "Palet İçi m2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(309, 258);
            label13.Name = "label13";
            label13.Size = new Size(63, 20);
            label13.TabIndex = 13;
            label13.Text = "Palet Kg";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(325, 306);
            label14.Name = "label14";
            label14.Size = new Size(47, 20);
            label14.TabIndex = 14;
            label14.Text = "Yüzey";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(325, 354);
            label15.Name = "label15";
            label15.Size = new Size(47, 20);
            label15.TabIndex = 15;
            label15.Text = "Boyut";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(132, 252);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(132, 300);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(132, 348);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 16;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(132, 396);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 16;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(389, 60);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 16;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(389, 108);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(125, 27);
            textBox10.TabIndex = 16;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(389, 157);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(125, 27);
            textBox11.TabIndex = 16;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(389, 205);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(125, 27);
            textBox12.TabIndex = 16;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(389, 252);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(125, 27);
            textBox13.TabIndex = 16;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(389, 307);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(125, 27);
            textBox14.TabIndex = 16;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(389, 354);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(125, 27);
            textBox15.TabIndex = 16;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(593, 258);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 17;
            label16.Text = "İskonto";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(602, 312);
            label17.Name = "label17";
            label17.Size = new Size(38, 20);
            label17.TabIndex = 19;
            label17.Text = "KDV";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(592, 375);
            label18.Name = "label18";
            label18.Size = new Size(58, 20);
            label18.TabIndex = 21;
            label18.Text = "Dönem";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(753, 449);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 23;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(738, 258);
            label19.Name = "label19";
            label19.Size = new Size(81, 20);
            label19.TabIndex = 24;
            label19.Text = "Showroom";
            // 
            // cmbxshowroom
            // 
            cmbxshowroom.FormattingEnabled = true;
            cmbxshowroom.Location = new Point(696, 281);
            cmbxshowroom.Name = "cmbxshowroom";
            cmbxshowroom.Size = new Size(151, 28);
            cmbxshowroom.TabIndex = 25;
            // 
            // cmbxiskonto
            // 
            cmbxiskonto.FormattingEnabled = true;
            cmbxiskonto.Location = new Point(539, 281);
            cmbxiskonto.Name = "cmbxiskonto";
            cmbxiskonto.Size = new Size(151, 28);
            cmbxiskonto.TabIndex = 26;
            // 
            // cmbxkdv
            // 
            cmbxkdv.FormattingEnabled = true;
            cmbxkdv.Location = new Point(539, 335);
            cmbxkdv.Name = "cmbxkdv";
            cmbxkdv.Size = new Size(151, 28);
            cmbxkdv.TabIndex = 27;
            // 
            // cmbxdonem
            // 
            cmbxdonem.FormattingEnabled = true;
            cmbxdonem.Location = new Point(542, 398);
            cmbxdonem.Name = "cmbxdonem";
            cmbxdonem.Size = new Size(151, 28);
            cmbxdonem.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(548, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 140);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(625, 57);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(94, 29);
            btnResimSec.TabIndex = 30;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(290, 403);
            label20.Name = "label20";
            label20.Size = new Size(82, 20);
            label20.TabIndex = 31;
            label20.Text = "Stok Adedi";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(389, 400);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(125, 27);
            textBox16.TabIndex = 32;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(746, 317);
            label21.Name = "label21";
            label21.Size = new Size(46, 20);
            label21.TabIndex = 33;
            label21.Text = "Depo";
            // 
            // cmbxDepo
            // 
            cmbxDepo.FormattingEnabled = true;
            cmbxDepo.Location = new Point(696, 340);
            cmbxDepo.Name = "cmbxDepo";
            cmbxDepo.Size = new Size(151, 28);
            cmbxDepo.TabIndex = 34;
            // 
            // KaroMalzemeFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbxDepo);
            Controls.Add(label21);
            Controls.Add(textBox16);
            Controls.Add(label20);
            Controls.Add(btnResimSec);
            Controls.Add(pictureBox1);
            Controls.Add(cmbxdonem);
            Controls.Add(cmbxkdv);
            Controls.Add(cmbxiskonto);
            Controls.Add(cmbxshowroom);
            Controls.Add(label19);
            Controls.Add(btnKaydet);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(textBox14);
            Controls.Add(textBox7);
            Controls.Add(textBox15);
            Controls.Add(textBox13);
            Controls.Add(textBox6);
            Controls.Add(textBox12);
            Controls.Add(textBox4);
            Controls.Add(textBox11);
            Controls.Add(textBox5);
            Controls.Add(textBox10);
            Controls.Add(textBox3);
            Controls.Add(textBox9);
            Controls.Add(textBox2);
            Controls.Add(textBox8);
            Controls.Add(textBox1);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGeri);
            Name = "KaroMalzemeFormu";
            Size = new Size(872, 545);
            Load += KaroMalzemeFormu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button btnGeri;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private TextBox textBox15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button btnKaydet;
        private Label label19;
        private ComboBox cmbxshowroom;
        private ComboBox cmbxiskonto;
        private ComboBox cmbxkdv;
        private ComboBox cmbxdonem;
        private PictureBox pictureBox1;
        private Button btnResimSec;
        private Label label20;
        private TextBox textBox16;
        private Label label21;
        private ComboBox cmbxDepo;
    }
}
