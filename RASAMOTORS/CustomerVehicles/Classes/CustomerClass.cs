using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASAMOTORS.CustomerVehicles
{
    class CustomerClass
    {
        //Getters and Setters

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public string Gender { get; set; }


        //conection string

        string connString = Common.Utils.ConnectionString;

        //selecting data from database

        public DataTable select()
        {
            SqlConnection conn = new SqlConnection(connString);

            DataTable dt = new DataTable();

            try
            {
                //sql query

                string sql = "SELECT CustomerId as 'Customer ID', Name as 'Customer Name', NIC as 'NIC Number', Address as 'Address', PhoneNumber as 'Phone Number', EMail as 'E-Mail', Gender as 'Gender', EntryDate as 'Added Date'  FROM CusDetails";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //inserting data into database

        public bool insert(CustomerClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                string sql = "INSERT INTO CusDetails (Name, NIC, Address, PhoneNumber, EMail, Gender, EntryDate) VALUES (@Name, @NIC, @Address, @PhoneNumber, @EMail, @Gender, @EntryDate)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@NIC", c.NIC);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", c.PhoneNumber);
                cmd.Parameters.AddWithValue("@EMail", c.EMail);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@EntryDate", DateTime.Now);

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
            catch (System.Data.SqlClient.SqlException sqlExceptione)
            {
                System.Windows.Forms.MessageBox.Show(sqlExceptione.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }

        //update data in database

        public bool update(CustomerClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                string sql = "UPDATE CusDetails SET Name='" + c.Name + "', NIC='" + c.NIC + "', Address='" + c.Address + "', PhoneNumber='" + c.PhoneNumber + "', EMail='" + c.EMail + "', Gender='" + c.Gender + "' WHERE CustomerID='" + c.CustomerID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

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
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool delete(CustomerClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                string sql = "DELETE FROM CusDetails WHERE CustomerID=@CustomerID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@CustomerID", c.CustomerID);

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
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        public bool deleteAll(CustomerClass c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                string sql = "DELETE FROM CusDetails WHERE CustomerID='" + c.CustomerID + "'";
                SqlCommand cmdc = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@CustomerID", c.CustomerID);

                string sqlv = "DELETE FROM VehDetails WHERE CustomerID='" + c.CustomerID + "'";
                SqlCommand cmdv = new SqlCommand(sqlv, conn);
                //cmd.Parameters.AddWithValue("@CustomerID", c.CustomerID);

                conn.Open();
                int rows = cmdc.ExecuteNonQuery();
                cmdv.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
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
