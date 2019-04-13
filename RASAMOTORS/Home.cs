
using RASAMOTORS.Inventory;
using RASAMOTORS.Suppliers;
using RASAMOTORS.Finance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASAMOTORS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
            suppliers supplier = new suppliers();
            supplier.ShowDialog();
            //new Supplier.suppliers().Show();
        }

        private void jobBtn_Click(object sender, EventArgs e)
        {
            new JobCard.searchJob().Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryView inventory = new InventoryView();
            inventory.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employees.ViewEmployee viewEmployee = new Employees.ViewEmployee();
            viewEmployee.Show();
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            //Finance.calculation cal = new Finance.calculation();
            //cal.Show();
            //new Finance.calculation().Show();
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            new Finance.calculation().Show();
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            new Finance.calculation().Show();
        }
    }
}
