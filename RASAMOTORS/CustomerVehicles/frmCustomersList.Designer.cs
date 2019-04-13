namespace RASAMOTORS.CustomerVehicles
{
    partial class frmCustomersList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersList));
            this.btnAddNewCus = new System.Windows.Forms.Button();
            this.txtBoxCusSearch = new System.Windows.Forms.TextBox();
            this.ViewGridCustomers = new System.Windows.Forms.DataGridView();
            this.btnCusSearch = new System.Windows.Forms.Button();
            this.picBoxCusList = new System.Windows.Forms.PictureBox();
            this.pnlmidCusLIst = new System.Windows.Forms.Panel();
            this.headingCusList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCusList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewCus
            // 
            this.btnAddNewCus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewCus.BackColor = System.Drawing.Color.Maroon;
            this.btnAddNewCus.FlatAppearance.BorderSize = 0;
            this.btnAddNewCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCus.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewCus.Location = new System.Drawing.Point(1114, 177);
            this.btnAddNewCus.Name = "btnAddNewCus";
            this.btnAddNewCus.Size = new System.Drawing.Size(105, 28);
            this.btnAddNewCus.TabIndex = 16;
            this.btnAddNewCus.Text = "Add New";
            this.btnAddNewCus.UseVisualStyleBackColor = false;
            this.btnAddNewCus.Click += new System.EventHandler(this.btnAddNewCus_Click);
            // 
            // txtBoxCusSearch
            // 
            this.txtBoxCusSearch.BackColor = System.Drawing.Color.White;
            this.txtBoxCusSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCusSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBoxCusSearch.Location = new System.Drawing.Point(29, 179);
            this.txtBoxCusSearch.Name = "txtBoxCusSearch";
            this.txtBoxCusSearch.Size = new System.Drawing.Size(1006, 26);
            this.txtBoxCusSearch.TabIndex = 15;
            // 
            // ViewGridCustomers
            // 
            this.ViewGridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewGridCustomers.BackgroundColor = System.Drawing.Color.White;
            this.ViewGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewGridCustomers.Location = new System.Drawing.Point(29, 249);
            this.ViewGridCustomers.Name = "ViewGridCustomers";
            this.ViewGridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewGridCustomers.Size = new System.Drawing.Size(1190, 308);
            this.ViewGridCustomers.TabIndex = 13;
            this.ViewGridCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewGridCustomers_CellContentClick);
            this.ViewGridCustomers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewGridCustomers_CellContentDoubleClick);
            this.ViewGridCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ViewGridCustomers_RowHeaderMouseClick);
            // 
            // btnCusSearch
            // 
            this.btnCusSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCusSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnCusSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCusSearch.BackgroundImage")));
            this.btnCusSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCusSearch.Location = new System.Drawing.Point(1062, 178);
            this.btnCusSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnCusSearch.Name = "btnCusSearch";
            this.btnCusSearch.Size = new System.Drawing.Size(33, 28);
            this.btnCusSearch.TabIndex = 14;
            this.btnCusSearch.UseVisualStyleBackColor = false;
            // 
            // picBoxCusList
            // 
            this.picBoxCusList.BackColor = System.Drawing.Color.Transparent;
            this.picBoxCusList.Image = global::RASAMOTORS.Properties.Resources.Rasa_Motors_Logo;
            this.picBoxCusList.Location = new System.Drawing.Point(12, 12);
            this.picBoxCusList.Name = "picBoxCusList";
            this.picBoxCusList.Size = new System.Drawing.Size(228, 101);
            this.picBoxCusList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCusList.TabIndex = 109;
            this.picBoxCusList.TabStop = false;
            // 
            // pnlmidCusLIst
            // 
            this.pnlmidCusLIst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlmidCusLIst.BackColor = System.Drawing.Color.Maroon;
            this.pnlmidCusLIst.Location = new System.Drawing.Point(-27, 135);
            this.pnlmidCusLIst.Name = "pnlmidCusLIst";
            this.pnlmidCusLIst.Size = new System.Drawing.Size(1296, 10);
            this.pnlmidCusLIst.TabIndex = 108;
            // 
            // headingCusList
            // 
            this.headingCusList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.headingCusList.AutoSize = true;
            this.headingCusList.Font = new System.Drawing.Font("Rockwell", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingCusList.ForeColor = System.Drawing.Color.White;
            this.headingCusList.Location = new System.Drawing.Point(450, 30);
            this.headingCusList.Name = "headingCusList";
            this.headingCusList.Size = new System.Drawing.Size(481, 73);
            this.headingCusList.TabIndex = 107;
            this.headingCusList.Text = "Customers List";
            // 
            // frmCustomersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1246, 605);
            this.Controls.Add(this.picBoxCusList);
            this.Controls.Add(this.pnlmidCusLIst);
            this.Controls.Add(this.headingCusList);
            this.Controls.Add(this.btnAddNewCus);
            this.Controls.Add(this.txtBoxCusSearch);
            this.Controls.Add(this.btnCusSearch);
            this.Controls.Add(this.ViewGridCustomers);
            this.Name = "frmCustomersList";
            this.Text = "frmCustomersList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewGridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCusList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewCus;
        private System.Windows.Forms.TextBox txtBoxCusSearch;
        private System.Windows.Forms.Button btnCusSearch;
        public System.Windows.Forms.DataGridView ViewGridCustomers;
        private System.Windows.Forms.PictureBox picBoxCusList;
        private System.Windows.Forms.Panel pnlmidCusLIst;
        private System.Windows.Forms.Label headingCusList;
    }
}