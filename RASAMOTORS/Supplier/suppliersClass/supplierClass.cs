using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASAMOTORS.Suppliers.suppliersClass
{
    public class supplierClass
    {
        //Getters and  setters
        public int supplierID { get; set; }
        public string supplierNIC { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string contactNumber { get; set; }
        public string supDate { get; set; }
        public string email { get; set; }
        public string companyName { get; set; }
        public string gender { get; set; }


        //static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        static string myconnstring = @"Data Source=DESKTOP-5MEEE4B\SQLEXPRESS;Initial Catalog=rasaMotors;Integrated Security=True";

        //Select Data from DataBase

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();



            try
            {
                //Writing a query
                string sql = "SELECT * FROM supplierDetails";
                SqlCommand cmd = new SqlCommand(sql, conn);
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

        //Inserting Data

        public bool Insert(supplierClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Sql query to insert data

                string sql = "INSERT INTO  supplierDetails(supplierNIC, firstName, lastName, contactNumber, supDate, email, companyName, gender) VALUES(@supplierNIC, @firstName, @lastName, @contactNumber, @supDate, @email, @companyName, @gender)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //parameters to add data

                cmd.Parameters.AddWithValue("@supplierNIC", c.supplierNIC);
                cmd.Parameters.AddWithValue("@firstName", c.firstName);
                cmd.Parameters.AddWithValue("@lastName", c.lastName);
                cmd.Parameters.AddWithValue("@contactNumber", c.contactNumber);
                cmd.Parameters.AddWithValue("@supDate", c.supDate);
                cmd.Parameters.AddWithValue("@email", c.email);
                cmd.Parameters.AddWithValue("@companyName", c.companyName);
                cmd.Parameters.AddWithValue("@gender", c.gender);

                //open dataBase connection
                conn.Open();

                //check rows greater than zero else will be 0
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

        //Update data

        public bool Update(supplierClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE supplierDetails SET supplierNIC = '" + c.supplierNIC + "', firstName = '" + c.firstName + "', lastName = '" + c.lastName + "', contactNumber = '" + c.contactNumber + "', supDate = '" + c.supDate + "', email = '" + c.email + "', companyName = '" + c.companyName + "', gender = '" + c.gender + "' WHERE supplierID = '" + c.supplierID + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@supplierNIC", c.supplierNIC);
                //cmd.Parameters.AddWithValue("@firstName", c.firstName);
                //cmd.Parameters.AddWithValue("@lastName", c.lastName);
                //cmd.Parameters.AddWithValue("@contactNumber", c.contactNumber);
                //cmd.Parameters.AddWithValue("@email", c.email);
                //cmd.Parameters.AddWithValue("@companyName", c.companyName);
                //cmd.Parameters.AddWithValue("@gender", c.gender);
                //cmd.Parameters.AddWithValue("@supplierID", c.supplierID);


                conn.Open();

                //check rows greater than zero else will be 0
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

        //Delete data

        public bool Delete(supplierClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Delete data

                string sql = "DELETE FROM supplierDetails WHERE supplierID = @supplierID";


                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@supplierID", c.supplierID);

                conn.Open();


                //check rows greater than zero else will be 0
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
