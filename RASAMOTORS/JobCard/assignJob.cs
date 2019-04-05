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
    public partial class assignJob : Form
    {
        public assignJob()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(@"Data Source=CHARMINPC\SQLEXPRESS;Initial Catalog=ServiceCenter;Integrated Security=True");

        public assignJobclass obj = new assignJobclass();

        public void fillcombo()
        {
            comboJone.Items.Clear();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from allJob";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboJone.Items.Add(dr["Name"].ToString());
                comboJtwo.Items.Add(dr["Name"].ToString());
                comboJthree.Items.Add(dr["Name"].ToString());

            }

            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new searchJob().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new createJob().Show();
            this.Close();
        }

        private void btnAsJb_Click(object sender, EventArgs e)
        {
            try
            {
               // obj.vehicleNo = txtVehicleNo.Text;
                obj.jobOne = comboJone.Text;
                obj.jobTwo = comboJtwo.Text;
                obj.jobThree = comboJthree.Text;
                obj.predictPrice = float.Parse(txtPdctPrc.Text);


                bool success = obj.InsertJob(obj);
                if (success == true)
                {
                    MessageBox.Show("Job Successfully Inserted!");
                    //clear();
                }
                else
                {
                    MessageBox.Show("Job Insert Unsuccessful!");
                }

                //DataTable dt = c.Select();
                //dgvallJobs.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void assignJob_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void comboJone_SelectedIndexChanged(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from allJob where Name='" + comboJone.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtJOnePrc.Text = dr["Price"].ToString();
            }

            con.Close();
        }

        private void comboJtwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from allJob where Name='" + comboJtwo.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtJTwoPrc.Text = dr["Price"].ToString();
            }

            con.Close();

        }

        private void comboJthree_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from allJob where Name='" + comboJthree.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtJThreePrc.Text = dr["Price"].ToString();
            }

            con.Close();
        }

        private void txtJOnePrc_TextChanged(object sender, EventArgs e)
        {
            if (comboJone.Text == "Full Service")
            {
                txtPdctPrc.Text = (float.Parse(txtJOnePrc.Text) + 0).ToString();
                MessageBox.Show("You have Selected Full Service No additional Jobs will Allowed!");
            }
            else
            {
                txtPdctPrc.Text = (float.Parse(txtJOnePrc.Text) + 0).ToString();
            }
        }

        private void txtJTwoPrc_TextChanged(object sender, EventArgs e)
        {
            if (comboJone.Text == comboJtwo.Text)
            {
                MessageBox.Show("You have choose the same Job!");
            }
            else
            {
                txtPdctPrc.Text = (float.Parse(txtJOnePrc.Text) + float.Parse(txtJTwoPrc.Text) + 0).ToString();
            }
        }

        private void txtJThreePrc_TextChanged(object sender, EventArgs e)
        {
            if (comboJone.Text == comboJtwo.Text || comboJone.Text == comboJthree.Text || comboJtwo.Text == comboJthree.Text)
            {
                MessageBox.Show("You have choose the same Job!");
            }
            else
            {
                txtPdctPrc.Text = (float.Parse(txtJOnePrc.Text) + float.Parse(txtJTwoPrc.Text) + float.Parse(txtJThreePrc.Text)).ToString();
            }
        }
    }
}
