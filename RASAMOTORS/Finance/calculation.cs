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
    public partial class calculation : Form
    {
        public calculation()
        {
            InitializeComponent();
        }

        netProfit c = new netProfit();

        private void btnCal_Click(object sender, EventArgs e)
        {
            float totIn = Convert.ToInt32(txtTotIncome.Text);
            float InvenSale = Convert.ToInt32(txtInvenSales.Text);
            float order = Convert.ToInt32(txtOrder.Text);
            float InvenPay = Convert.ToInt32(txtInvenPay.Text);
            float Utility = Convert.ToInt32(txtUtilityPay.Text);
            float salary = Convert.ToInt32(txtSal.Text);


            float profit = (totIn + InvenSale) - (order + InvenPay + Utility + salary);
            txtCal.Text = profit.ToString();

            if (profit < 0)
            {
                MessageBox.Show("This is a LOST!!!");
            }
            else
            {
                MessageBox.Show("This month is PROFITABLE....");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                c.Income = float.Parse(txtTotIncome.Text);
                c.InvenSal = float.Parse(txtInvenSales.Text);
                c.Orders = float.Parse(txtOrder.Text);
                c.InvenPay = float.Parse(txtInvenPay.Text);
                c.Utility = float.Parse(txtUtilityPay.Text);
                c.Salary = float.Parse(txtSal.Text);
                c.Profit = float.Parse(txtCal.Text);


                bool Success = c.Insert(c);
                if (Success == true)
                {
                    MessageBox.Show(".....completed......");

                }
                else
                {
                    MessageBox.Show(".....error occured....");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("...Fields cannot be empty...");
            }
        }

        private void txtTotIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtInvenSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtInvenPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtUtilityPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtCal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new financialView().Show();
            this.Close();
        }
    }
}
