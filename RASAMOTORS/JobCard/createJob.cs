using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RASAMOTORS.JobCard.jobCardClasses;

namespace RASAMOTORS.JobCard
{
    public partial class createJob : Form
    {
        public createJob()
        {
            InitializeComponent();
        }


        jobCard c = new jobCard();
        string myconnstring = Common.Utils.ConnectionString;

        public Boolean validate()
        {
            Boolean val = false;
            try
            {


                if (txtName.Text == string.Empty || txtPrc.Text == string.Empty || txtDesc.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All the Fields!");
                    val = false;
                }
                else if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Please give a Valid Name!");
                    val = false;
                }
                else if (!Regex.IsMatch(txtPrc.Text, "^[0-9.9]+$"))
                {
                    MessageBox.Show("Please give a Valid price!");
                    val = false;
                }
                else
                {
                    val = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Validation Code Error");
            }
            return val;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    c.Name = txtName.Text;
                    c.Price = float.Parse(txtPrc.Text);
                    c.Description = txtDesc.Text;

                    SqlConnection sqlConnection = new SqlConnection(myconnstring);

                    sqlConnection.Open();
                    using (var sqlCommand = new SqlCommand("SELECT * FROM allJob  WHERE Name = '" + txtName.Text + "'", sqlConnection))
                    {

                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Job Already Exist!");

                        }
                        else
                        {

                            bool success = c.Insert(c);
                            if (success == true)
                            {
                                MessageBox.Show("Job Successfully Created!");
                                //clear();
                            }
                            else
                            {
                                MessageBox.Show("Job Creation Unsuccessful!");
                            }

                            DataTable dt = c.Select();
                            dgvallJobs.DataSource = dt;

                        }

                        reader.Close();
                        reader.Dispose();
                    }

                    sqlConnection.Close();
                }
                else
                {
                    MessageBox.Show("Insert Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createJob_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvallJobs.DataSource = dt;
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Get data from textbox
                c.Id = int.Parse(txtId.Text);
                c.Name = txtName.Text;
                c.Price = float.Parse(txtPrc.Text);
                c.Description = txtDesc.Text;


                //update in database
                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Successfully Updated!");
                    //Clear Fields
                    clear();
                    //update grid view
                    DataTable dt = c.Select();
                    dgvallJobs.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Update Unsuccessful!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvallJobs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from Grid view into Text Boxes
            //Identify the Row on which mouse is clicked
            int rowIndex = e.RowIndex;
            txtId.Text = dgvallJobs.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvallJobs.Rows[rowIndex].Cells[1].Value.ToString();
            txtPrc.Text = dgvallJobs.Rows[rowIndex].Cells[2].Value.ToString();
            txtDesc.Text = dgvallJobs.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void txtSrch_TextChanged(object sender, EventArgs e)
        {

            //Get the Value from text box
            string searchword = txtSrch.Text;

            SqlConnection conn = new SqlConnection(myconnstring);

            SqlDataAdapter cda = new SqlDataAdapter("Select * From allJob WHERE Name LIKE '%" + searchword + "%' OR Id LIKE '%" + searchword + "%'", conn);
            DataTable dt = new DataTable();
            cda.Fill(dt);
            dgvallJobs.DataSource = dt;

        }

        //method to clear fields
        public void clear()
        {
            txtName.Text = "";
            txtPrc.Text = "";
            txtDesc.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                c.Id = Convert.ToInt32(txtId.Text);


                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {

                    bool success = c.Delete(c);
                    if (success == true)
                    {
                        MessageBox.Show("Item Deleted Successfully!");

                    }
                    else
                    {
                        MessageBox.Show("Item Delete Failed!");
                    }

                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
