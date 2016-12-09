namespace VacationWindowsFormsApplication
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.existingClientsBtn = new System.Windows.Forms.Button();
            this.newClientBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoBox.BackgroundImage")));
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoBox.ErrorImage = null;
            this.logoBox.InitialImage = null;
            this.logoBox.Location = new System.Drawing.Point(12, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(129, 57);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.Location = new System.Drawing.Point(940, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(54, 44);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backToStart);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(-19, -19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(-19, -19);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 13;
            // 
            // existingClientsBtn
            // 
            this.existingClientsBtn.BackColor = System.Drawing.Color.Transparent;
            this.existingClientsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("existingClientsBtn.BackgroundImage")));
            this.existingClientsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.existingClientsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.existingClientsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.existingClientsBtn.Location = new System.Drawing.Point(75, 282);
            this.existingClientsBtn.Name = "existingClientsBtn";
            this.existingClientsBtn.Size = new System.Drawing.Size(259, 102);
            this.existingClientsBtn.TabIndex = 14;
            this.existingClientsBtn.UseVisualStyleBackColor = false;
            // 
            // newClientBtn
            // 
            this.newClientBtn.BackColor = System.Drawing.Color.Transparent;
            this.newClientBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newClientBtn.BackgroundImage")));
            this.newClientBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newClientBtn.Location = new System.Drawing.Point(688, 282);
            this.newClientBtn.Name = "newClientBtn";
            this.newClientBtn.Size = new System.Drawing.Size(259, 102);
            this.newClientBtn.TabIndex = 15;
            this.newClientBtn.UseVisualStyleBackColor = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 915);
            this.Controls.Add(this.newClientBtn);
            this.Controls.Add(this.existingClientsBtn);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.logoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientForm";
            this.Text = "clientFrom";
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button existingClientsBtn;
        private System.Windows.Forms.Button newClientBtn;
    }
}