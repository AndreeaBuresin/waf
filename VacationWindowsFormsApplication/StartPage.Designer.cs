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
            this.closeButton = new System.Windows.Forms.Button();
            this.invoiceBox = new System.Windows.Forms.PictureBox();
            this.reservationBox = new System.Windows.Forms.PictureBox();
            this.clientBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBox)).BeginInit();
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
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Location = new System.Drawing.Point(983, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 27);
            this.closeButton.TabIndex = 6;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exit);
            // 
            // invoiceBox
            // 
            this.invoiceBox.BackColor = System.Drawing.Color.Transparent;
            this.invoiceBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("invoiceBox.BackgroundImage")));
            this.invoiceBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.invoiceBox.ErrorImage = null;
            this.invoiceBox.InitialImage = null;
            this.invoiceBox.Location = new System.Drawing.Point(12, 640);
            this.invoiceBox.Name = "invoiceBox";
            this.invoiceBox.Size = new System.Drawing.Size(225, 119);
            this.invoiceBox.TabIndex = 2;
            this.invoiceBox.TabStop = false;
            // 
            // reservationBox
            // 
            this.reservationBox.BackColor = System.Drawing.Color.Transparent;
            this.reservationBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reservationBox.BackgroundImage")));
            this.reservationBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reservationBox.ErrorImage = null;
            this.reservationBox.InitialImage = null;
            this.reservationBox.Location = new System.Drawing.Point(12, 432);
            this.reservationBox.Name = "reservationBox";
            this.reservationBox.Size = new System.Drawing.Size(225, 119);
            this.reservationBox.TabIndex = 3;
            this.reservationBox.TabStop = false;
            this.reservationBox.Click += new System.EventHandler(this.goToreservation);
            // 
            // clientBox
            // 
            this.clientBox.BackColor = System.Drawing.Color.Transparent;
            this.clientBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientBox.BackgroundImage")));
            this.clientBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientBox.ErrorImage = null;
            this.clientBox.InitialImage = null;
            this.clientBox.Location = new System.Drawing.Point(12, 223);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(225, 119);
            this.clientBox.TabIndex = 4;
            this.clientBox.TabStop = false;
            this.clientBox.Click += new System.EventHandler(this.viewClientForm);
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 960);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.reservationBox);
            this.Controls.Add(this.invoiceBox);
            this.Controls.Add(this.logoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox invoiceBox;
        private System.Windows.Forms.PictureBox reservationBox;
        private System.Windows.Forms.PictureBox clientBox;
    }
}

