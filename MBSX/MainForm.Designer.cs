namespace MBSX
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnShowroom;

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
            SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new Point(20, 60);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new Size(760, 400);
            this.panelContainer.TabIndex = 0;
            // 
            // btnShowroom
            // 
            btnShowroom.Location = new Point(20, 20);
            btnShowroom.Name = "btnShowroom";
            btnShowroom.Size = new Size(150, 30);
            btnShowroom.TabIndex = 1;
            btnShowroom.Text = "Showroom";
            btnShowroom.UseVisualStyleBackColor = true;
            btnShowroom.Click += btnShowroom_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(panelContainer);
            Controls.Add(btnShowroom);
            Name = "MainForm";
            Text = "Ana Menü";
            ResumeLayout(false);
        }
    }
}
