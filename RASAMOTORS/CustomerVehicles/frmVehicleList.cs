using RASAMOTORS.CustomerVehicles.Classes;
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
    public partial class frmVehicleList : Form
    {
        private string customerID;
        VehicleClass v = new VehicleClass();

        public frmVehicleList(string customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            frmAddNewVehicle v1 = new frmAddNewVehicle(customerID);
            v1.ShowDialog();
            ViewGridVehicles.DataSource = loadData();
        }

        private DataTable loadData()
        {
            DataTable dt = v.select("where CustomerID = '" + customerID + "'");
            return dt;

        }
    }
}
