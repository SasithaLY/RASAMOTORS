using RASAMOTORS.Supplier.ordersClass;
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

namespace RASAMOTORS.Supplier
{
    public partial class orderInsert : Form
    {
        public orderInsert()
        {
            InitializeComponent();
        }

        orderClass c = new orderClass();




        private void orderView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data
            //identify rows

            updateDeleteOrder edit = new updateDeleteOrder();

            int rowIndex = e.RowIndex;
            edit.txtOrdID.Text = orderView.Rows[rowIndex].Cells[0].Value.ToString();
            edit.txtSupName.Text = orderView.Rows[rowIndex].Cells[1].Value.ToString();
            edit.orderDate.Text = orderView.Rows[rowIndex].Cells[2].Value.ToString();
            edit.cmbInType.Text = orderView.Rows[rowIndex].Cells[3].Value.ToString();
            edit.txtAmount.Text = orderView.Rows[rowIndex].Cells[4].Value.ToString();

            edit.ShowDialog();



        }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            //search the data

            string keyword = txtSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM orderDetails WHERE orderID LIKE '%" + keyword + "%' OR supplierName LIKE '%" + keyword + "%' OR orderDate LIKE '%" + keyword + "%' OR inventoryType LIKE '%" + keyword + "%' OR amount LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            orderView.DataSource = dt;
        }

        private void orderInsert_Load(object sender, EventArgs e)
        {

            //Lord data dgv
            DataTable dt = c.Select();

            orderView.DataSource = dt;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplieInsert supplier = new supplieInsert();
            supplier.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderAdd order = new orderAdd();
            order.ShowDialog();
        }

        private void txtSearchEnter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "ID OR Supplier Name")
            {
                txtSearch.Text = "";

                txtSearch.ForeColor = Color.Black;

            }
        }

        private void txtSearchLeave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "ID OR Supplier Name";

                txtSearch.ForeColor = Color.Silver;

            }
        }
    }
}
