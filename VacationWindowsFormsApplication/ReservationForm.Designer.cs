namespace VacationWindowsFormsApplication
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.backBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idClientLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.personNoLabel = new System.Windows.Forms.Label();
            this.roomNoLabel = new System.Windows.Forms.Label();
            this.noPersComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.breackfastCheckBox = new System.Windows.Forms.CheckBox();
            this.optionalLabel = new System.Windows.Forms.Label();
            this.breakfastPicBox = new System.Windows.Forms.PictureBox();
            this.lunchPicBox = new System.Windows.Forms.PictureBox();
            this.lunchCheckBox = new System.Windows.Forms.CheckBox();
            this.dinnerPicBox = new System.Windows.Forms.PictureBox();
            this.dinnerCheckBox = new System.Windows.Forms.CheckBox();
            this.cleaningPcBox = new System.Windows.Forms.PictureBox();
            this.cleaningCheckBox = new System.Windows.Forms.CheckBox();
            this.laundryPicBox = new System.Windows.Forms.PictureBox();
            this.laundryCheckBox = new System.Windows.Forms.CheckBox();
            this.parckingPicBox = new System.Windows.Forms.PictureBox();
            this.parckingCheckBox = new System.Windows.Forms.CheckBox();
            this.carRentalPicBox = new System.Windows.Forms.PictureBox();
            this.carRentalCheckBox = new System.Windows.Forms.CheckBox();
            this.bicyclePicBox = new System.Windows.Forms.PictureBox();
            this.bicycleCheckBox = new System.Windows.Forms.CheckBox();
            this.submitPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningPcBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parckingPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicyclePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Location = new System.Drawing.Point(928, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(84, 35);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backToStart);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 53);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(357, 245);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(143, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(685, 241);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(147, 22);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.startDateLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startDateLabel.Location = new System.Drawing.Point(216, 243);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(117, 24);
            this.startDateLabel.TabIndex = 11;
            this.startDateLabel.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(532, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "End Date";
            // 
            // idClientLabel
            // 
            this.idClientLabel.AutoSize = true;
            this.idClientLabel.BackColor = System.Drawing.Color.Black;
            this.idClientLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idClientLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.idClientLabel.Location = new System.Drawing.Point(216, 295);
            this.idClientLabel.Name = "idClientLabel";
            this.idClientLabel.Size = new System.Drawing.Size(104, 24);
            this.idClientLabel.TabIndex = 13;
            this.idClientLabel.Text = "Client ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(357, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 14;
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.BackColor = System.Drawing.Color.Black;
            this.clientNameLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clientNameLabel.Location = new System.Drawing.Point(532, 297);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(138, 24);
            this.clientNameLabel.TabIndex = 15;
            this.clientNameLabel.Text = "Client Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(685, 300);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 22);
            this.textBox2.TabIndex = 16;
            // 
            // personNoLabel
            // 
            this.personNoLabel.AutoSize = true;
            this.personNoLabel.BackColor = System.Drawing.Color.Black;
            this.personNoLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.personNoLabel.Location = new System.Drawing.Point(532, 348);
            this.personNoLabel.Name = "personNoLabel";
            this.personNoLabel.Size = new System.Drawing.Size(150, 24);
            this.personNoLabel.TabIndex = 17;
            this.personNoLabel.Text = "No of Persons";
            // 
            // roomNoLabel
            // 
            this.roomNoLabel.AutoSize = true;
            this.roomNoLabel.BackColor = System.Drawing.Color.Black;
            this.roomNoLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.roomNoLabel.Location = new System.Drawing.Point(216, 348);
            this.roomNoLabel.Name = "roomNoLabel";
            this.roomNoLabel.Size = new System.Drawing.Size(141, 24);
            this.roomNoLabel.TabIndex = 18;
            this.roomNoLabel.Text = "No of Rooms";
            // 
            // noPersComboBox
            // 
            this.noPersComboBox.FormattingEnabled = true;
            this.noPersComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.noPersComboBox.Location = new System.Drawing.Point(685, 348);
            this.noPersComboBox.Name = "noPersComboBox";
            this.noPersComboBox.Size = new System.Drawing.Size(33, 24);
            this.noPersComboBox.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(357, 348);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(33, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // breackfastCheckBox
            // 
            this.breackfastCheckBox.AutoSize = true;
            this.breackfastCheckBox.Location = new System.Drawing.Point(292, 501);
            this.breackfastCheckBox.Name = "breackfastCheckBox";
            this.breackfastCheckBox.Size = new System.Drawing.Size(18, 17);
            this.breackfastCheckBox.TabIndex = 21;
            this.breackfastCheckBox.UseVisualStyleBackColor = true;
            // 
            // optionalLabel
            // 
            this.optionalLabel.AutoSize = true;
            this.optionalLabel.BackColor = System.Drawing.Color.Black;
            this.optionalLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.optionalLabel.Location = new System.Drawing.Point(216, 452);
            this.optionalLabel.Name = "optionalLabel";
            this.optionalLabel.Size = new System.Drawing.Size(198, 24);
            this.optionalLabel.TabIndex = 23;
            this.optionalLabel.Text = "Optional Services:";
            // 
            // breakfastPicBox
            // 
            this.breakfastPicBox.BackColor = System.Drawing.Color.Transparent;
            this.breakfastPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("breakfastPicBox.BackgroundImage")));
            this.breakfastPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.breakfastPicBox.ErrorImage = null;
            this.breakfastPicBox.InitialImage = null;
            this.breakfastPicBox.Location = new System.Drawing.Point(220, 501);
            this.breakfastPicBox.Name = "breakfastPicBox";
            this.breakfastPicBox.Size = new System.Drawing.Size(66, 59);
            this.breakfastPicBox.TabIndex = 24;
            this.breakfastPicBox.TabStop = false;
            // 
            // lunchPicBox
            // 
            this.lunchPicBox.BackColor = System.Drawing.Color.Transparent;
            this.lunchPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lunchPicBox.BackgroundImage")));
            this.lunchPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lunchPicBox.ErrorImage = null;
            this.lunchPicBox.InitialImage = null;
            this.lunchPicBox.Location = new System.Drawing.Point(390, 501);
            this.lunchPicBox.Name = "lunchPicBox";
            this.lunchPicBox.Size = new System.Drawing.Size(66, 59);
            this.lunchPicBox.TabIndex = 25;
            this.lunchPicBox.TabStop = false;
            // 
            // lunchCheckBox
            // 
            this.lunchCheckBox.AutoSize = true;
            this.lunchCheckBox.Location = new System.Drawing.Point(462, 501);
            this.lunchCheckBox.Name = "lunchCheckBox";
            this.lunchCheckBox.Size = new System.Drawing.Size(18, 17);
            this.lunchCheckBox.TabIndex = 26;
            this.lunchCheckBox.UseVisualStyleBackColor = true;
            // 
            // dinnerPicBox
            // 
            this.dinnerPicBox.BackColor = System.Drawing.Color.Transparent;
            this.dinnerPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dinnerPicBox.BackgroundImage")));
            this.dinnerPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dinnerPicBox.ErrorImage = null;
            this.dinnerPicBox.InitialImage = null;
            this.dinnerPicBox.Location = new System.Drawing.Point(561, 501);
            this.dinnerPicBox.Name = "dinnerPicBox";
            this.dinnerPicBox.Size = new System.Drawing.Size(66, 59);
            this.dinnerPicBox.TabIndex = 27;
            this.dinnerPicBox.TabStop = false;
            // 
            // dinnerCheckBox
            // 
            this.dinnerCheckBox.AutoSize = true;
            this.dinnerCheckBox.Location = new System.Drawing.Point(633, 501);
            this.dinnerCheckBox.Name = "dinnerCheckBox";
            this.dinnerCheckBox.Size = new System.Drawing.Size(18, 17);
            this.dinnerCheckBox.TabIndex = 28;
            this.dinnerCheckBox.UseVisualStyleBackColor = true;
            // 
            // cleaningPcBox
            // 
            this.cleaningPcBox.BackColor = System.Drawing.Color.Transparent;
            this.cleaningPcBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cleaningPcBox.BackgroundImage")));
            this.cleaningPcBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cleaningPcBox.ErrorImage = null;
            this.cleaningPcBox.InitialImage = null;
            this.cleaningPcBox.Location = new System.Drawing.Point(390, 608);
            this.cleaningPcBox.Name = "cleaningPcBox";
            this.cleaningPcBox.Size = new System.Drawing.Size(66, 59);
            this.cleaningPcBox.TabIndex = 29;
            this.cleaningPcBox.TabStop = false;
            this.cleaningPcBox.Click += new System.EventHandler(this.cleaningPcBox_Click);
            // 
            // cleaningCheckBox
            // 
            this.cleaningCheckBox.AutoSize = true;
            this.cleaningCheckBox.Location = new System.Drawing.Point(462, 608);
            this.cleaningCheckBox.Name = "cleaningCheckBox";
            this.cleaningCheckBox.Size = new System.Drawing.Size(18, 17);
            this.cleaningCheckBox.TabIndex = 30;
            this.cleaningCheckBox.UseVisualStyleBackColor = true;
            this.cleaningCheckBox.CheckedChanged += new System.EventHandler(this.cleaningCheckBox_CheckedChanged);
            // 
            // laundryPicBox
            // 
            this.laundryPicBox.BackColor = System.Drawing.Color.Transparent;
            this.laundryPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("laundryPicBox.BackgroundImage")));
            this.laundryPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.laundryPicBox.ErrorImage = null;
            this.laundryPicBox.InitialImage = null;
            this.laundryPicBox.Location = new System.Drawing.Point(220, 608);
            this.laundryPicBox.Name = "laundryPicBox";
            this.laundryPicBox.Size = new System.Drawing.Size(66, 59);
            this.laundryPicBox.TabIndex = 31;
            this.laundryPicBox.TabStop = false;
            // 
            // laundryCheckBox
            // 
            this.laundryCheckBox.AutoSize = true;
            this.laundryCheckBox.Location = new System.Drawing.Point(292, 608);
            this.laundryCheckBox.Name = "laundryCheckBox";
            this.laundryCheckBox.Size = new System.Drawing.Size(18, 17);
            this.laundryCheckBox.TabIndex = 32;
            this.laundryCheckBox.UseVisualStyleBackColor = true;
            // 
            // parckingPicBox
            // 
            this.parckingPicBox.BackColor = System.Drawing.Color.Transparent;
            this.parckingPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("parckingPicBox.BackgroundImage")));
            this.parckingPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.parckingPicBox.ErrorImage = null;
            this.parckingPicBox.InitialImage = null;
            this.parckingPicBox.Location = new System.Drawing.Point(742, 501);
            this.parckingPicBox.Name = "parckingPicBox";
            this.parckingPicBox.Size = new System.Drawing.Size(66, 59);
            this.parckingPicBox.TabIndex = 33;
            this.parckingPicBox.TabStop = false;
            // 
            // parckingCheckBox
            // 
            this.parckingCheckBox.AutoSize = true;
            this.parckingCheckBox.Location = new System.Drawing.Point(814, 501);
            this.parckingCheckBox.Name = "parckingCheckBox";
            this.parckingCheckBox.Size = new System.Drawing.Size(18, 17);
            this.parckingCheckBox.TabIndex = 34;
            this.parckingCheckBox.UseVisualStyleBackColor = true;
            // 
            // carRentalPicBox
            // 
            this.carRentalPicBox.BackColor = System.Drawing.Color.Transparent;
            this.carRentalPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carRentalPicBox.BackgroundImage")));
            this.carRentalPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carRentalPicBox.ErrorImage = null;
            this.carRentalPicBox.InitialImage = null;
            this.carRentalPicBox.Location = new System.Drawing.Point(561, 608);
            this.carRentalPicBox.Name = "carRentalPicBox";
            this.carRentalPicBox.Size = new System.Drawing.Size(66, 59);
            this.carRentalPicBox.TabIndex = 35;
            this.carRentalPicBox.TabStop = false;
            // 
            // carRentalCheckBox
            // 
            this.carRentalCheckBox.AutoSize = true;
            this.carRentalCheckBox.Location = new System.Drawing.Point(633, 608);
            this.carRentalCheckBox.Name = "carRentalCheckBox";
            this.carRentalCheckBox.Size = new System.Drawing.Size(18, 17);
            this.carRentalCheckBox.TabIndex = 36;
            this.carRentalCheckBox.UseVisualStyleBackColor = true;
            // 
            // bicyclePicBox
            // 
            this.bicyclePicBox.BackColor = System.Drawing.Color.Transparent;
            this.bicyclePicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bicyclePicBox.BackgroundImage")));
            this.bicyclePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bicyclePicBox.ErrorImage = null;
            this.bicyclePicBox.InitialImage = null;
            this.bicyclePicBox.Location = new System.Drawing.Point(742, 608);
            this.bicyclePicBox.Name = "bicyclePicBox";
            this.bicyclePicBox.Size = new System.Drawing.Size(66, 59);
            this.bicyclePicBox.TabIndex = 37;
            this.bicyclePicBox.TabStop = false;
            // 
            // bicycleCheckBox
            // 
            this.bicycleCheckBox.AutoSize = true;
            this.bicycleCheckBox.Location = new System.Drawing.Point(814, 608);
            this.bicycleCheckBox.Name = "bicycleCheckBox";
            this.bicycleCheckBox.Size = new System.Drawing.Size(18, 17);
            this.bicycleCheckBox.TabIndex = 38;
            this.bicycleCheckBox.UseVisualStyleBackColor = true;
            // 
            // submitPicBox
            // 
            this.submitPicBox.BackColor = System.Drawing.Color.Transparent;
            this.submitPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submitPicBox.BackgroundImage")));
            this.submitPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submitPicBox.ErrorImage = null;
            this.submitPicBox.InitialImage = null;
            this.submitPicBox.Location = new System.Drawing.Point(453, 746);
            this.submitPicBox.Name = "submitPicBox";
            this.submitPicBox.Size = new System.Drawing.Size(140, 57);
            this.submitPicBox.TabIndex = 45;
            this.submitPicBox.TabStop = false;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 960);
            this.Controls.Add(this.submitPicBox);
            this.Controls.Add(this.bicycleCheckBox);
            this.Controls.Add(this.bicyclePicBox);
            this.Controls.Add(this.carRentalCheckBox);
            this.Controls.Add(this.carRentalPicBox);
            this.Controls.Add(this.parckingCheckBox);
            this.Controls.Add(this.parckingPicBox);
            this.Controls.Add(this.laundryCheckBox);
            this.Controls.Add(this.laundryPicBox);
            this.Controls.Add(this.cleaningCheckBox);
            this.Controls.Add(this.cleaningPcBox);
            this.Controls.Add(this.dinnerCheckBox);
            this.Controls.Add(this.dinnerPicBox);
            this.Controls.Add(this.lunchCheckBox);
            this.Controls.Add(this.lunchPicBox);
            this.Controls.Add(this.breakfastPicBox);
            this.Controls.Add(this.optionalLabel);
            this.Controls.Add(this.breackfastCheckBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.noPersComboBox);
            this.Controls.Add(this.roomNoLabel);
            this.Controls.Add(this.personNoLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.clientNameLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idClientLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfastPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunchPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cleaningPcBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laundryPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parckingPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carRentalPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicyclePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.submitPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idClientLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label personNoLabel;
        private System.Windows.Forms.Label roomNoLabel;
        private System.Windows.Forms.ComboBox noPersComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox breackfastCheckBox;
        private System.Windows.Forms.Label optionalLabel;
        private System.Windows.Forms.PictureBox breakfastPicBox;
        private System.Windows.Forms.PictureBox lunchPicBox;
        private System.Windows.Forms.CheckBox lunchCheckBox;
        private System.Windows.Forms.PictureBox dinnerPicBox;
        private System.Windows.Forms.CheckBox dinnerCheckBox;
        private System.Windows.Forms.PictureBox cleaningPcBox;
        private System.Windows.Forms.CheckBox cleaningCheckBox;
        private System.Windows.Forms.PictureBox laundryPicBox;
        private System.Windows.Forms.CheckBox laundryCheckBox;
        private System.Windows.Forms.PictureBox parckingPicBox;
        private System.Windows.Forms.CheckBox parckingCheckBox;
        private System.Windows.Forms.PictureBox carRentalPicBox;
        private System.Windows.Forms.CheckBox carRentalCheckBox;
        private System.Windows.Forms.PictureBox bicyclePicBox;
        private System.Windows.Forms.CheckBox bicycleCheckBox;
        private System.Windows.Forms.PictureBox submitPicBox;
    }
}