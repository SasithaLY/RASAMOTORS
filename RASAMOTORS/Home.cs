using RASAMOTORS.Inventory;
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
