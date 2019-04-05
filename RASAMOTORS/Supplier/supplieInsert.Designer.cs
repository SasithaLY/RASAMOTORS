namespace RASAMOTORS.Supplier
{
    partial class supplieInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplieInsert));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierDate = new System.Windows.Forms.DateTimePicker();
            this.supDate = new System.Windows.Forms.Label();
            this.supGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.supLName = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.supCName = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.supNIC = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.supFName = new System.Windows.Forms.Label();
            this.txtCNum = new System.Windows.Forms.TextBox();
            this.supCNum = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.supEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(503, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 53);
            this.label1.TabIndex = 56;
            this.label1.Text = "Add New Supplier";
            // 
            // supplierDate
            // 
            this.supplierDate.CustomFormat = "yyyy-MM-dd";
            this.supplierDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.supplierDate.Location = new System.Drawing.Point(599, 360);
            this.supplierDate.Name = "supplierDate";
            this.supplierDate.Size = new System.Drawing.Size(148, 22);
            this.supplierDate.TabIndex = 74;
            // 
            // supDate
            // 
            this.supDate.AutoSize = true;
            this.supDate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supDate.ForeColor = System.Drawing.Color.White;
            this.supDate.Location = new System.Drawing.Point(411, 360);
            this.supDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supDate.Name = "supDate";
            this.supDate.Size = new System.Drawing.Size(47, 18);
            this.supDate.TabIndex = 73;
            this.supDate.Text = "Date:";
            // 
            // supGender
            // 
            this.supGender.AutoSize = true;
            this.supGender.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supGender.ForeColor = System.Drawing.Color.White;
            this.supGender.Location = new System.Drawing.Point(411, 514);
            this.supGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supGender.Name = "supGender";
            this.supGender.Size = new System.Drawing.Size(69, 18);
            this.supGender.TabIndex = 72;
            this.supGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(599, 514);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(148, 28);
            this.cmbGender.TabIndex = 71;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(599, 259);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLName.Multiline = true;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(148, 26);
            this.txtLName.TabIndex = 70;
            // 
            // supLName
            // 
            this.supLName.AutoSize = true;
            this.supLName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supLName.ForeColor = System.Drawing.Color.White;
            this.supLName.Location = new System.Drawing.Point(411, 259);
            this.supLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supLName.Name = "supLName";
            this.supLName.Size = new System.Drawing.Size(89, 18);
            this.supLName.TabIndex = 69;
            this.supLName.Text = "Last Name:";
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.Location = new System.Drawing.Point(599, 464);
            this.txtCName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCName.Multiline = true;
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(148, 26);
            this.txtCName.TabIndex = 68;
            // 
            // supCName
            // 
            this.supCName.AutoSize = true;
            this.supCName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supCName.ForeColor = System.Drawing.Color.White;
            this.supCName.Location = new System.Drawing.Point(411, 464);
            this.supCName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supCName.Name = "supCName";
            this.supCName.Size = new System.Drawing.Size(131, 18);
            this.supCName.TabIndex = 67;
            this.supCName.Text = "Company Name:";
            // 
            // txtNIC
            // 
            this.txtNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(599, 156);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(148, 26);
            this.txtNIC.TabIndex = 66;
            // 
            // supNIC
            // 
            this.supNIC.AutoSize = true;
            this.supNIC.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supNIC.ForeColor = System.Drawing.Color.White;
            this.supNIC.Location = new System.Drawing.Point(411, 156);
            this.supNIC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supNIC.Name = "supNIC";
            this.supNIC.Size = new System.Drawing.Size(105, 18);
            this.supNIC.TabIndex = 65;
            this.supNIC.Text = "Supplier NIC:";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(599, 206);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFName.Multiline = true;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(148, 26);
            this.txtFName.TabIndex = 64;
            // 
            // supFName
            // 
            this.supFName.AutoSize = true;
            this.supFName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supFName.ForeColor = System.Drawing.Color.White;
            this.supFName.Location = new System.Drawing.Point(411, 206);
            this.supFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supFName.Name = "supFName";
            this.supFName.Size = new System.Drawing.Size(90, 18);
            this.supFName.TabIndex = 63;
            this.supFName.Text = "First Name:";
            // 
            // txtCNum
            // 
            this.txtCNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNum.Location = new System.Drawing.Point(599, 307);
            this.txtCNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCNum.Multiline = true;
            this.txtCNum.Name = "txtCNum";
            this.txtCNum.Size = new System.Drawing.Size(148, 26);
            this.txtCNum.TabIndex = 62;
            // 
            // supCNum
            // 
            this.supCNum.AutoSize = true;
            this.supCNum.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supCNum.ForeColor = System.Drawing.Color.White;
            this.supCNum.Location = new System.Drawing.Point(411, 307);
            this.supCNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supCNum.Name = "supCNum";
            this.supCNum.Size = new System.Drawing.Size(133, 18);
            this.supCNum.TabIndex = 61;
            this.supCNum.Text = "Contact Number:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(599, 416);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 26);
            this.txtEmail.TabIndex = 60;
            // 
            // supEmail
            // 
            this.supEmail.AutoSize = true;
            this.supEmail.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supEmail.ForeColor = System.Drawing.Color.White;
            this.supEmail.Location = new System.Drawing.Point(411, 416);
            this.supEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supEmail.Name = "supEmail";
            this.supEmail.Size = new System.Drawing.Size(53, 18);
            this.supEmail.TabIndex = 59;
            this.supEmail.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 691);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 41);
            this.panel1.TabIndex = 75;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(548, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "All right reserved by Valt Pack Software Solutions Company";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(421, 606);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 34);
            this.btnClear.TabIndex = 77;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Maroon;
            this.btnOrder.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(740, 603);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(125, 37);
            this.btnOrder.TabIndex = 78;
            this.btnOrder.Text = "Order Details";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(884, 603);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 37);
            this.btnBack.TabIndex = 79;
            this.btnBack.Text = "View";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Maroon;
            this.btnADD.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Location = new System.Drawing.Point(318, 606);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(97, 34);
            this.btnADD.TabIndex = 76;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            // 
            // supplieInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1031, 732);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.supplierDate);
            this.Controls.Add(this.supDate);
            this.Controls.Add(this.supGender);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.supLName);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.supCName);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.supNIC);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.supFName);
            this.Controls.Add(this.txtCNum);
            this.Controls.Add(this.supCNum);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.supEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "supplieInsert";
            this.Text = "supplieInsert";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker supplierDate;
        private System.Windows.Forms.Label supDate;
        private System.Windows.Forms.Label supGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label supLName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label supCName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label supNIC;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label supFName;
        private System.Windows.Forms.TextBox txtCNum;
        private System.Windows.Forms.Label supCNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label supEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnADD;
    }
}