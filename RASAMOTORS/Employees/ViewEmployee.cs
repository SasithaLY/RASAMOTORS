using RASAMOTORS.Employees.EmployeeClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RASAMOTORS.Employees
{
    public partial class ViewEmployee : Form
    {
        //static string conString = ConfigurationManager.ConnectionStrings["conStrings"].ConnectionString;

        string conString = Common.Utils.ConnectionString;

        public ViewEmployee()
        {
            InitializeComponent();
        }
         EmployeeClass emp = new EmployeeClass();

        //public static string getNewConnection()
        //{
        //    return ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        //}
       

        private void datagridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //load data on data grid view
            DataTable dt = emp.Select();
            datagridViewEmployee.DataSource = dt;

        }
  

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get update form
            employeeUpdate update = new employeeUpdate();
            update.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }


       

        

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //connect the employee form
            employee view = new employee();
            view.Show();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_Search.Text;

            SqlConnection conn = new SqlConnection(conString);

            SqlDataAdapter adapter = new SqlDataAdapter(" SELECT * FROM emp WHERE FirstName LIKE '%" + keyword + "%'  or LastName  LIKE '%" + keyword + "%' or ContactNo  LIKE '%" + keyword + "%'or HomeContactNo  LIKE '%" + keyword + "%' or Address  LIKE '%" + keyword + "%' or EmailID  LIKE '%" + keyword + "%' or NICNo  LIKE '%" + keyword + "%' or Gender  LIKE '%" + keyword + "%' or DateOfFirstAppointment  LIKE '%" + keyword + "%' or Occupation  LIKE '%" + keyword + "%' or Salary  LIKE '%" + keyword + "%' or Status  LIKE '%" + keyword + "%' or WorkPhone  LIKE '%" + keyword + "%' or Name  LIKE '%" + keyword + "%'  or Relationship  LIKE '%" + keyword + "%' or EmeContactNo  LIKE '%" + keyword + "%'   or EmeAddress  LIKE '%" + keyword + "%'", conn);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            datagridViewEmployee.DataSource = dt;

        }

        private void ViewEmployee_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serviceCenterManagementDBDataSet.emp' table. You can move, or remove it, as needed.

            DataTable dt = emp.Select();
            datagridViewEmployee.DataSource = dt;

        }

        private void datagridViewEmployee_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employeeUpdate emp1 = new employeeUpdate();

            //get a data from data table

            int rowIndex = e.RowIndex;

            emp1.empId.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[0].Value.ToString();
            emp1.firstname.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[1].Value.ToString();
            emp1.lastname.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[2].Value.ToString();
            emp1.contactno.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[3].Value.ToString();
            emp1.homeContact.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[4].Value.ToString();
            emp1.address.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[5].Value.ToString();
            emp1.email.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[6].Value.ToString();
            emp1.nicnumber.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[7].Value.ToString();
            emp1.gender.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[8].Value.ToString();
            emp1.firstDate.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[9].Value.ToString();
            emp1.occupation.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[10].Value.ToString();
            emp1.empSalary.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[11].Value.ToString();
            emp1.combostatus.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[12].Value.ToString();
            emp1.workphone.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[13].Value.ToString();
            emp1.emeName.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[14].Value.ToString();
            emp1.emeRelationship.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[15].Value.ToString();
            emp1.emeContactNo.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[16].Value.ToString();
            emp1.emeAddress.Text = this.datagridViewEmployee.Rows[rowIndex].Cells[17].Value.ToString();

            emp1.ShowDialog();
        }

        private void ViewEmployee_Activated(object sender, EventArgs e)
        {
            DataTable dt = emp.Select();
            datagridViewEmployee.DataSource = dt;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            EmployeeReport report = new EmployeeReport();
            report.Show();
            
        }
    }
}
