﻿
namespace MBSX
{
    partial class ShowroomForm
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
            btnIptal = new Button();
            btnKaydet = new Button();
            txtShowroomAdi = new TextBox();
            label1 = new Label();
            btnShowroomGeri = new Button();
            SuspendLayout();
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(389, 249);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(100, 40);
            btnIptal.TabIndex = 2;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(216, 249);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(100, 40);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtShowroomAdi
            // 
            txtShowroomAdi.Location = new Point(389, 190);
            txtShowroomAdi.Name = "txtShowroomAdi";
            txtShowroomAdi.Size = new Size(100, 27);
            txtShowroomAdi.TabIndex = 4;
            // 
            // label1
            // 
            label1.Location = new Point(216, 194);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 5;
            label1.Text = "Showroom Adı :";
            // 
            // btnShowroomGeri
            // 
            btnShowroomGeri.Location = new Point(670, 23);
            btnShowroomGeri.Name = "btnShowroomGeri";
            btnShowroomGeri.Size = new Size(94, 29);
            btnShowroomGeri.TabIndex = 6;
            btnShowroomGeri.Text = "Geri";
            btnShowroomGeri.UseVisualStyleBackColor = true;
            btnShowroomGeri.Click += btnShowroomGeri_Click;
            // 
            // ShowroomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnShowroomGeri);
            Controls.Add(btnIptal);
            Controls.Add(btnKaydet);
            Controls.Add(txtShowroomAdi);
            Controls.Add(label1);
            Name = "ShowroomForm";
            Size = new Size(800, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox txtShowroomAdi;
        private Button btnKaydet;
        private Button btnIptal;
        private EventHandler ShowroomForm_Load;
        private Button btnShowroomGeri;
    }
}
