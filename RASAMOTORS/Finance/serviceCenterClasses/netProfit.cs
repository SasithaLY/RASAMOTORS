using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASAMOTORS.Finance.serviceCenterClasses
{
    class netProfit
    {
        //getters setters act as data carriers in our database

        public float Income { get; set; }
        public float InvenSal { get; set; }
        public float Paint { get; set; }
        public float Oil { get; set; }
        public float Orders { get; set; }
        public float InvenPay { get; set; }
        public float Utility { get; set; }
        public float Salary { get; set; }
        public float Profit { get; set; }
        public int CustomerId { get; set; }


        public DateTime Date { get; set; }
        public DateTime date { get; set; }
        //public int RowIndex { get; internal set; }

        String myconnstring = Common.Utils.ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM tbl_Profit";
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

        public bool Insert(netProfit c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                String sql = "INSERT INTO tbl_Profit(Income,InvenSales,Paint,Oil,Orders,InvenPay,Utility,Salary,NetProfit,Date)VALUES(@Income,@InvenSal,@Paint,@Oil,@Orders,@InvenPay,@Utility,@Salary,@Profit,@date)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Income", c.Income);
                cmd.Parameters.AddWithValue("@InvenSal", c.InvenSal);
                cmd.Parameters.AddWithValue("@Paint", c.Paint);
                cmd.Parameters.AddWithValue("@Oil", c.Oil);
                cmd.Parameters.AddWithValue("@Orders", c.Orders);
                cmd.Parameters.AddWithValue("@InvenPay", c.InvenPay);
                cmd.Parameters.AddWithValue("@Utility", c.Utility);
                cmd.Parameters.AddWithValue("@Salary", c.Salary);
                cmd.Parameters.AddWithValue("@Profit", c.Profit);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);


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

        internal void Delete()
        {
            throw new NotImplementedException();
        }

        public bool Update(netProfit c)
        {
            //create default return type and set its to default value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to update data in our database
                String sql = "UPDATE tbl_Profit SET Income=@Income,InvenSales=@InvenSales,Paint=@Paint,Oil=@Oil,Orders=@Orders,InvenPay=@InvenPay,Utility=@Utility,Salary=@Salary,NetProfit=@NetProfit where CustomerId=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameters to add value
                cmd.Parameters.AddWithValue("@id", c.CustomerId);
                cmd.Parameters.AddWithValue("@Income", c.Income);
                cmd.Parameters.AddWithValue("@InvenSales", c.InvenSal);
                cmd.Parameters.AddWithValue("@Paint", c.Paint);
                cmd.Parameters.AddWithValue("@Oil", c.Oil);
                cmd.Parameters.AddWithValue("@Orders", c.Orders);
                cmd.Parameters.AddWithValue("@InvenPay", c.InvenPay);
                cmd.Parameters.AddWithValue("@Utility", c.Utility);
                cmd.Parameters.AddWithValue("@Salary", c.Salary);
                cmd.Parameters.AddWithValue("@NetProfit", c.Profit);

                //open database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfuly then the value of rows will be greater than zero else its value will be zero
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
        //method to delete data from database

        public bool Delete(netProfit c)
        {
            bool isSuccess = false;
            ////create default return type and set its to default value to false
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM tbl_Profit WHERE CustomerId=@customerId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@customerId", c.CustomerId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query run sucessfully then the value of rows is greater than zero else its value is zero

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
