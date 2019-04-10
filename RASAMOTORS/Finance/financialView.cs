using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RASAMOTORS.Finance.serviceCenterClasses;

namespace RASAMOTORS.Finance
{
    public partial class financialView : Form
    {
        public financialView()
        {
            InitializeComponent();
        }

        netProfit c = new netProfit();

        private void btnBack_Click(object sender, EventArgs e)
        {
            new calculation().Show();
            this.Close();
        }

        private void financialView_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvFinancial.DataSource = dt;
        }
    }
}
