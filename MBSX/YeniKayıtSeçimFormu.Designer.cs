namespace MBSX
{
    partial class YeniKayıtSeçimFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnShowroom;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Label lblSoru;

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
            btnShowroom = new Button();
            btnUrun = new Button();
            lblSoru = new Label();
            btnGeri = new Button();
            SuspendLayout();
            // 
            // btnShowroom
            // 
            btnShowroom.Location = new Point(215, 240);
            btnShowroom.Name = "btnShowroom";
            btnShowroom.Size = new Size(100, 40);
            btnShowroom.TabIndex = 0;
            btnShowroom.Text = "Showroom";
            btnShowroom.UseVisualStyleBackColor = true;
            btnShowroom.Click += btnShowroom_Click;
            // 
            // btnUrun
            // 
            btnUrun.Location = new Point(397, 240);
            btnUrun.Name = "btnUrun";
            btnUrun.Size = new Size(100, 40);
            btnUrun.TabIndex = 1;
            btnUrun.Text = "Ürün";
            btnUrun.UseVisualStyleBackColor = true;
            btnUrun.Click += btnUrun_Click;
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(215, 199);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(282, 20);
            lblSoru.TabIndex = 2;
            lblSoru.Text = "Yeni bir showroom mu? Yeni bir ürün mü?";
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(653, 23);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(94, 29);
            btnGeri.TabIndex = 3;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // YeniKayıtSeçimFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGeri);
            Controls.Add(btnShowroom);
            Controls.Add(btnUrun);
            Controls.Add(lblSoru);
            Name = "YeniKayıtSeçimFormu";
            Size = new Size(782, 453);
            Load += YeniKayıtSeçimFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnGeri;
    }
}
