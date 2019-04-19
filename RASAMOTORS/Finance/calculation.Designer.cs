namespace RASAMOTORS.Finance
{
    partial class calculation
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
            this.dtPckr = new System.Windows.Forms.DateTimePicker();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProfit = new System.Windows.Forms.Label();
            this.txtUtilityPay = new System.Windows.Forms.TextBox();
            this.lbUtility = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbExpen = new System.Windows.Forms.Label();
            this.lbIncome = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.lbOrder = new System.Windows.Forms.Label();
            this.txtInvenPay = new System.Windows.Forms.TextBox();
            this.lbInvenPay = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.txtInvenSales = new System.Windows.Forms.TextBox();
            this.lbInvenSales = new System.Windows.Forms.Label();
            this.txtTotIncome = new System.Windows.Forms.TextBox();
            this.lbTotIncome = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPckr
            // 
            this.dtPckr.Location = new System.Drawing.Point(953, 177);
            this.dtPckr.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtPckr.Name = "dtPckr";
            this.dtPckr.Size = new System.Drawing.Size(200, 22);
            this.dtPckr.TabIndex = 122;
            // 
            // txtCal
            // 
            this.txtCal.Location = new System.Drawing.Point(512, 644);
            this.txtCal.Name = "txtCal";
            this.txtCal.ReadOnly = true;
            this.txtCal.Size = new System.Drawing.Size(192, 22);
            this.txtCal.TabIndex = 121;
            this.txtCal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCal_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RASAMOTORS.Properties.Resources.Rasa_Motors_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(49, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 120;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(559, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 72);
            this.label1.TabIndex = 123;
            this.label1.Text = "Finance";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(752, 692);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 57);
            this.btnSave.TabIndex = 119;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblProfit.Location = new System.Drawing.Point(187, 631);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(151, 32);
            this.lblProfit.TabIndex = 118;
            this.lblProfit.Text = "Net Profit ";
            // 
            // txtUtilityPay
            // 
            this.txtUtilityPay.Location = new System.Drawing.Point(512, 532);
            this.txtUtilityPay.Name = "txtUtilityPay";
            this.txtUtilityPay.Size = new System.Drawing.Size(192, 22);
            this.txtUtilityPay.TabIndex = 117;
            this.txtUtilityPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUtilityPay_KeyPress);
            // 
            // lbUtility
            // 
            this.lbUtility.AutoSize = true;
            this.lbUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUtility.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbUtility.Location = new System.Drawing.Point(187, 519);
            this.lbUtility.Name = "lbUtility";
            this.lbUtility.Size = new System.Drawing.Size(160, 32);
            this.lbUtility.TabIndex = 116;
            this.lbUtility.Text = "Utility Bills";
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(512, 571);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(192, 22);
            this.txtSal.TabIndex = 115;
            this.txtSal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSal_KeyPress);
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbSalary.Location = new System.Drawing.Point(187, 556);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(102, 32);
            this.lbSalary.TabIndex = 114;
            this.lbSalary.Text = "Salary";
            // 
            // lbExpen
            // 
            this.lbExpen.AutoSize = true;
            this.lbExpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpen.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbExpen.Location = new System.Drawing.Point(96, 378);
            this.lbExpen.Name = "lbExpen";
            this.lbExpen.Size = new System.Drawing.Size(179, 32);
            this.lbExpen.TabIndex = 113;
            this.lbExpen.Text = "Expenditure";
            // 
            // lbIncome
            // 
            this.lbIncome.AutoSize = true;
            this.lbIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIncome.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbIncome.Location = new System.Drawing.Point(75, 236);
            this.lbIncome.Name = "lbIncome";
            this.lbIncome.Size = new System.Drawing.Size(113, 32);
            this.lbIncome.TabIndex = 112;
            this.lbIncome.Text = "Income";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(512, 430);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(192, 22);
            this.txtOrder.TabIndex = 111;
            this.txtOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrder_KeyPress);
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrder.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbOrder.Location = new System.Drawing.Point(187, 417);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(107, 32);
            this.lbOrder.TabIndex = 110;
            this.lbOrder.Text = "Orders";
            // 
            // txtInvenPay
            // 
            this.txtInvenPay.Location = new System.Drawing.Point(512, 483);
            this.txtInvenPay.Name = "txtInvenPay";
            this.txtInvenPay.Size = new System.Drawing.Size(192, 22);
            this.txtInvenPay.TabIndex = 109;
            this.txtInvenPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvenPay_KeyPress);
            // 
            // lbInvenPay
            // 
            this.lbInvenPay.AutoSize = true;
            this.lbInvenPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvenPay.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbInvenPay.Location = new System.Drawing.Point(187, 468);
            this.lbInvenPay.Name = "lbInvenPay";
            this.lbInvenPay.Size = new System.Drawing.Size(250, 32);
            this.lbInvenPay.TabIndex = 108;
            this.lbInvenPay.Text = "Inventry Payment";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Maroon;
            this.btnView.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(1128, 694);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(91, 57);
            this.btnView.TabIndex = 107;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtInvenSales
            // 
            this.txtInvenSales.Location = new System.Drawing.Point(505, 321);
            this.txtInvenSales.Name = "txtInvenSales";
            this.txtInvenSales.Size = new System.Drawing.Size(192, 22);
            this.txtInvenSales.TabIndex = 106;
            this.txtInvenSales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvenSales_KeyPress);
            // 
            // lbInvenSales
            // 
            this.lbInvenSales.AutoSize = true;
            this.lbInvenSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvenSales.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbInvenSales.Location = new System.Drawing.Point(180, 303);
            this.lbInvenSales.Name = "lbInvenSales";
            this.lbInvenSales.Size = new System.Drawing.Size(203, 32);
            this.lbInvenSales.TabIndex = 105;
            this.lbInvenSales.Text = "Inventry sales";
            // 
            // txtTotIncome
            // 
            this.txtTotIncome.Location = new System.Drawing.Point(505, 277);
            this.txtTotIncome.Name = "txtTotIncome";
            this.txtTotIncome.Size = new System.Drawing.Size(192, 22);
            this.txtTotIncome.TabIndex = 104;
            this.txtTotIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotIncome_KeyPress);
            // 
            // lbTotIncome
            // 
            this.lbTotIncome.AutoSize = true;
            this.lbTotIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotIncome.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbTotIncome.Location = new System.Drawing.Point(180, 268);
            this.lbTotIncome.Name = "lbTotIncome";
            this.lbTotIncome.Size = new System.Drawing.Size(295, 32);
            this.lbTotIncome.TabIndex = 103;
            this.lbTotIncome.Text = "Total service income\r\n";
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.Maroon;
            this.btnCal.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.ForeColor = System.Drawing.Color.White;
            this.btnCal.Location = new System.Drawing.Point(936, 692);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(88, 59);
            this.btnCal.TabIndex = 102;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1269, 769);
            this.Controls.Add(this.dtPckr);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.txtUtilityPay);
            this.Controls.Add(this.lbUtility);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbExpen);
            this.Controls.Add(this.lbIncome);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.txtInvenPay);
            this.Controls.Add(this.lbInvenPay);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtInvenSales);
            this.Controls.Add(this.lbInvenSales);
            this.Controls.Add(this.txtTotIncome);
            this.Controls.Add(this.lbTotIncome);
            this.Controls.Add(this.btnCal);
            this.Name = "calculation";
            this.Text = "calculation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPckr;
        public System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProfit;
        public System.Windows.Forms.TextBox txtUtilityPay;
        private System.Windows.Forms.Label lbUtility;
        public System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbExpen;
        private System.Windows.Forms.Label lbIncome;
        public System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lbOrder;
        public System.Windows.Forms.TextBox txtInvenPay;
        private System.Windows.Forms.Label lbInvenPay;
        private System.Windows.Forms.Button btnView;
        public System.Windows.Forms.TextBox txtInvenSales;
        private System.Windows.Forms.Label lbInvenSales;
        public System.Windows.Forms.TextBox txtTotIncome;
        private System.Windows.Forms.Label lbTotIncome;
        private System.Windows.Forms.Button btnCal;
    }
}