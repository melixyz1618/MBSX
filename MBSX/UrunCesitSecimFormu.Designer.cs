namespace MBSX
{
    partial class UrunCesitSecimFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnKaro;
        private System.Windows.Forms.Button btnBanyo;
        private System.Windows.Forms.Button btnDiger;
        private System.Windows.Forms.Button btnGeri;

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
            btnKaro = new Button();
            btnBanyo = new Button();
            btnDiger = new Button();
            btnGeri = new Button();
            SuspendLayout();
            // 
            // btnKaro
            // 
            btnKaro.Location = new Point(74, 213);
            btnKaro.Name = "btnKaro";
            btnKaro.Size = new Size(150, 40);
            btnKaro.TabIndex = 0;
            btnKaro.Text = "Karo";
            btnKaro.UseVisualStyleBackColor = true;
            btnKaro.Click += btnKaro_Click;
            // 
            // btnBanyo
            // 
            btnBanyo.Location = new Point(293, 213);
            btnBanyo.Name = "btnBanyo";
            btnBanyo.Size = new Size(150, 40);
            btnBanyo.TabIndex = 1;
            btnBanyo.Text = "Banyo";
            btnBanyo.UseVisualStyleBackColor = true;
            btnBanyo.Click += btnBanyo_Click;
            // 
            // btnDiger
            // 
            btnDiger.Location = new Point(504, 213);
            btnDiger.Name = "btnDiger";
            btnDiger.Size = new Size(150, 40);
            btnDiger.TabIndex = 2;
            btnDiger.Text = "Diğer";
            btnDiger.UseVisualStyleBackColor = true;
            btnDiger.Click += btnDiger_Click;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(668, 30);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(80, 30);
            btnGeri.TabIndex = 3;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // UrunCesitSecimFormu
            // 
            Controls.Add(btnKaro);
            Controls.Add(btnBanyo);
            Controls.Add(btnDiger);
            Controls.Add(btnGeri);
            Name = "UrunCesitSecimFormu";
            Size = new Size(782, 453);
            ResumeLayout(false);
        }
    }
}
