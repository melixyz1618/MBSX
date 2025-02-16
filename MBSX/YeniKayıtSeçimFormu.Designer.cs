namespace MBSX
{
    partial class YeniKayıtSeçimFormu
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnShowroom;
        private Button btnUrun;
        private Label lblSoru;

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
            SuspendLayout();
            // 
            // btnShowroom
            // 
            btnShowroom.Location = new Point(255, 240);
            btnShowroom.Name = "btnShowroom";
            btnShowroom.Size = new Size(100, 40);
            btnShowroom.TabIndex = 0;
            btnShowroom.Text = "Showroom";
            btnShowroom.Click += btnShowroom_Click;
            // 
            // btnUrun
            // 
            btnUrun.Location = new Point(397, 240);
            btnUrun.Name = "btnUrun";
            btnUrun.Size = new Size(100, 40);
            btnUrun.TabIndex = 1;
            btnUrun.Text = "Ürün";
            btnUrun.Click += btnUrun_Click;
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(255, 197);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(242, 20);
            lblSoru.TabIndex = 2;
            lblSoru.Text = "Yeni bir sayfa mı? Yeni bir ürün mü?";
            // 
            // YeniKayıtSeçimFormu
            // 
            ClientSize = new Size(782, 453);
            Controls.Add(btnShowroom);
            Controls.Add(btnUrun);
            Controls.Add(lblSoru);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "YeniKayıtSeçimFormu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Yeni Kayıt";
            Load += YeniKayıtSeçimFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
