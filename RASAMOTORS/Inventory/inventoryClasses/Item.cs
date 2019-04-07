using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RASAMOTORS.Inventory.inventoryClasses
{
    class Item
    {
        //getters and setters
        public int itemID { get; set; }
        public string itemName { get; set; }
        public string itemType { get; set; }
        public double buyingPrice { get; set; }
        public double sellingPrice { get; set; }
        public int quantity { get; set; }
        public string supplier { get; set; }



        //static string connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        string connString = Common.Utils.ConnectionString;



        //getting data from database
        public DataTable select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(connString);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT itemID as 'Item ID', itemName as 'Item Name', itemType as 'Item Type', buyingPrice as 'Buying Price', sellingPrice as 'Selling Price', availableQty as 'Available Qty', soldQty as 'Sold Qty', addedDate as 'Added Date & Time', supplier as 'Supplier'  FROM inventory";

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

        //Insert data to database
        public Boolean Insert(Item i)
        {
            //defalt return value
            Boolean isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //sql query
                string sql = "INSERT INTO inventory (itemName, itemType, buyingPrice, sellingPrice, availableQty, addedDate, supplier) VALUES(@itemName, @itemType, @buyingPrice, @sellingPrice, @availableQty, @addedDate, @supplier)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //parameters to add data
                cmd.Parameters.AddWithValue("@itemName", i.itemName);
                cmd.Parameters.AddWithValue("@itemType", i.itemType);
                cmd.Parameters.AddWithValue("@buyingPrice", i.buyingPrice);
                cmd.Parameters.AddWithValue("@sellingPrice", i.sellingPrice);
                cmd.Parameters.AddWithValue("@availableQty", i.quantity);
                cmd.Parameters.AddWithValue("@addedDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@supplier", i.supplier);

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
        public Boolean Update(Item i)
        {
            //default return value
            Boolean isSuccess = false;

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //query to update data
                string sql = "UPDATE inventory SET itemName = @itemName, itemType = @itemType, buyingPrice = @buyingPrice, sellingPrice = @sellingPrice, availableQty = @availableQty, supplier = @supplier WHERE itemID = @itemID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@itemName", i.itemName);
                cmd.Parameters.AddWithValue("@itemType", i.itemType);
                cmd.Parameters.AddWithValue("@buyingPrice", i.buyingPrice);
                cmd.Parameters.AddWithValue("@sellingPrice", i.sellingPrice);
                cmd.Parameters.AddWithValue("@availableQty", i.quantity);
                cmd.Parameters.AddWithValue("@supplier", i.supplier);
                cmd.Parameters.AddWithValue("@itemID", i.itemID);

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

        //delete data from database
        public Boolean Delete(Item i)
        {
            //default return value
            Boolean isSuccess = false;

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //sql query to delete data

                string sql = "DELETE FROM inventory WHERE itemID = @itemID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@itemID", i.itemID);

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

        public Boolean validate()
        {
            Boolean isSuccess = false;

            try
            {
                if (itemName == null || itemType == null || quantity.Equals(null) || buyingPrice.Equals(null) || sellingPrice.Equals(null) || supplier == null)
                {
                    isSuccess = false;
                }
                else
                {
                    isSuccess = true;
                }


            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return isSuccess;
        }
    }
}
