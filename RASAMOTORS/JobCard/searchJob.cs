using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RASAMOTORS.JobCard.jobCardClasses;

namespace RASAMOTORS.JobCard
{
    public partial class searchJob : Form
    {
        public searchJob()
        {
            InitializeComponent();
        }

        assignJobclass c = new assignJobclass();

        string myconnstring = Common.Utils.ConnectionString;

        private void searchJob_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvAllJobs.DataSource = dt;
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the Value from text box
            string searchword = txtSearch.Text;


            SqlConnection conn = new SqlConnection(myconnstring);

            SqlDataAdapter cda = new SqlDataAdapter("Select * From jobPred WHERE jobOne LIKE '%" + searchword + "%' OR Id LIKE '%" + searchword + "%'", conn);
            DataTable dt = new DataTable();
            cda.Fill(dt);
            dgvAllJobs.DataSource = dt;
        }

        private void btnBHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            DataTable dt = c.Select();
            dgvAllJobs.DataSource = dt;
        }

        private void dgvAllJobs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                updateStatus us = new updateStatus();
                us.txtUJid.Text = this.dgvAllJobs.CurrentRow.Cells[0].Value.ToString();
                us.txtUVhcl.Text = this.dgvAllJobs.CurrentRow.Cells[1].Value.ToString();
                us.txtUJone.Text = this.dgvAllJobs.CurrentRow.Cells[2].Value.ToString();
                us.txtUJTwo.Text = this.dgvAllJobs.CurrentRow.Cells[3].Value.ToString();
                us.txtUJThree.Text = this.dgvAllJobs.CurrentRow.Cells[4].Value.ToString();
                us.txtUPrc.Text = this.dgvAllJobs.CurrentRow.Cells[5].Value.ToString();
                us.cmbStatus.Text = this.dgvAllJobs.CurrentRow.Cells[6].Value.ToString();
                us.txtDate.Text = this.dgvAllJobs.CurrentRow.Cells[7].Value.ToString();
                us.ShowDialog();
                this.Close();
        }


        private void btnNJob_Click(object sender, EventArgs e)
        {
            new assignJob().Show();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new Report().Show();
        }
    }
}
