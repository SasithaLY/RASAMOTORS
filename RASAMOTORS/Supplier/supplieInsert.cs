using RASAMOTORS.Suppliers;
using RASAMOTORS.Suppliers.suppliersClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASAMOTORS.Supplier
{
    public partial class supplieInsert : Form
    {
        public supplieInsert()
        {
            InitializeComponent();
        }


        supplierClass c = new supplierClass();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnADD_Click_1(object sender, EventArgs e)
        {
            //add the values
            c.supplierNIC = txtNIC.Text;
            c.firstName = txtFName.Text;
            c.lastName = txtLName.Text;
            c.contactNumber = txtCNum.Text;
            c.supDate = supplierDate.Text;
            c.email = txtEmail.Text;
            c.companyName = txtCName.Text;
            c.gender = cmbGender.Text;

            string firstNamePattern = "^[a-zA-Z][a-zA-Z\\s]+$";
            string lastNamePattern = "^[a-zA-Z][a-zA-Z\\s]+$";
            string companyPattern = "^[a-zA-Z][a-zA-Z\\s]+$";
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
            string phonePattern = "[0-9]{10}";
            string NICPattern = "/^[0-9]{9}[vVxX]$/";

            bool isFirstValid = Regex.IsMatch(txtFName.Text, firstNamePattern);
            bool isLastValid = Regex.IsMatch(txtLName.Text, lastNamePattern);
            bool isCompanyValid = Regex.IsMatch(txtCName.Text, companyPattern);
            bool isPhoneValid = Regex.IsMatch(txtCNum.Text, phonePattern);
            bool isEmailValid = Regex.IsMatch(txtEmail.Text, emailPattern);
            bool isNICValid = Regex.IsMatch(txtNIC.Text, NICPattern);

            // if (c.supplierNIC == "" || c.firstName == "" || c.lastName == "" || c.contactNumber == "" || c.supDate == "" || c.email == "" || c.companyName == "" || c.gender == "")
            // {
            //     MessageBox.Show("Please fill the Fields");
            // }

            if (isNICValid || c.supplierNIC == "")
            {
                MessageBox.Show("Empty Fields or Inalid NIC");
            }

            else if (!isFirstValid || c.firstName == "")
            {
                MessageBox.Show("Empty Fields or Invalid First name");
            }

            else if (!isLastValid || c.lastName == "")
            {
                MessageBox.Show("Empty Fields or Invalid Last name");
            }

            else if (!isPhoneValid || c.contactNumber == "")
            {
                MessageBox.Show("Empty Fields or Invalid Phone number");
            }

            else if (!isEmailValid || c.email == "")
            {
                MessageBox.Show("Empty Fields or Invalid Email");
            }

            else if (!isCompanyValid || c.companyName == "")
            {
                MessageBox.Show("Empty Fields or Invalid company name");
            }

            else if (c.gender == "")
            {
                MessageBox.Show("Empty Fields or Invalid Gender");
            }


            //Inserting data
            else
            {

                bool success = c.Insert(c);

                if (success == true)
                {
                    MessageBox.Show("New supplier successfully inserted!");

                    //Lord data dgv
                    DataTable dt = c.Select();

                    //clear data
                    Clear();
                }

                else
                {
                    MessageBox.Show("Faild to add new supplier, Try again!");
                }


            }



            // supplierView.DataSource = dt;


        }



        //Clear data
        public void Clear()
        {
            // txtSupID.Text = "";
            txtNIC.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtCNum.Text = "";
            txtEmail.Text = "";
            txtCName.Text = "";
            cmbGender.Text = "";

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //clear data
            Clear();
        }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            suppliers order = new suppliers();
            order.ShowDialog();


        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderInsert order = new orderInsert();
            order.ShowDialog();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void supplieInsert_Load(object sender, EventArgs e)
        {
            // DataTable dt = c.Select();
        }
    }
}
