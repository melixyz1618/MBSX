﻿namespace MBSX
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            btnYeniKayit = new Button();
            btnKayitGuncelle = new Button();
            btnKayitAra = new Button();
            SuspendLayout();
            // 
            // btnYeniKayit
            // 
            btnYeniKayit.Location = new Point(55, 190);
            btnYeniKayit.Name = "btnYeniKayit";
            btnYeniKayit.Size = new Size(180, 40);
            btnYeniKayit.TabIndex = 2;
            btnYeniKayit.Text = "Yeni Kayıt";
            btnYeniKayit.UseVisualStyleBackColor = true;
            btnYeniKayit.Click += btnYeniKayit_Click;
            // 
            // btnKayitGuncelle
            // 
            btnKayitGuncelle.Location = new Point(555, 190);
            btnKayitGuncelle.Name = "btnKayitGuncelle";
            btnKayitGuncelle.Size = new Size(180, 40);
            btnKayitGuncelle.TabIndex = 3;
            btnKayitGuncelle.Text = "Kayıt Güncelle";
            btnKayitGuncelle.UseVisualStyleBackColor = true;
            btnKayitGuncelle.Click += btnKayitGuncelle_Click;
            // 
            // btnKayitAra
            // 
            btnKayitAra.Location = new Point(305, 190);
            btnKayitAra.Name = "btnKayitAra";
            btnKayitAra.Size = new Size(180, 40);
            btnKayitAra.TabIndex = 4;
            btnKayitAra.Text = "Kayıt Ara";
            btnKayitAra.UseVisualStyleBackColor = true;
            btnKayitAra.Click += btnKayitAra_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(782, 453);
            Controls.Add(btnKayitAra);
            Controls.Add(btnKayitGuncelle);
            Controls.Add(btnYeniKayit);
            Name = "Form1";
            Text = "MBSX Uygulaması";
            Load += Form1_Load;
            ResumeLayout(false);
        }
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnKayitGuncelle;
        private System.Windows.Forms.Button btnKayitAra;
    }
}
