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
    }
}
