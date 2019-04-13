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
    public partial class frmCusUpdateDelete : Form
    {
        public frmCusUpdateDelete()
        {
            InitializeComponent();
        }

        CustomerClass c = new CustomerClass();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //getting data from textboxes

            c.CustomerID = int.Parse(textBoxId.Text);
            c.Name = TextBoxName.Text;
            c.NIC = textBoxNIC.Text;
            c.Address = textBoxAddress.Text;
            c.PhoneNumber = textBoxPhone.Text;
            c.EMail = textBoxMail.Text;
            c.Gender = comboBoxGender.Text;

            //update data in database

            bool success = c.update(c);

            if (success == true)
            {
                MessageBox.Show("Customer Details has been updated succesfully!");
                this.Close();

            }
            else
            {
                MessageBox.Show("Failed to update.Try Again!");
            }

        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete all customer information including his behicle details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //get the contact id from the application

                c.CustomerID = Convert.ToInt32(textBoxId.Text);
                bool success = c.deleteAll(c);


                if (success == true)
                {
                    MessageBox.Show("Successfully Deleted");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Delete");
                } 
            }
        }
    }
}
