using RASAMOTORS.Employees.EmployeeClasses;
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


namespace RASAMOTORS.Employees
{
    public partial class employeeUpdate : Form
    {
        public employeeUpdate()
        {
            InitializeComponent();
        }
        EmployeeClass emp = new EmployeeClass();

       

       

        public Boolean validate()
        {

            Boolean val = false;

            try
            {
                if (firstname.Text == string.Empty || lastname.Text == string.Empty || contactno.Text == string.Empty || homeContact.Text == string.Empty || address.Text == string.Empty || email.Text == string.Empty || nicnumber.Text == string.Empty || gender.Text == string.Empty || firstDate.Text == string.Empty || occupation.Text == string.Empty || empSalary.Text == string.Empty || combostatus.Text == string.Empty || workphone.Text == string.Empty || emeName.Text == string.Empty || emeRelationship.Text == string.Empty || emeContactNo.Text == string.Empty || emeAddress.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All the Fields");
                    val = false;
                }
                else if (!Regex.IsMatch(contactno.Text, "[0-9]{10}"))
                {
                    MessageBox.Show("Please Enter Valid Contact Number");
                    val = false;
                }
                else if (!Regex.IsMatch(homeContact.Text, "[0-9]{10}"))
                {
                    MessageBox.Show("Please Enter Valid Contact Number");
                    val = false;
                }
                else if (!Regex.IsMatch(empSalary.Text, @"^[0-9.9]+$"))
                {
                    MessageBox.Show("Please Enter Numbers Only for Salary Fields");
                    val = false;
                }
                else if (!Regex.IsMatch(workphone.Text, "[0-9]{10}"))
                {
                    MessageBox.Show("Please Enter Valid Contact Number");
                    val = false;
                }
                else if (!Regex.IsMatch(emeContactNo.Text, "[0-9]{10}"))
                {
                    MessageBox.Show("Please Enter Valid Contact Number");
                    val = false;
                }
                else if (!Regex.IsMatch(firstname.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please Enter letters Only for Name Fields");
                    val = false;
                }
                else if (!Regex.IsMatch(lastname.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please Enter letters Only for Name Fields");
                    val = false;
                }
                else if (!Regex.IsMatch(email.Text, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
                {
                    MessageBox.Show("Please Enter Valid Email");
                    val = false;
                }
                else if (!Regex.IsMatch(nicnumber.Text, "[0-9]{9}[vV]{1}$"))
                {
                    MessageBox.Show("Please Enter Valid NIC Number");
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

        private void homeContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void employeeUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validate())
            {

                emp.EmployeeID = int.Parse(empId.Text);
                emp.FirstName = firstname.Text;
                emp.LastName = lastname.Text;
                emp.ContactNo = contactno.Text;
                emp.HomeContactNo = homeContact.Text;
                emp.Address = address.Text;
                emp.EmailID = email.Text;
                emp.NICNo = nicnumber.Text;
                emp.Gender = gender.Text;
                emp.DateOfFirstAppointment = firstDate.Text;
                emp.Occupation = occupation.Text;
                emp.Salary = double.Parse(empSalary.Text);
                emp.Status = combostatus.Text;
                emp.WorkPhone = workphone.Text;
                emp.Name = emeName.Text;
                emp.EmeRelationship = emeRelationship.Text;
                emp.EmeContactNo = emeContactNo.Text;
                emp.EmeAddress = emeAddress.Text;

                //update data in database

                bool success = emp.Update(emp);

                if (success == true)
                {
                    MessageBox.Show("Customer details has been updated successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Update.Try Again!");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (empId.Text == string.Empty)
            {
                MessageBox.Show("Employee Not Selected");
            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show(" Are you sure want to delete this Employee?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    emp.EmployeeID = int.Parse(empId.Text);

                    Boolean success = emp.Delete(emp);

                    if (success == true)
                    {
                        MessageBox.Show("Employee Deleted Successfully");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                else
                {

                }
            }
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {
            if (firstname.Text == string.Empty)
            {
                lblErrorFirstName.Visible = false;
            }
            else if (!Regex.IsMatch(firstname.Text, @"^[a-zA-Z\s]+$"))
            {
                lblErrorFirstName.Visible = true;
            }
            else
            {
                lblErrorFirstName.Visible = false;
            }

        }

        private void contactno_TextChanged(object sender, EventArgs e)
        {
            if (contactno.Text == string.Empty)
            {
                lblemeContactNo.Visible = false;
            }
            else if (!Regex.IsMatch(contactno.Text, @"^[0-9]+$"))
            {
                lblemeContactNo.Visible = true;
            }
            else
            {
                lblemeContactNo.Visible = false;
            }

        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (email.Text == string.Empty)
            {
                labelErrorEmail.Visible = false;
            }
            else if (!Regex.IsMatch(email.Text, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
            {
                labelErrorEmail.Visible = true;
            }
            else
            {
                labelErrorEmail.Visible = false;
            }

        }

        private void nicnumber_TextChanged(object sender, EventArgs e)
        {
            if (nicnumber.Text == string.Empty)
            {
                labelErrorNic.Visible = false;
            }
            else if (!Regex.IsMatch(nicnumber.Text, "[0-9]{9}[vV]{1}$"))
            {
                labelErrorNic.Visible = true;
            }
            else
            {
                labelErrorNic.Visible = false;
            }

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            if (lastname.Text == string.Empty)
            {
               labelErrorLastName.Visible = false;
            }
            else if (!Regex.IsMatch(lastname.Text, @"^[a-zA-Z\s]+$"))
            {
                labelErrorLastName.Visible = true;
            }
            else
            {
                labelErrorLastName.Visible = false;
            }

        }

        private void homeContact_TextChanged_1(object sender, EventArgs e)
        {
            if (homeContact.Text == string.Empty)
            {
                labelErrorHomeContact.Visible = false;
            }
            else if (!Regex.IsMatch(homeContact.Text, @"^[0-9]+$"))
            {
                labelErrorHomeContact.Visible = true;
            }
            else
            {
                labelErrorHomeContact.Visible = false;
            }

        }

        private void workphone_TextChanged(object sender, EventArgs e)
        {
            if (workphone.Text == string.Empty)
            {
                labelErrorWorkPhone.Visible = false;
            }
            else if (!Regex.IsMatch(workphone.Text, @"^[0-9]+$"))
            {
                labelErrorWorkPhone.Visible = true;
            }
            else
            {
                labelErrorWorkPhone.Visible = false;
            }

        }

        private void emeName_TextChanged(object sender, EventArgs e)
        {
            if (emeName.Text == string.Empty)
            {
               lblname.Visible = false;
            }
            else if (!Regex.IsMatch(emeName.Text, @"^[a-zA-Z\s]+$"))
            {
                lblname.Visible = true;
            }
            else
            {
                lblname.Visible = false;
            }
        }

        private void emeContactNo_TextChanged(object sender, EventArgs e)
        {
            if (emeContactNo.Text == string.Empty)
            {
                lblemeContactNo.Visible = false;
            }
            else if (!Regex.IsMatch(emeContactNo.Text, @"^[0-9]+$"))
            {
                lblemeContactNo.Visible = true;
            }
            else
            {
                lblemeContactNo.Visible = false;
            }

        }



        //private void lblErrorFirstName_Click(object sender, EventArgs e)
        //{
        //    if (firstname.Text == string.Empty)
        //    {
        //        lblErrorFirstName.Visible = false;
        //    }
        //    else if (!Regex.IsMatch(firstname.Text, @"^[a-zA-Z\s]+$"))
        //    {
        //        lblErrorFirstName.Visible = true;
        //    }
        //    else
        //    {
        //        lblErrorFirstName.Visible = false;
        //    }

        //}

        //private void labelErrorContactNo_Click(object sender, EventArgs e)
        //{
        //    if (contactno.Text == string.Empty)
        //    {
        //        lblErrorContactNo.Visible = false;
        //    }
        //    else if (!Regex.IsMatch(contactno.Text, @"^[0-9]+$"))
        //    {
        //        lblErrorContactNo.Visible = true;
        //    }
        //    else
        //    {
        //        lblErrorContactNo.Visible = false;
        //    }

        //}

        //private void labelErrorEmail_Click(object sender, EventArgs e)
        //{
        //    if (email.Text == string.Empty)
        //    {
        //        labelErrorEmail.Visible = false;
        //    }
        //    else if (!Regex.IsMatch(email.Text, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
        //    {
        //        lblErrorEmailId.Visible = true;
        //    }
        //    else
        //    {
        //        lblErrorEmailId.Visible = false;
        //    }

        //}

        //private void labelErrorNic_Click(object sender, EventArgs e)
        //{
        //    if (contactno.Text == string.Empty)
        //    {
        //        lblErrorContactNo.Visible = false;
        //    }
        //    else if (!Regex.IsMatch(contactno.Text, @"^[0-9]+$"))
        //    {
        //        lblErrorContactNo.Visible = true;
        //    }
        //    else
        //    {
        //        lblErrorContactNo.Visible = false;
        //    }

        //}

        //private void labelErrorLastName_Click(object sender, EventArgs e)
        //{
        //    if (firstname.Text == string.Empty)
        //    {
        //        lblErrorFirstName.Visible = false;
        //    }
        //    else if (!Regex.IsMatch(firstname.Text, @"^[a-zA-Z\s]+$"))
        //    {
        //        lblErrorFirstName.Visible = true;
        //    }
        //    else
        //    {
        //        lblErrorFirstName.Visible = false;
        //    }

        //}

        //private void labelErrorHomeContact_Click(object sender, EventArgs e)
        //{

        //}

        //private void lblname_Click(object sender, EventArgs e)
        //{
        //    if (firstname.Text == string.Empty)
        //    {
        //        lblErrorFirstName.Visible = false;
        //    }
        //    else if (!Regex.IsMatch(firstname.Text, @"^[a-zA-Z\s]+$"))
        //    {
        //        lblErrorFirstName.Visible = true;
        //    }
        //    else
        //    {
        //        lblErrorFirstName.Visible = false;
        //    }

        //}

        //private void lblemeContactNo_Click(object sender, EventArgs e)
        //{
        //    if (contactno.Text == string.Empty)
        //    {
        //        lblErrorContactNo.Visible = false;
        //    }
        //    else if (!Regex.IsMatch(contactno.Text, @"^[0-9]+$"))
        //    {
        //        lblErrorContactNo.Visible = true;
        //    }
        //    else
        //    {
        //        lblErrorContactNo.Visible = false;
        //    }

        //}

        //private void labelErrorWorkPhone_Click(object sender, EventArgs e)
        //{
        //    if (contactno.Text == string.Empty)
        //    {
        //        lblErrorContactNo.Visible = false;
        //    }
        //    else if (!Regex.IsMatch(contactno.Text, @"^[0-9]+$"))
        //    {
        //        lblErrorContactNo.Visible = true;
        //    }
        //    else
        //    {
        //        lblErrorContactNo.Visible = false;
        //    }

        //}
    }
}
