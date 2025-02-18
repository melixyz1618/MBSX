namespace MBSX
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
            panelContainer = new Panel();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // btnYeniKayit
            // 
            btnYeniKayit.Location = new Point(87, 345);
            btnYeniKayit.Name = "btnYeniKayit";
            btnYeniKayit.Size = new Size(180, 40);
            btnYeniKayit.TabIndex = 2;
            btnYeniKayit.Text = "Yeni Kayıt";
            btnYeniKayit.UseVisualStyleBackColor = true;
            btnYeniKayit.Click += btnYeniKayit_Click;
            // 
            // btnKayitGuncelle
            // 
            btnKayitGuncelle.Location = new Point(587, 345);
            btnKayitGuncelle.Name = "btnKayitGuncelle";
            btnKayitGuncelle.Size = new Size(180, 40);
            btnKayitGuncelle.TabIndex = 3;
            btnKayitGuncelle.Text = "Kayıt Güncelle";
            btnKayitGuncelle.UseVisualStyleBackColor = true;
            btnKayitGuncelle.Click += btnKayitGuncelle_Click;
            // 
            // btnKayitAra
            // 
            btnKayitAra.Location = new Point(337, 345);
            btnKayitAra.Name = "btnKayitAra";
            btnKayitAra.Size = new Size(180, 40);
            btnKayitAra.TabIndex = 4;
            btnKayitAra.Text = "Kayıt Ara";
            btnKayitAra.UseVisualStyleBackColor = true;
            btnKayitAra.Click += btnKayitAra_Click;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(btnKayitAra);
            panelContainer.Controls.Add(btnKayitGuncelle);
            panelContainer.Controls.Add(btnYeniKayit);
            panelContainer.Location = new Point(-8, -36);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(872, 545);
            panelContainer.TabIndex = 5;
            // 
            // Form1
            // 
            ClientSize = new Size(857, 503);
            Controls.Add(panelContainer);
            Name = "Form1";
            Text = "MBSX Uygulaması";
            Load += Form1_Load;
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
        }
        public System.Windows.Forms.Button btnYeniKayit;
        public System.Windows.Forms.Button btnKayitGuncelle;
        public System.Windows.Forms.Button btnKayitAra;
        public Panel panelContainer;
    }
}
