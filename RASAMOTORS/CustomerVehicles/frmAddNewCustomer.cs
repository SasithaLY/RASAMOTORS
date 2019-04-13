using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASAMOTORS.CustomerVehicles
{
    public partial class frmAddNewCustomer : Form
    {
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }

        CustomerClass c = new CustomerClass();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                //getting values from the input fields

                c.Name = TextBoxName.Text;
                c.NIC = textBoxNIC.Text;
                c.Address = textBoxAddress.Text;
                c.PhoneNumber = textBoxPhone.Text;
                c.EMail = textBoxMail.Text;
                c.Gender = comboBoxGender.Text;


                //check whether insertion is success

                bool success = c.insert(c);

                if (success == true)
                {
                    MessageBox.Show("Successfully Inserted!");
                    this.Close();

                    //to clear data on fields

                    clear();
                }
                else
                {
                    MessageBox.Show("Error Occured!");
                }
            }
        }

        public void clear()
        {
            TextBoxName.Text = "";
            textBoxNIC.Text = "";
            textBoxAddress.Text = "";
            textBoxMail.Text = "";
            textBoxPhone.Text = "";
            comboBoxGender.Text = "";
        }

        public Boolean validate()
        {
            Boolean val = false;

            try
            {
                if (TextBoxName.Text == string.Empty || textBoxAddress.Text == string.Empty || textBoxNIC.Text == string.Empty || textBoxPhone.Text == string.Empty || textBoxMail.Text == string.Empty || comboBoxGender.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All The Fields!");
                    val = false;
                }
                else if (textBoxNIC.Text.Length != 10 || textBoxPhone.Text.Length != 10)
                {
                    MessageBox.Show("Please Enter Valid Inpputs!");
                    val = false;
                }
                else if (!Regex.IsMatch(textBoxPhone.Text, @"^[0-9]+$") || !Regex.IsMatch(textBoxNIC.Text, @"^[0-9vV]+$"))
                {
                    MessageBox.Show("Please Enter Numbers Only!");
                    val = false;
                }
                else if (!textBoxMail.Text.Contains('@') || !textBoxMail.Text.Contains('.'))
                {
                    MessageBox.Show("Please Enter a valid Email!");
                    val = false;
                }
                else if (!Regex.IsMatch(TextBoxName.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please Enter a valid Name!");
                    val = false;
                }
                else if (!Regex.IsMatch(textBoxAddress.Text, @"^[a-zA-Z0-9.,/\s]+$"))
                {
                    MessageBox.Show("Please Enter a valid Address!");
                    val = false;
                }
                else
                {
                    val = true;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return val;
        }
    }
}
