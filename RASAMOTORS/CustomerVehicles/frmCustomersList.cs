using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASAMOTORS.CustomerVehicles
{
    public partial class frmCustomersList : Form
    {
        public frmCustomersList()
        {
            InitializeComponent();
        }

        CustomerClass c = new CustomerClass();

        private void btnAddNewCus_Click(object sender, EventArgs e)
        {
            frmAddNewCustomer f1 = new frmAddNewCustomer();
            f1.ShowDialog();
        }

        private void frmCustomersList_Load(object sender, EventArgs e)
        {
            DataTable dt = c.select();
            ViewGridCustomers.DataSource = dt;
        }

        private void ViewGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = c.select();
            ViewGridCustomers.DataSource = dt;
        }

        private void ViewGridCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String customerID = ViewGridCustomers.SelectedRows[0].Cells[0].Value.ToString();

            frmVehicleList v1 = new frmVehicleList(customerID);
            v1.ShowDialog();
        }

        private void ViewGridCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmCusUpdateDelete f2 = new frmCusUpdateDelete();

            // get data from data grid view to text fields

            int rowIndex = e.RowIndex;

            f2.textBoxId.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[0].Value.ToString();
            f2.TextBoxName.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[1].Value.ToString();
            f2.textBoxNIC.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[2].Value.ToString();
            f2.textBoxAddress.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[3].Value.ToString();
            f2.textBoxPhone.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[4].Value.ToString();
            f2.textBoxMail.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[5].Value.ToString();
            f2.comboBoxGender.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[6].Value.ToString();

            f2.ShowDialog();
        }
    }
}
