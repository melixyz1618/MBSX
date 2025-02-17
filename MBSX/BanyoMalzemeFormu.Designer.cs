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
            btnGeri.Click += new System.EventHandler(this.btnGeri_Click); // 📌 Buton event'ini buraya ekledik!

            // 
            // BanyoMalzemeFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGeri);
            Name = "BanyoMalzemeFormu";
            Size = new Size(782, 453);
            ResumeLayout(false);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>

        #endregion

        private Button btnGeri;
    }
}
