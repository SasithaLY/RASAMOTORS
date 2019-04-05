using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASAMOTORS.Supplier.ordersClass
{
    class orderClass
    {

        //Getters and  setters
        public int orderID { get; set; }
        public string supplierName { get; set; }
        public string orderDate { get; set; }
        public string inventoryType { get; set; }
        public string amount { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Data from DataBase

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();



            try
            {
                //Writing a query
                string sql = "SELECT * FROM orderDetails";
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

        public bool Insert(orderClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Sql query to insert data

                string sql = "INSERT INTO  orderDetails(supplierName, orderDate, inventoryType, amount) VALUES(@supplierName, @orderDate, @inventoryType, @amount)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //parameters to add data

                cmd.Parameters.AddWithValue("@supplierName", c.supplierName);
                cmd.Parameters.AddWithValue("@orderDate", c.orderDate);
                cmd.Parameters.AddWithValue("@inventoryType", c.inventoryType);
                cmd.Parameters.AddWithValue("@amount", c.amount);

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

        public bool Update(orderClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE orderDetails SET supplierName = '" + c.supplierName + "', orderDate = '" + c.orderDate + "', inventoryType = '" + c.inventoryType + "', amount = '" + c.amount + "' WHERE orderID = '" + c.orderID + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@supplierName", c.supplierName);
                //cmd.Parameters.AddWithValue("@orderDate", c.orderDate);
                //cmd.Parameters.AddWithValue("@inventoryType", c.inventoryType);
                //cmd.Parameters.AddWithValue("@amount", c.amount);
                //cmd.Parameters.AddWithValue("@orderID", c.orderID);

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

        //Delete data

        public bool Delete(orderClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Delete data

                string sql = "DELETE FROM orderDetails WHERE orderID = @orderID";


                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@orderID", c.orderID);

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
    }
}
