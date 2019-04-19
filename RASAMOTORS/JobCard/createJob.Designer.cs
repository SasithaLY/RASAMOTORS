namespace RASAMOTORS.JobCard
{
    partial class createJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createJob));
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.jobIdLabel = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtSrch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvallJobs = new System.Windows.Forms.DataGridView();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.jobDescLable = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.jobPriceLable = new System.Windows.Forms.Label();
            this.jobNameLabel = new System.Windows.Forms.Label();
            this.txtPrc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvallJobs)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(695, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 58;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 84);
            this.panel4.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 450);
            this.panel3.TabIndex = 57;
            // 
            // jobIdLabel
            // 
            this.jobIdLabel.AutoSize = true;
            this.jobIdLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobIdLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.jobIdLabel.Location = new System.Drawing.Point(168, 139);
            this.jobIdLabel.Name = "jobIdLabel";
            this.jobIdLabel.Size = new System.Drawing.Size(51, 19);
            this.jobIdLabel.TabIndex = 56;
            this.jobIdLabel.Text = "Job ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(245, 140);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(199, 20);
            this.txtId.TabIndex = 55;
            // 
            // txtSrch
            // 
            this.txtSrch.Location = new System.Drawing.Point(519, 140);
            this.txtSrch.Name = "txtSrch";
            this.txtSrch.Size = new System.Drawing.Size(269, 20);
            this.txtSrch.TabIndex = 54;
            this.txtSrch.TextChanged += new System.EventHandler(this.txtSrch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(462, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 53;
            this.label4.Text = "Search";
            // 
            // dgvallJobs
            // 
            this.dgvallJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvallJobs.Location = new System.Drawing.Point(461, 173);
            this.dgvallJobs.Name = "dgvallJobs";
            this.dgvallJobs.Size = new System.Drawing.Size(330, 154);
            this.dgvallJobs.TabIndex = 52;
            this.dgvallJobs.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvallJobs_RowHeaderMouseClick);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDel.Location = new System.Drawing.Point(369, 379);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 35);
            this.btnDel.TabIndex = 51;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Location = new System.Drawing.Point(271, 379);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Location = new System.Drawing.Point(172, 379);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 35);
            this.btnInsert.TabIndex = 49;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // jobDescLable
            // 
            this.jobDescLable.AutoSize = true;
            this.jobDescLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobDescLable.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.jobDescLable.Location = new System.Drawing.Point(155, 261);
            this.jobDescLable.Name = "jobDescLable";
            this.jobDescLable.Size = new System.Drawing.Size(78, 19);
            this.jobDescLable.TabIndex = 48;
            this.jobDescLable.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(245, 262);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(199, 111);
            this.txtDesc.TabIndex = 47;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // jobPriceLable
            // 
            this.jobPriceLable.AutoSize = true;
            this.jobPriceLable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobPriceLable.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.jobPriceLable.Location = new System.Drawing.Point(168, 209);
            this.jobPriceLable.Name = "jobPriceLable";
            this.jobPriceLable.Size = new System.Drawing.Size(40, 19);
            this.jobPriceLable.TabIndex = 46;
            this.jobPriceLable.Text = "Price";
            // 
            // jobNameLabel
            // 
            this.jobNameLabel.AutoSize = true;
            this.jobNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNameLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.jobNameLabel.Location = new System.Drawing.Point(168, 174);
            this.jobNameLabel.Name = "jobNameLabel";
            this.jobNameLabel.Size = new System.Drawing.Size(72, 19);
            this.jobNameLabel.TabIndex = 45;
            this.jobNameLabel.Text = "Job Name";
            // 
            // txtPrc
            // 
            this.txtPrc.Location = new System.Drawing.Point(245, 210);
            this.txtPrc.Name = "txtPrc";
            this.txtPrc.Size = new System.Drawing.Size(199, 20);
            this.txtPrc.TabIndex = 44;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(245, 173);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(199, 20);
            this.txtName.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 32);
            this.panel2.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(290, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(317, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "All rights reserved by Valt Pack Software Solutions Company. ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("28 Days Later", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Job Card Panel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(402, -2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(398, 44);
            this.label9.TabIndex = 40;
            this.label9.Text = "Automobile Service Center";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(147, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 36);
            this.panel1.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Goldenrod;
            this.label10.Location = new System.Drawing.Point(519, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(277, 36);
            this.label10.TabIndex = 41;
            this.label10.Text = "Management Software";
            // 
            // createJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.jobIdLabel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtSrch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvallJobs);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.jobDescLable);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.jobPriceLable);
            this.Controls.Add(this.jobNameLabel);
            this.Controls.Add(this.txtPrc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Name = "createJob";
            this.Text = "createJob";
            this.Load += new System.EventHandler(this.createJob_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvallJobs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label jobIdLabel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtSrch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvallJobs;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label jobDescLable;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label jobPriceLable;
        private System.Windows.Forms.Label jobNameLabel;
        private System.Windows.Forms.TextBox txtPrc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}