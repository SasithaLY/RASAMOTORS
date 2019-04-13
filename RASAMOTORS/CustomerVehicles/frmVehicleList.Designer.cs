namespace RASAMOTORS.CustomerVehicles
{
    partial class frmVehicleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleList));
            this.picBoxVehList = new System.Windows.Forms.PictureBox();
            this.pnlmidVehLIst = new System.Windows.Forms.Panel();
            this.headingVehList = new System.Windows.Forms.Label();
            this.txtBoxVehSearch = new System.Windows.Forms.TextBox();
            this.btnAddNewVehicle = new System.Windows.Forms.Button();
            this.btnVehSearch = new System.Windows.Forms.Button();
            this.ViewGridVehicles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVehList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGridVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxVehList
            // 
            this.picBoxVehList.BackColor = System.Drawing.Color.Transparent;
            this.picBoxVehList.Image = global::RASAMOTORS.Properties.Resources.Rasa_Motors_Logo;
            this.picBoxVehList.Location = new System.Drawing.Point(12, 12);
            this.picBoxVehList.Name = "picBoxVehList";
            this.picBoxVehList.Size = new System.Drawing.Size(228, 101);
            this.picBoxVehList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxVehList.TabIndex = 112;
            this.picBoxVehList.TabStop = false;
            // 
            // pnlmidVehLIst
            // 
            this.pnlmidVehLIst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlmidVehLIst.BackColor = System.Drawing.Color.Maroon;
            this.pnlmidVehLIst.Location = new System.Drawing.Point(-27, 135);
            this.pnlmidVehLIst.Name = "pnlmidVehLIst";
            this.pnlmidVehLIst.Size = new System.Drawing.Size(1466, 10);
            this.pnlmidVehLIst.TabIndex = 111;
            // 
            // headingVehList
            // 
            this.headingVehList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.headingVehList.AutoSize = true;
            this.headingVehList.Font = new System.Drawing.Font("Rockwell", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingVehList.ForeColor = System.Drawing.Color.White;
            this.headingVehList.Location = new System.Drawing.Point(299, 35);
            this.headingVehList.Name = "headingVehList";
            this.headingVehList.Size = new System.Drawing.Size(779, 65);
            this.headingVehList.TabIndex = 110;
            this.headingVehList.Text = "Vehicle List of The Customer";
            // 
            // txtBoxVehSearch
            // 
            this.txtBoxVehSearch.BackColor = System.Drawing.Color.White;
            this.txtBoxVehSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVehSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxVehSearch.Location = new System.Drawing.Point(12, 179);
            this.txtBoxVehSearch.Name = "txtBoxVehSearch";
            this.txtBoxVehSearch.Size = new System.Drawing.Size(1006, 26);
            this.txtBoxVehSearch.TabIndex = 113;
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewVehicle.BackColor = System.Drawing.Color.Maroon;
            this.btnAddNewVehicle.FlatAppearance.BorderSize = 0;
            this.btnAddNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewVehicle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewVehicle.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewVehicle.Location = new System.Drawing.Point(1097, 178);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.Size = new System.Drawing.Size(105, 28);
            this.btnAddNewVehicle.TabIndex = 115;
            this.btnAddNewVehicle.Text = "Add New";
            this.btnAddNewVehicle.UseVisualStyleBackColor = false;
            this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
            // 
            // btnVehSearch
            // 
            this.btnVehSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVehSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnVehSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVehSearch.BackgroundImage")));
            this.btnVehSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVehSearch.Location = new System.Drawing.Point(1045, 179);
            this.btnVehSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnVehSearch.Name = "btnVehSearch";
            this.btnVehSearch.Size = new System.Drawing.Size(33, 28);
            this.btnVehSearch.TabIndex = 114;
            this.btnVehSearch.UseVisualStyleBackColor = false;
            // 
            // ViewGridVehicles
            // 
            this.ViewGridVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewGridVehicles.BackgroundColor = System.Drawing.Color.White;
            this.ViewGridVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewGridVehicles.Location = new System.Drawing.Point(12, 237);
            this.ViewGridVehicles.Name = "ViewGridVehicles";
            this.ViewGridVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewGridVehicles.Size = new System.Drawing.Size(1190, 308);
            this.ViewGridVehicles.TabIndex = 116;
            // 
            // frmVehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1222, 567);
            this.Controls.Add(this.ViewGridVehicles);
            this.Controls.Add(this.btnAddNewVehicle);
            this.Controls.Add(this.btnVehSearch);
            this.Controls.Add(this.txtBoxVehSearch);
            this.Controls.Add(this.picBoxVehList);
            this.Controls.Add(this.pnlmidVehLIst);
            this.Controls.Add(this.headingVehList);
            this.Name = "frmVehicleList";
            this.Text = "frmVehicleList";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxVehList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGridVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxVehList;
        private System.Windows.Forms.Panel pnlmidVehLIst;
        private System.Windows.Forms.Label headingVehList;
        private System.Windows.Forms.TextBox txtBoxVehSearch;
        private System.Windows.Forms.Button btnAddNewVehicle;
        private System.Windows.Forms.Button btnVehSearch;
        public System.Windows.Forms.DataGridView ViewGridVehicles;
    }
}