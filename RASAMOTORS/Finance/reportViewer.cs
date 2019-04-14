using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASAMOTORS.Finance
{
    public partial class reportViewer : Form
    {
        public reportViewer()
        {
            InitializeComponent();
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'profitData.tbl_Profit' table. You can move, or remove it, as needed.
            this.tbl_ProfitTableAdapter.Fill(this.profitData.tbl_Profit, Convert.ToDateTime(dteFrm.Text), Convert.ToDateTime(dteTo.Text));

            this.reportViewer1.RefreshReport();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new financialView().Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
