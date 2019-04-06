namespace RASAMOTORS.Inventory
{
    partial class InventoryForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.cmbBoxSupplier = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtBoxItemType = new System.Windows.Forms.TextBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.txtBoxBuyPrice = new System.Windows.Forms.TextBox();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.txtBoxSellPrice = new System.Windows.Forms.TextBox();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.txtBoxQnt = new System.Windows.Forms.TextBox();
            this.lblQnt = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtBoxItemID = new System.Windows.Forms.TextBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rASADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblErrorQty = new System.Windows.Forms.Label();
            this.lblErrorSell = new System.Windows.Forms.Label();
            this.lblErrorBuy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rASADataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(-15, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 10);
            this.panel1.TabIndex = 104;
            // 
            // btnAddSup
            // 
            this.btnAddSup.BackColor = System.Drawing.Color.Maroon;
            this.btnAddSup.FlatAppearance.BorderSize = 0;
            this.btnAddSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSup.ForeColor = System.Drawing.Color.White;
            this.btnAddSup.Location = new System.Drawing.Point(879, 505);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(184, 26);
            this.btnAddSup.TabIndex = 103;
            this.btnAddSup.Text = "Add New Suplier";
            this.btnAddSup.UseVisualStyleBackColor = false;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // cmbBoxSupplier
            // 
            this.cmbBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxSupplier.FormattingEnabled = true;
            this.cmbBoxSupplier.Location = new System.Drawing.Point(626, 504);
            this.cmbBoxSupplier.Name = "cmbBoxSupplier";
            this.cmbBoxSupplier.Size = new System.Drawing.Size(215, 27);
            this.cmbBoxSupplier.TabIndex = 102;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(701, 622);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 40);
            this.btnClear.TabIndex = 100;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(518, 622);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 40);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxItemName
            // 
            this.txtBoxItemName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemName.Location = new System.Drawing.Point(626, 255);
            this.txtBoxItemName.Name = "txtBoxItemName";
            this.txtBoxItemName.Size = new System.Drawing.Size(215, 27);
            this.txtBoxItemName.TabIndex = 98;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(472, 258);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(96, 19);
            this.lblItemName.TabIndex = 97;
            this.lblItemName.Text = "Item Name";
            // 
            // txtBoxItemType
            // 
            this.txtBoxItemType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemType.Location = new System.Drawing.Point(626, 308);
            this.txtBoxItemType.Name = "txtBoxItemType";
            this.txtBoxItemType.Size = new System.Drawing.Size(215, 27);
            this.txtBoxItemType.TabIndex = 96;
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.BackColor = System.Drawing.Color.Transparent;
            this.lblItemType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.ForeColor = System.Drawing.Color.White;
            this.lblItemType.Location = new System.Drawing.Point(472, 311);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(84, 19);
            this.lblItemType.TabIndex = 95;
            this.lblItemType.Text = "Item Type";
            // 
            // txtBoxBuyPrice
            // 
            this.txtBoxBuyPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuyPrice.Location = new System.Drawing.Point(626, 360);
            this.txtBoxBuyPrice.Name = "txtBoxBuyPrice";
            this.txtBoxBuyPrice.Size = new System.Drawing.Size(215, 27);
            this.txtBoxBuyPrice.TabIndex = 94;
            this.txtBoxBuyPrice.TextChanged += new System.EventHandler(this.txtBoxBuyPrice_TextChanged);
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPrice.ForeColor = System.Drawing.Color.White;
            this.lblBuyPrice.Location = new System.Drawing.Point(472, 363);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(104, 19);
            this.lblBuyPrice.TabIndex = 93;
            this.lblBuyPrice.Text = "Buying Price";
            // 
            // txtBoxSellPrice
            // 
            this.txtBoxSellPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSellPrice.Location = new System.Drawing.Point(626, 409);
            this.txtBoxSellPrice.Name = "txtBoxSellPrice";
            this.txtBoxSellPrice.Size = new System.Drawing.Size(215, 27);
            this.txtBoxSellPrice.TabIndex = 92;
            this.txtBoxSellPrice.TextChanged += new System.EventHandler(this.txtBoxSellPrice_TextChanged);
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSellPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPrice.ForeColor = System.Drawing.Color.White;
            this.lblSellPrice.Location = new System.Drawing.Point(472, 412);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(102, 19);
            this.lblSellPrice.TabIndex = 91;
            this.lblSellPrice.Text = "Selling Price";
            // 
            // txtBoxQnt
            // 
            this.txtBoxQnt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQnt.Location = new System.Drawing.Point(626, 455);
            this.txtBoxQnt.Name = "txtBoxQnt";
            this.txtBoxQnt.Size = new System.Drawing.Size(215, 27);
            this.txtBoxQnt.TabIndex = 90;
            this.txtBoxQnt.TextChanged += new System.EventHandler(this.txtBoxQnt_TextChanged);
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.BackColor = System.Drawing.Color.Transparent;
            this.lblQnt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQnt.ForeColor = System.Drawing.Color.White;
            this.lblQnt.Location = new System.Drawing.Point(472, 458);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(74, 19);
            this.lblQnt.TabIndex = 89;
            this.lblQnt.Text = "Quantity";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(472, 507);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(72, 19);
            this.lblSupplier.TabIndex = 88;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtBoxItemID
            // 
            this.txtBoxItemID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemID.Location = new System.Drawing.Point(626, 208);
            this.txtBoxItemID.Name = "txtBoxItemID";
            this.txtBoxItemID.ReadOnly = true;
            this.txtBoxItemID.Size = new System.Drawing.Size(215, 27);
            this.txtBoxItemID.TabIndex = 87;
            this.txtBoxItemID.Visible = false;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.BackColor = System.Drawing.Color.Transparent;
            this.lblItemId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemId.ForeColor = System.Drawing.Color.White;
            this.lblItemId.Location = new System.Drawing.Point(472, 211);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(62, 19);
            this.lblItemId.TabIndex = 86;
            this.lblItemId.Text = "Item ID";
            this.lblItemId.Visible = false;
            // 
            // lblInventory
            // 
            this.lblInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblInventory.Font = new System.Drawing.Font("Rockwell", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.Color.White;
            this.lblInventory.Location = new System.Drawing.Point(35, 19);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(1247, 125);
            this.lblInventory.TabIndex = 101;
            this.lblInventory.Text = "Add New Item";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RASAMOTORS.Properties.Resources.Rasa_Motors_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(47, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            // 
            // lblErrorQty
            // 
            this.lblErrorQty.AutoSize = true;
            this.lblErrorQty.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorQty.ForeColor = System.Drawing.Color.Red;
            this.lblErrorQty.Location = new System.Drawing.Point(857, 462);
            this.lblErrorQty.Name = "lblErrorQty";
            this.lblErrorQty.Size = new System.Drawing.Size(227, 15);
            this.lblErrorQty.TabIndex = 113;
            this.lblErrorQty.Text = "Invalid Input! Enter Numbers Only";
            this.lblErrorQty.Visible = false;
            // 
            // lblErrorSell
            // 
            this.lblErrorSell.AutoSize = true;
            this.lblErrorSell.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSell.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSell.Location = new System.Drawing.Point(857, 416);
            this.lblErrorSell.Name = "lblErrorSell";
            this.lblErrorSell.Size = new System.Drawing.Size(167, 15);
            this.lblErrorSell.TabIndex = 112;
            this.lblErrorSell.Text = "Invalid Input! Enter Price";
            this.lblErrorSell.Visible = false;
            // 
            // lblErrorBuy
            // 
            this.lblErrorBuy.AutoSize = true;
            this.lblErrorBuy.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBuy.ForeColor = System.Drawing.Color.Red;
            this.lblErrorBuy.Location = new System.Drawing.Point(857, 367);
            this.lblErrorBuy.Name = "lblErrorBuy";
            this.lblErrorBuy.Size = new System.Drawing.Size(167, 15);
            this.lblErrorBuy.TabIndex = 111;
            this.lblErrorBuy.Text = "Invalid Input! Enter Price";
            this.lblErrorBuy.Visible = false;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1264, 710);
            this.Controls.Add(this.lblErrorQty);
            this.Controls.Add(this.lblErrorSell);
            this.Controls.Add(this.lblErrorBuy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.cmbBoxSupplier);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtBoxItemType);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.txtBoxBuyPrice);
            this.Controls.Add(this.lblBuyPrice);
            this.Controls.Add(this.txtBoxSellPrice);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.txtBoxQnt);
            this.Controls.Add(this.lblQnt);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtBoxItemID);
            this.Controls.Add(this.lblItemId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInventory);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rASADataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource rASADataSetBindingSource;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.ComboBox cmbBoxSupplier;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtBoxItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.TextBox txtBoxBuyPrice;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.TextBox txtBoxSellPrice;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.TextBox txtBoxQnt;
        private System.Windows.Forms.Label lblQnt;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtBoxItemID;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblErrorQty;
        private System.Windows.Forms.Label lblErrorSell;
        private System.Windows.Forms.Label lblErrorBuy;
    }
}