using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RASAMOTORS.Inventory.inventoryClasses;

namespace RASAMOTORS.Inventory
{
    public partial class InventoryView : Form
    {
        //static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        string connString = Common.Utils.ConnectionString;

        int rowIndex;

        public InventoryView()
        {
            InitializeComponent();

           
        }

    
        Item i = new Item();

       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void InventoryView_Load(object sender, EventArgs e)
        {
            DataTable dt = i.select();
            dataGridItems.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rowIndex.Equals(null))
            {
                MessageBox.Show("Item Not Selected!");
            }
            else
            {
                ItemUpdateForm itemUpdate = new ItemUpdateForm();

                itemUpdate.txtBoxItemID.Text = this.dataGridItems.Rows[rowIndex].Cells[0].Value.ToString();
                itemUpdate.txtBoxItemName.Text = this.dataGridItems.Rows[rowIndex].Cells[1].Value.ToString();
                itemUpdate.txtBoxItemType.Text = this.dataGridItems.Rows[rowIndex].Cells[2].Value.ToString();
                itemUpdate.txtBoxBuyPrice.Text = this.dataGridItems.Rows[rowIndex].Cells[3].Value.ToString();
                itemUpdate.txtBoxSellPrice.Text = this.dataGridItems.Rows[rowIndex].Cells[4].Value.ToString();
                itemUpdate.txtBoxQnt.Text = this.dataGridItems.Rows[rowIndex].Cells[5].Value.ToString();
                itemUpdate.cmbBoxSupplier.Text = this.dataGridItems.Rows[rowIndex].Cells[8].Value.ToString();

                itemUpdate.Show();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (rowIndex.Equals(null))
            {
                MessageBox.Show("Item Not Selected!");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    i.itemID = int.Parse(this.dataGridItems.Rows[rowIndex].Cells[0].Value.ToString());

                    Boolean success = i.Delete(i);

                    if (success == true)
                    {
                        MessageBox.Show("Item Deleted Successfully!");

                    }
                    else
                    {
                        MessageBox.Show("Item Delete Failed!");
                    }
                }
                else
                {

                }
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxSearch.Text;

            if(keyword == "Search by Name , Type , Supplier Company")
            {
                DataTable dt = i.select();
                dataGridItems.DataSource = dt;
            }
            else
            {
                SqlConnection conn = new SqlConnection(connString);

                SqlDataAdapter sda = new SqlDataAdapter("SELECT itemID as 'Item ID', itemName as 'Item Name', itemType as 'Item Type', buyingPrice as 'Buying Price', sellingPrice as 'Selling Price'," +
                    " availableQty as 'Available Qty', soldQty as 'Sold Qty', addedDate as 'Added Date & Time', supplier as 'Supplier' FROM inventory " +
                    "WHERE itemName LIKE '%" + keyword + "%' or itemType LIKE '%" + keyword + "%' or supplier LIKE '%" + keyword + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridItems.DataSource = dt;
            }

            
        }

        private void dataGridItems_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ItemUpdateForm itemUpdate = new ItemUpdateForm();

            int rowIndex = e.RowIndex;

            itemUpdate.txtBoxItemID.Text = this.dataGridItems.Rows[rowIndex].Cells[0].Value.ToString();
            itemUpdate.txtBoxItemName.Text = this.dataGridItems.Rows[rowIndex].Cells[1].Value.ToString();
            itemUpdate.txtBoxItemType.Text = this.dataGridItems.Rows[rowIndex].Cells[2].Value.ToString();
            itemUpdate.txtBoxBuyPrice.Text = this.dataGridItems.Rows[rowIndex].Cells[3].Value.ToString();
            itemUpdate.txtBoxSellPrice.Text = this.dataGridItems.Rows[rowIndex].Cells[4].Value.ToString();
            itemUpdate.txtBoxQnt.Text = this.dataGridItems.Rows[rowIndex].Cells[5].Value.ToString();
            itemUpdate.cmbBoxSupplier.Text = this.dataGridItems.Rows[rowIndex].Cells[8].Value.ToString();

            itemUpdate.Show();
        }

        private void InventoryView_Activated(object sender, EventArgs e)
        {
            DataTable dt = i.select();
            dataGridItems.DataSource = dt;
        }

        private void dataGridItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void txtBoxSearch_Enter(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "Search by Name , Type , Supplier Company")
            {
                txtBoxSearch.Text = "";
                txtBoxSearch.ForeColor = Color.Black;
            }

        }

        private void txtBoxSearch_Leave(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text == "")
            {
                txtBoxSearch.Text = "Search by Name , Type , Supplier Company";
                txtBoxSearch.ForeColor = Color.Silver;
            }
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            ItemsReport itemsReport = new ItemsReport();
            itemsReport.Show();
        }
    }
}
