using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RASAMOTORS.JobCard.common;

namespace RASAMOTORS.JobCard.jobCardClasses
{
    public class assignJobclass
    {

        //assign getters and setters
        public int Id { get; set; }

        public string vehicleNo { get; set; }

        public string jobOne { get; set; }

        public string jobTwo { get; set; }

        public string jobThree { get; set; }

        public float predictPrice { get; set; }

        public DateTime date { get; set; }

        public string jobStatus { get; set; }

        //static string mynewconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        static string mynewconnstring = @"Data Source=CHARMINPC\SQLEXPRESS;Initial Catalog=ServiceCenter;Integrated Security=True";

        //selecting Data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(mynewconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Writing Sql Querry
                string sql = "SELECT Id as 'Job Id',vehicleNo as 'Vehicle No',jobOne  as 'Job',jobTwo as 'Job',jobThree as 'Job',predictPrice as 'Price Prdicted',jobStatus as 'Status',date as 'Date Of Entry' FROM jobPred";
                //creating cmd using sql and comm
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating  SQL Database using
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data Into DataBAse
        public bool InsertJob(assignJobclass c)
        {
            bool IsSuccess = false;

            //step1:connect database
            SqlConnection conn = new SqlConnection(mynewconnstring);
            try
            {
                string sql = "INSERT INTO jobPred(vehicleNo, jobOne, jobTwo, jobThree, predictPrice,date)VALUES(@vehicleNo, @jobOne, @jobTwo, @jobThree, @predictPrice, @date)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@vehicleNo", c.Id);
                cmd.Parameters.AddWithValue("@jobOne", c.jobOne);
                cmd.Parameters.AddWithValue("@jobTwo", c.jobTwo);
                cmd.Parameters.AddWithValue("@jobThree", c.jobThree);
                cmd.Parameters.AddWithValue("@predictPrice", c.predictPrice);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);


                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }


            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return IsSuccess;
        }


        //Update Method 
        public bool Update(assignJobclass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(mynewconnstring);
            try
            {
                string sql = "UPDATE jobPred SET jobStatus=@jobStatus Where Id=@Id";

                //Creating SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Set Parameters
                cmd.Parameters.AddWithValue("@jobStatus", c.jobStatus);
                cmd.Parameters.AddWithValue("@Id", c.Id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return isSuccess;

        }

    }
}
