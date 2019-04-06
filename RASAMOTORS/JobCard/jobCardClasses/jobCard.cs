using RASAMOTORS.JobCard.common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RASAMOTORS.JobCard.jobCardClasses
{
    public class jobCard
    {
        //getter setter properties
        public int Id { get; set; }

        public String Name { get; set; }

        public float Price { get; set; }

        public String Description { get; set; }

        //static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        //static string myconnstring = @"Data Source=DESKTOP-T0HOCLV;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True";

        string myconnstring = Common.Utils.ConnectionString;

        //selecting Data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //Writing Sql Querry
                string sql = "SELECT * FROM allJob";
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
        public bool Insert(jobCard c)
        {
            bool IsSuccess = false;

            //step1:connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO allJob(Name, Price, Description)VALUES(@Name, @Price, @Description)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@Price", c.Price);
                cmd.Parameters.AddWithValue("@Description", c.Description);

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
        public bool Update(jobCard c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE allJob SET Name=@Name, Price=@Price, Description=@Description Where Id=@Id";

                //Creating SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Set Parameters
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@Price", c.Price);
                cmd.Parameters.AddWithValue("@Description", c.Description);

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

        //Method to Delete
        public bool Delete(jobCard c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM allJob where Id=@Id";

                SqlCommand cmd = new SqlCommand(sql, conn);
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

