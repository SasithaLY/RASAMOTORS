namespace RASAMOTORS.JobCard
{
    partial class searchJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchJob));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.heading = new System.Windows.Forms.Label();
            this.btnBHome = new System.Windows.Forms.Button();
            this.btnNJob = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvAllJobs = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.mainPanel.Controls.Add(this.btnReport);
            this.mainPanel.Controls.Add(this.btnSearch);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.heading);
            this.mainPanel.Controls.Add(this.btnBHome);
            this.mainPanel.Controls.Add(this.btnNJob);
            this.mainPanel.Controls.Add(this.txtSearch);
            this.mainPanel.Controls.Add(this.dgvAllJobs);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1351, 701);
            this.mainPanel.TabIndex = 4;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(1068, 201);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 28);
            this.btnSearch.TabIndex = 88;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(-53, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1439, 10);
            this.panel1.TabIndex = 86;
            // 
            // heading
            // 
            this.heading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Rockwell", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.Color.White;
            this.heading.Location = new System.Drawing.Point(455, 32);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(515, 73);
            this.heading.TabIndex = 85;
            this.heading.Text = "Job Details View";
            // 
            // btnBHome
            // 
            this.btnBHome.BackColor = System.Drawing.Color.Maroon;
            this.btnBHome.FlatAppearance.BorderSize = 0;
            this.btnBHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBHome.ForeColor = System.Drawing.Color.White;
            this.btnBHome.Location = new System.Drawing.Point(63, 193);
            this.btnBHome.Name = "btnBHome";
            this.btnBHome.Size = new System.Drawing.Size(138, 41);
            this.btnBHome.TabIndex = 5;
            this.btnBHome.Text = "HOME";
            this.btnBHome.UseVisualStyleBackColor = false;
            this.btnBHome.Click += new System.EventHandler(this.btnBHome_Click);
            // 
            // btnNJob
            // 
            this.btnNJob.BackColor = System.Drawing.Color.Maroon;
            this.btnNJob.FlatAppearance.BorderSize = 0;
            this.btnNJob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNJob.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNJob.ForeColor = System.Drawing.Color.White;
            this.btnNJob.Location = new System.Drawing.Point(1132, 197);
            this.btnNJob.Name = "btnNJob";
            this.btnNJob.Size = new System.Drawing.Size(85, 32);
            this.btnNJob.TabIndex = 3;
            this.btnNJob.Text = "New Job";
            this.btnNJob.UseVisualStyleBackColor = false;
            this.btnNJob.Click += new System.EventHandler(this.btnNJob_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(245, 201);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(799, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvAllJobs
            // 
            this.dgvAllJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllJobs.Location = new System.Drawing.Point(245, 250);
            this.dgvAllJobs.Name = "dgvAllJobs";
            this.dgvAllJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllJobs.Size = new System.Drawing.Size(972, 416);
            this.dgvAllJobs.TabIndex = 0;
            this.dgvAllJobs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllJobs_CellMouseDoubleClick);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Maroon;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(63, 284);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(138, 41);
            this.btnReport.TabIndex = 89;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // searchJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 701);
            this.Controls.Add(this.mainPanel);
            this.Name = "searchJob";
            this.Text = "searchJob";
//            this.Load += new System.EventHandler(this.searchJob_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Button btnBHome;
        private System.Windows.Forms.Button btnNJob;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.DataGridView dgvAllJobs;
        private System.Windows.Forms.Button btnReport;
    }
}