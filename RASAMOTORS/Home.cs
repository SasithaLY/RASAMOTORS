
using RASAMOTORS.Inventory;
using RASAMOTORS.Suppliers;
using RASAMOTORS.Suppliers;
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
            this.Hide();
            suppliers supplier = new suppliers();
            supplier.ShowDialog();

            this.Close();

            //new Supplier.suppliers().Show();

        }

        private void jobBtn_Click(object sender, EventArgs e)
        {
            new JobCard.createJob().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InventoryView inventory = new InventoryView();
            inventory.Show();
        }
    }
}
