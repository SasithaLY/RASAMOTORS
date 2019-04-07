using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RASAMOTORS.Inventory.inventoryClasses;

namespace RASAMOTORS.Inventory
{
    public partial class ItemUpdateForm : Form
    {
        //static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        string connString = Common.Utils.ConnectionString;

        public ItemUpdateForm()
        {
            InitializeComponent();
        }

        InventoryForm iForm = new InventoryForm();
        InventoryView iView = new InventoryView();
        Item i = new Item();


        public void fillCombo()
        {
            string sql1 = "SELECT * FROM supplierDetails";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string supName = reader.GetString(6);
                    cmbBoxSupplier.Items.Add(supName);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public Boolean validate()
        {
            Boolean val = false;

            try
            {
                if (txtBoxItemName.Text == string.Empty || txtBoxItemType.Text == string.Empty || txtBoxBuyPrice.Text == string.Empty || txtBoxSellPrice.Text == string.Empty || txtBoxQnt.Text == string.Empty || cmbBoxSupplier.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All The Fields!");
                    val = false;

                }
                else if (!Regex.IsMatch(txtBoxBuyPrice.Text, @"^[0-9.9]+$"))
                {
                    MessageBox.Show("Enter Only Numbers for Price Fields!");
                    val = false;
                }
                else if (!Regex.IsMatch(txtBoxSellPrice.Text, @"^[0-9.9]+$"))
                {
                    MessageBox.Show("Enter Only Numbers for Price Fields!");
                    val = false;
                }
                else if (!Regex.IsMatch(txtBoxQnt.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Enter Only Numbers for Quantity!");
                    val = false;
                }
                else
                {
                    val = true;
                }


            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return val;
        }

        public void Clear()
        {
            txtBoxItemID.Text = "";
            txtBoxItemName.Text = "";
            txtBoxItemType.Text = "";
            txtBoxSellPrice.Text = "";
            txtBoxBuyPrice.Text = "";
            txtBoxQnt.Text = "";
            cmbBoxSupplier.Text = "";
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                //get data from input fields
                i.itemID = int.Parse(txtBoxItemID.Text);
                i.itemName = txtBoxItemName.Text;
                i.itemType = txtBoxItemType.Text;
                i.buyingPrice = double.Parse(txtBoxBuyPrice.Text);
                i.sellingPrice = double.Parse(txtBoxSellPrice.Text);
                i.quantity = int.Parse(txtBoxQnt.Text);
                i.supplier = cmbBoxSupplier.Text;

                //update data
                Boolean success = i.Update(i);
                if (success == true)
                {
                    MessageBox.Show("Item Updated Successfully!");
                    
                    Close();
                }
                else
                {
                    MessageBox.Show("Item Update Failed! Try Again!");
                }
            }
        }

        private void ItemUpdateForm_Load(object sender, EventArgs e)
        {
            fillCombo();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (txtBoxItemID.Text == string.Empty)
            {
                MessageBox.Show("Item Not Selected!");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    i.itemID = int.Parse(txtBoxItemID.Text);

                    Boolean success = i.Delete(i);

                    if (success == true)
                    {
                        MessageBox.Show("Item Deleted Successfully!");
                        Close();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            //supplier.supplieInsert supplieInsert = new supplier.supplieInsert();
            //supplieInsert.Show();
        }

        private void txtBoxBuyPrice_TextChanged(object sender, EventArgs e)
        {

            if(txtBoxBuyPrice.Text == string.Empty)
            {
                lblErrorBuy.Visible = false;
            }
            else if(!Regex.IsMatch(txtBoxBuyPrice.Text, @"^[0-9.9]+$"))
            {
                lblErrorBuy.Visible = true;
            }
            else
            {
                lblErrorBuy.Visible = false;
            }
        }

        private void txtBoxSellPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSellPrice.Text == string.Empty)
            {
                lblErrorSell.Visible = false;
            }
            else if (!Regex.IsMatch(txtBoxSellPrice.Text, @"^[0-9.9]+$"))
            {
                lblErrorSell.Visible = true;
            }
            else
            {
                lblErrorSell.Visible = false;
            }
        }

        private void txtBoxQnt_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxQnt.Text == string.Empty)
            {
                lblErrorQty.Visible = false;
            }
            else if (!Regex.IsMatch(txtBoxQnt.Text, @"^[0-9]+$"))
            {
                lblErrorQty.Visible = true;
            }
            else
            {
                lblErrorQty.Visible = false;
            }
        }
    }
}
