using RASAMOTORS.Supplier;
using RASAMOTORS.Suppliers.suppliersClass;
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

namespace RASAMOTORS.Suppliers
{
    public partial class suppliers : Form
    {
        public suppliers()
        {
            InitializeComponent();
        }

        supplierClass c = new supplierClass();

        

        private void supplierView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the data
            //identify rows
            updateDeleteSup update = new updateDeleteSup();

            int rowIndex = e.RowIndex;
            update.txtSupID.Text = supplierView.Rows[rowIndex].Cells[0].Value.ToString();
            update.txtNIC.Text = supplierView.Rows[rowIndex].Cells[1].Value.ToString();
            update.txtFName.Text = supplierView.Rows[rowIndex].Cells[2].Value.ToString();
            update.txtLName.Text = supplierView.Rows[rowIndex].Cells[3].Value.ToString();
            update.txtCNum.Text = supplierView.Rows[rowIndex].Cells[4].Value.ToString();
            update.supplierDate.Text = supplierView.Rows[rowIndex].Cells[5].Value.ToString();
            update.txtEmail.Text = supplierView.Rows[rowIndex].Cells[6].Value.ToString();
            update.txtCName.Text = supplierView.Rows[rowIndex].Cells[7].Value.ToString();
            update.cmbGender.Text = supplierView.Rows[rowIndex].Cells[8].Value.ToString();

            update.ShowDialog();


        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplieInsert supplier = new supplieInsert();
            supplier.ShowDialog();

            this.Close();


        }


        private void suppliers_Load_1(object sender, EventArgs e)
        {
            //Lord data dgv
            DataTable dt = c.Select();

            supplierView.DataSource = dt;
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM supplierDetails WHERE supplierID LIKE '%" + keyword + "%' OR supplierNIC LIKE '%" + keyword + "%' OR firstName LIKE '%" + keyword + "%' OR lastName LIKE '%" + keyword + "%' OR contactNumber LIKE '%" + keyword + "%' OR supDate LIKE '%" + keyword + "%' OR email LIKE '%" + keyword + "%' OR companyName LIKE '%" + keyword + "%' OR gender LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            supplierView.DataSource = dt;
        }

        private void btnRepotr_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportViewSup supplier = new reportViewSup();
            supplier.ShowDialog();

            this.Close();
        }

        private void supplierView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void supSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchEnte(object sender, EventArgs e)
        {

        }

        private void txtSearchEnter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "ID, First Name OR Company")
            {
                txtSearch.Text = "";

                txtSearch.ForeColor = Color.Black;

            }
        }

        private void txtSearchLeave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "ID, First Name OR Company";

                txtSearch.ForeColor = Color.Silver;
            }
        }

        private void supDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
