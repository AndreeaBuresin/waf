namespace VacationWindowsFormsApplication
{
    partial class startPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startPage));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.createUserBox = new System.Windows.Forms.PictureBox();
            this.invoiceBox = new System.Windows.Forms.PictureBox();
            this.reservationBox = new System.Windows.Forms.PictureBox();
            this.clientBox = new System.Windows.Forms.PictureBox();
            this.updateUserBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createUserBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateUserBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoBox.BackgroundImage")));
            this.logoBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logoBox.ErrorImage = null;
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.InitialImage = null;
            this.logoBox.Location = new System.Drawing.Point(12, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(129, 57);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            this.logoBox.Click += new System.EventHandler(this.webSite);
            // 
            // createUserBox
            // 
            this.createUserBox.BackColor = System.Drawing.Color.Transparent;
            this.createUserBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createUserBox.BackgroundImage")));
            this.createUserBox.Image = ((System.Drawing.Image)(resources.GetObject("createUserBox.Image")));
            this.createUserBox.Location = new System.Drawing.Point(12, 88);
            this.createUserBox.Name = "createUserBox";
            this.createUserBox.Size = new System.Drawing.Size(165, 118);
            this.createUserBox.TabIndex = 1;
            this.createUserBox.TabStop = false;
            this.createUserBox.Click += new System.EventHandler(this.createUser);
            // 
            // invoiceBox
            // 
            this.invoiceBox.BackColor = System.Drawing.Color.Transparent;
            this.invoiceBox.Image = ((System.Drawing.Image)(resources.GetObject("invoiceBox.Image")));
            this.invoiceBox.Location = new System.Drawing.Point(205, 380);
            this.invoiceBox.Name = "invoiceBox";
            this.invoiceBox.Size = new System.Drawing.Size(154, 96);
            this.invoiceBox.TabIndex = 2;
            this.invoiceBox.TabStop = false;
            // 
            // reservationBox
            // 
            this.reservationBox.BackColor = System.Drawing.Color.Transparent;
            this.reservationBox.Image = ((System.Drawing.Image)(resources.GetObject("reservationBox.Image")));
            this.reservationBox.Location = new System.Drawing.Point(205, 240);
            this.reservationBox.Name = "reservationBox";
            this.reservationBox.Size = new System.Drawing.Size(154, 96);
            this.reservationBox.TabIndex = 3;
            this.reservationBox.TabStop = false;
            // 
            // clientBox
            // 
            this.clientBox.BackColor = System.Drawing.Color.Transparent;
            this.clientBox.ErrorImage = null;
            this.clientBox.Image = ((System.Drawing.Image)(resources.GetObject("clientBox.Image")));
            this.clientBox.InitialImage = null;
            this.clientBox.Location = new System.Drawing.Point(12, 369);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(165, 118);
            this.clientBox.TabIndex = 4;
            this.clientBox.TabStop = false;
            this.clientBox.Click += new System.EventHandler(this.viewClientForm);
            // 
            // updateUserBox
            // 
            this.updateUserBox.BackColor = System.Drawing.Color.Transparent;
            this.updateUserBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateUserBox.BackgroundImage")));
            this.updateUserBox.Image = ((System.Drawing.Image)(resources.GetObject("updateUserBox.Image")));
            this.updateUserBox.Location = new System.Drawing.Point(12, 227);
            this.updateUserBox.Name = "updateUserBox";
            this.updateUserBox.Size = new System.Drawing.Size(165, 118);
            this.updateUserBox.TabIndex = 5;
            this.updateUserBox.TabStop = false;
            this.updateUserBox.Click += new System.EventHandler(this.updateUserPage);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Location = new System.Drawing.Point(753, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(59, 57);
            this.closeButton.TabIndex = 6;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exit);
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 499);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateUserBox);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.reservationBox);
            this.Controls.Add(this.invoiceBox);
            this.Controls.Add(this.createUserBox);
            this.Controls.Add(this.logoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createUserBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateUserBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PictureBox createUserBox;
        private System.Windows.Forms.PictureBox invoiceBox;
        private System.Windows.Forms.PictureBox reservationBox;
        private System.Windows.Forms.PictureBox clientBox;
        private System.Windows.Forms.PictureBox updateUserBox;
        private System.Windows.Forms.Button closeButton;
    }
}

