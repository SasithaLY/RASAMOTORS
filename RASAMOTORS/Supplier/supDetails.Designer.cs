namespace RASAMOTORS.Suppliers
{
    partial class suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suppliers));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.supSearch = new System.Windows.Forms.Label();
            this.supplierView = new System.Windows.Forms.DataGridView();
            this.btnRepotr = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierView)).BeginInit();
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
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(618, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 53);
            this.label1.TabIndex = 57;
            this.label1.Text = "Supplier Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 41);
            this.panel1.TabIndex = 58;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(556, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "All right reserved by Valt Pack Software Solutions Company";
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(208, 166);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(770, 32);
            this.txtSearch.TabIndex = 60;
            this.txtSearch.Text = "ID, First Name OR Company";
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearchEnter);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearchLeave);
            // 
            // supSearch
            // 
            this.supSearch.AutoSize = true;
            this.supSearch.BackColor = System.Drawing.Color.Transparent;
            this.supSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supSearch.ForeColor = System.Drawing.Color.White;
            this.supSearch.Location = new System.Drawing.Point(134, 170);
            this.supSearch.Name = "supSearch";
            this.supSearch.Size = new System.Drawing.Size(62, 18);
            this.supSearch.TabIndex = 59;
            this.supSearch.Text = "Search:";
            // 
            // supplierView
            // 
            this.supplierView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierView.Location = new System.Drawing.Point(137, 239);
            this.supplierView.Name = "supplierView";
            this.supplierView.Size = new System.Drawing.Size(939, 332);
            this.supplierView.TabIndex = 61;
            this.supplierView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierView_CellContentClick);
            this.supplierView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.supplierView_RowHeaderMouseClick);
            // 
            // btnRepotr
            // 
            this.btnRepotr.BackColor = System.Drawing.Color.Maroon;
            this.btnRepotr.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepotr.ForeColor = System.Drawing.Color.White;
            this.btnRepotr.Location = new System.Drawing.Point(1050, 595);
            this.btnRepotr.Name = "btnRepotr";
            this.btnRepotr.Size = new System.Drawing.Size(125, 37);
            this.btnRepotr.TabIndex = 64;
            this.btnRepotr.Text = "Report";
            this.btnRepotr.UseVisualStyleBackColor = false;
            this.btnRepotr.Click += new System.EventHandler(this.btnRepotr_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(904, 595);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 37);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Maroon;
            this.btnOrder.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(760, 595);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(125, 37);
            this.btnOrder.TabIndex = 62;
            this.btnOrder.Text = "Supplier";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnRepotr);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.supplierView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.supSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "suppliers";
            this.Text = " supplier Details";
            this.Load += new System.EventHandler(this.suppliers_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label supSearch;
        private System.Windows.Forms.DataGridView supplierView;
        private System.Windows.Forms.Button btnRepotr;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOrder;
    }
}