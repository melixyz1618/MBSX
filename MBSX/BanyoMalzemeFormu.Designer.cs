namespace MBSX
{
    partial class BanyoMalzemeFormu
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            cmbxIskonto = new ComboBox();
            cmbxKDV = new ComboBox();
            cmbxDonem = new ComboBox();
            cmbxshowroom = new ComboBox();
            cmbxDepo = new ComboBox();
            pictureBox1 = new PictureBox();
            btnResimSec = new Button();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(647, 44);
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
            label1.Location = new Point(38, 100);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Seri Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 143);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Ürün Kodu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 186);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 3;
            label3.Text = "Ürün İsmi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 229);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 4;
            label4.Text = "Brüt Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 272);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 5;
            label5.Text = "Ürün Grubu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 315);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 6;
            label6.Text = "Renk";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(338, 96);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 7;
            label7.Text = "İskonto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(347, 150);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 8;
            label8.Text = "KDV";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(337, 204);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 9;
            label9.Text = "Dönem";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(326, 258);
            label10.Name = "label10";
            label10.Size = new Size(81, 20);
            label10.TabIndex = 10;
            label10.Text = "Showroom";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(344, 312);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 11;
            label11.Text = "Depo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(155, 136);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(155, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 222);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(155, 265);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(155, 308);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 12;
            // 
            // cmbxIskonto
            // 
            cmbxIskonto.FormattingEnabled = true;
            cmbxIskonto.Location = new Point(437, 93);
            cmbxIskonto.Name = "cmbxIskonto";
            cmbxIskonto.Size = new Size(151, 28);
            cmbxIskonto.TabIndex = 18;
            // 
            // cmbxKDV
            // 
            cmbxKDV.FormattingEnabled = true;
            cmbxKDV.Location = new Point(437, 146);
            cmbxKDV.Name = "cmbxKDV";
            cmbxKDV.Size = new Size(151, 28);
            cmbxKDV.TabIndex = 19;
            // 
            // cmbxDonem
            // 
            cmbxDonem.FormattingEnabled = true;
            cmbxDonem.Location = new Point(437, 199);
            cmbxDonem.Name = "cmbxDonem";
            cmbxDonem.Size = new Size(151, 28);
            cmbxDonem.TabIndex = 20;
            // 
            // cmbxshowroom
            // 
            cmbxshowroom.FormattingEnabled = true;
            cmbxshowroom.Location = new Point(437, 252);
            cmbxshowroom.Name = "cmbxshowroom";
            cmbxshowroom.Size = new Size(151, 28);
            cmbxshowroom.TabIndex = 21;
            // 
            // cmbxDepo
            // 
            cmbxDepo.FormattingEnabled = true;
            cmbxDepo.Location = new Point(437, 305);
            cmbxDepo.Name = "cmbxDepo";
            cmbxDepo.Size = new Size(151, 28);
            cmbxDepo.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(631, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // btnResimSec
            // 
            btnResimSec.Location = new Point(647, 127);
            btnResimSec.Name = "btnResimSec";
            btnResimSec.Size = new Size(94, 29);
            btnResimSec.TabIndex = 24;
            btnResimSec.Text = "Resim Seç";
            btnResimSec.UseVisualStyleBackColor = true;
            btnResimSec.Click += btnResimSec_Click;

            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(647, 382);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 25;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;

            // 
            // BanyoMalzemeFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnKaydet);
            Controls.Add(btnResimSec);
            Controls.Add(pictureBox1);
            Controls.Add(cmbxDepo);
            Controls.Add(cmbxshowroom);
            Controls.Add(cmbxDonem);
            Controls.Add(cmbxKDV);
            Controls.Add(cmbxIskonto);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            Name = "BanyoMalzemeFormu";
            Size = new Size(782, 453);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>

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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox cmbxIskonto;
        private ComboBox cmbxKDV;
        private ComboBox cmbxDonem;
        private ComboBox cmbxshowroom;
        private ComboBox cmbxDepo;
        private PictureBox pictureBox1;
        private Button btnResimSec;
        private Button btnKaydet;
    }
}
