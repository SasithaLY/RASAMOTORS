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

        private void dgvFinancial_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            financeUpDel cus = new financeUpDel();
            cus.txtID.Text = this.dgvFinancial.CurrentRow.Cells[0].Value.ToString();
            cus.txtTotIncome.Text = this.dgvFinancial.CurrentRow.Cells[1].Value.ToString();
            cus.txtInvenSales.Text = this.dgvFinancial.CurrentRow.Cells[2].Value.ToString();
            //cus.txtPaint.Text = this.dgvFinancial.CurrentRow.Cells[3].Value.ToString();
            //cus.txtOil.Text = this.dgvFinancial.CurrentRow.Cells[4].Value.ToString();
            cus.txtOrder.Text = this.dgvFinancial.CurrentRow.Cells[5].Value.ToString();
            cus.txtInvenPay.Text = this.dgvFinancial.CurrentRow.Cells[6].Value.ToString();
            cus.txtUtilityPay.Text = this.dgvFinancial.CurrentRow.Cells[7].Value.ToString();
            cus.txtSal.Text = this.dgvFinancial.CurrentRow.Cells[8].Value.ToString();
            cus.txtCal.Text = this.dgvFinancial.CurrentRow.Cells[9].Value.ToString();
            cus.txtDate.Text = this.dgvFinancial.CurrentRow.Cells[10].Value.ToString();
            cus.ShowDialog();
            this.Close();
        }
    }
}
