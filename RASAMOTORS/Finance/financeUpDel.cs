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
    public partial class financeUpDel : Form
    {
        public financeUpDel()
        {
            InitializeComponent();
        }

        netProfit c = new netProfit();

        private void button1_Click(object sender, EventArgs e)
        {

            financialView us = new financialView();

            float totIn = Convert.ToInt32(txtTotIncome.Text);
            float InvenSale = Convert.ToInt32(txtInvenSales.Text);

            float order = Convert.ToInt32(txtOrder.Text);
            float InvenPay = Convert.ToInt32(txtInvenPay.Text);
            float Utility = Convert.ToInt32(txtUtilityPay.Text);
            float salary = Convert.ToInt32(txtSal.Text);


            float profit = (totIn + InvenSale) - (order + InvenPay + Utility + salary);
            txtCal.Text = profit.ToString();

            //get data from textbox
            c.CustomerId = int.Parse(txtID.Text);
            c.Income = float.Parse(txtTotIncome.Text);
            c.InvenSal = float.Parse(txtInvenSales.Text);
            c.Orders = float.Parse(txtOrder.Text);
            c.InvenPay = float.Parse(txtInvenPay.Text);
            c.Utility = float.Parse(txtUtilityPay.Text);
            c.Salary = float.Parse(txtSal.Text);
            c.Profit = float.Parse(txtCal.Text);
            c.Date = DateTime.Parse(txtDate.Text);


            //update in database
            bool success = c.Update(c);
            if (success == true)
            {
                MessageBox.Show("Successfully Updated!!!");
                clear();
                //update grid view
                DataTable dt = c.Select();
                us.dgvFinancial.DataSource = dt;

            }
            else
            {
                MessageBox.Show("update unsuccessfull!!!");
            }


        }

        public void clear()
        {
            txtID.Text = "";
            txtTotIncome.Text = "";
            txtInvenSales.Text = "";
            txtOrder.Text = "";
            txtInvenPay.Text = "";
            txtSal.Text = "";
            txtUtilityPay.Text = "";
            txtCal.Text = "";
            txtDate.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new financialView().Show();
            this.Close();
        }
    }
}
