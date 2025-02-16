namespace MBSX
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.Panel panelContainer;
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
            this.components = new System.ComponentModel.Container();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnShowroom = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(20, 60);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(760, 400);
            this.panelContainer.TabIndex = 0;

            // 
            // btnShowroom
            // 
            this.btnShowroom.Location = new System.Drawing.Point(20, 20);
            this.btnShowroom.Name = "btnShowroom";
            this.btnShowroom.Size = new System.Drawing.Size(150, 30);
            this.btnShowroom.TabIndex = 1;
            this.btnShowroom.Text = "Showroom";
            this.btnShowroom.UseVisualStyleBackColor = true;
            this.btnShowroom.Click += new System.EventHandler(this.btnShowroom_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnShowroom);
            this.Name = "MainForm";
            this.Text = "Ana Menü";
            this.ResumeLayout(false);
        }
    }
}
