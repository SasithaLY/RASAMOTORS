namespace RASAMOTORS.CustomerVehicles
{
    partial class frmCusUpdateDelete
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
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.lblCusId = new System.Windows.Forms.Label();
            this.btnUpdateCus = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.headingUpDelCus = new System.Windows.Forms.Label();
            this.pnlMidUpDelCus = new System.Windows.Forms.Panel();
            this.picBoxUpDelCus = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpDelCus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteCus.FlatAppearance.BorderSize = 0;
            this.btnDeleteCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCus.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCus.Location = new System.Drawing.Point(513, 514);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(149, 35);
            this.btnDeleteCus.TabIndex = 98;
            this.btnDeleteCus.Text = "Delete Customer";
            this.btnDeleteCus.UseVisualStyleBackColor = false;
            this.btnDeleteCus.Click += new System.EventHandler(this.btnDeleteCus_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(513, 160);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(129, 26);
            this.textBoxId.TabIndex = 97;
            // 
            // lblCusId
            // 
            this.lblCusId.AutoSize = true;
            this.lblCusId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusId.ForeColor = System.Drawing.Color.White;
            this.lblCusId.Location = new System.Drawing.Point(357, 167);
            this.lblCusId.Name = "lblCusId";
            this.lblCusId.Size = new System.Drawing.Size(110, 20);
            this.lblCusId.TabIndex = 96;
            this.lblCusId.Text = "Customer ID";
            // 
            // btnUpdateCus
            // 
            this.btnUpdateCus.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdateCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateCus.FlatAppearance.BorderSize = 0;
            this.btnUpdateCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCus.Location = new System.Drawing.Point(339, 514);
            this.btnUpdateCus.Name = "btnUpdateCus";
            this.btnUpdateCus.Size = new System.Drawing.Size(154, 35);
            this.btnUpdateCus.TabIndex = 95;
            this.btnUpdateCus.Text = "Update Customer";
            this.btnUpdateCus.UseVisualStyleBackColor = false;
            this.btnUpdateCus.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(357, 453);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 94;
            this.lblGender.Text = "Gender";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(511, 451);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(131, 28);
            this.comboBoxGender.TabIndex = 93;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.Location = new System.Drawing.Point(513, 393);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(129, 26);
            this.textBoxMail.TabIndex = 92;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(357, 400);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(69, 20);
            this.lblMail.TabIndex = 91;
            this.lblMail.Text = "E - mail";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(513, 345);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(129, 26);
            this.textBoxPhone.TabIndex = 90;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(357, 352);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(127, 20);
            this.lblPhone.TabIndex = 89;
            this.lblPhone.Text = "Phone Number";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(513, 295);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(129, 26);
            this.textBoxAddress.TabIndex = 88;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(357, 302);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 20);
            this.lblAddress.TabIndex = 87;
            this.lblAddress.Text = "Address";
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNIC.Location = new System.Drawing.Point(513, 250);
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(129, 26);
            this.textBoxNIC.TabIndex = 86;
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIC.ForeColor = System.Drawing.Color.White;
            this.lblNIC.Location = new System.Drawing.Point(357, 257);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(39, 20);
            this.lblNIC.TabIndex = 85;
            this.lblNIC.Text = "NIC";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.Location = new System.Drawing.Point(513, 204);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(129, 26);
            this.TextBoxName.TabIndex = 84;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(357, 211);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 83;
            this.lblName.Text = "Name";
            // 
            // headingUpDelCus
            // 
            this.headingUpDelCus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.headingUpDelCus.AutoSize = true;
            this.headingUpDelCus.Font = new System.Drawing.Font("Rockwell", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingUpDelCus.ForeColor = System.Drawing.Color.White;
            this.headingUpDelCus.Location = new System.Drawing.Point(268, 28);
            this.headingUpDelCus.Name = "headingUpDelCus";
            this.headingUpDelCus.Size = new System.Drawing.Size(700, 65);
            this.headingUpDelCus.TabIndex = 82;
            this.headingUpDelCus.Text = "Update/Delete Customers";
            // 
            // pnlMidUpDelCus
            // 
            this.pnlMidUpDelCus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMidUpDelCus.BackColor = System.Drawing.Color.Maroon;
            this.pnlMidUpDelCus.Location = new System.Drawing.Point(-18, 126);
            this.pnlMidUpDelCus.Name = "pnlMidUpDelCus";
            this.pnlMidUpDelCus.Size = new System.Drawing.Size(1161, 10);
            this.pnlMidUpDelCus.TabIndex = 105;
            // 
            // picBoxUpDelCus
            // 
            this.picBoxUpDelCus.BackColor = System.Drawing.Color.Transparent;
            this.picBoxUpDelCus.Image = global::RASAMOTORS.Properties.Resources.Rasa_Motors_Logo;
            this.picBoxUpDelCus.Location = new System.Drawing.Point(12, 12);
            this.picBoxUpDelCus.Name = "picBoxUpDelCus";
            this.picBoxUpDelCus.Size = new System.Drawing.Size(228, 101);
            this.picBoxUpDelCus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUpDelCus.TabIndex = 106;
            this.picBoxUpDelCus.TabStop = false;
            // 
            // frmCusUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1131, 596);
            this.Controls.Add(this.picBoxUpDelCus);
            this.Controls.Add(this.pnlMidUpDelCus);
            this.Controls.Add(this.btnDeleteCus);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.lblCusId);
            this.Controls.Add(this.btnUpdateCus);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.textBoxNIC);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.headingUpDelCus);
            this.Name = "frmCusUpdateDelete";
            this.Text = "frmCusUpdateDelete";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUpDelCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteCus;
        public System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label lblCusId;
        private System.Windows.Forms.Button btnUpdateCus;
        private System.Windows.Forms.Label lblGender;
        public System.Windows.Forms.ComboBox comboBoxGender;
        public System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label lblMail;
        public System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label lblPhone;
        public System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        public System.Windows.Forms.TextBox textBoxNIC;
        private System.Windows.Forms.Label lblNIC;
        public System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label headingUpDelCus;
        private System.Windows.Forms.Panel pnlMidUpDelCus;
        private System.Windows.Forms.PictureBox picBoxUpDelCus;
    }
}