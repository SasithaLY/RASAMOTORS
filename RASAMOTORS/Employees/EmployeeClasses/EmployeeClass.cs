using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RASAMOTORS.Employees.EmployeeClasses
{
    class EmployeeClass
    {
        //create the getters and setters
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string HomeContactNo { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
        public string NICNo { get; set; }
        public string Gender { get; set; }
        public int EmployeeID { get; set; }
        public string DateOfFirstAppointment { get; set; }
        public string Occupation { get; set; }
        public double Salary { get; set; }
        public string Status { get; set; }
        public string WorkPhone { get; set; }
        public string Name { get; set; }
        public string EmeContactNo { get; set; }
        public string EmeAddress { get; set; }
        public string EmeRelationship { get; set; }


        string myconstring = Common.Utils.ConnectionString;

        //public string myconstring = GlobalVariable.ConnectionString;


        //select data from datatable
        public DataTable Select()
        {

            //database connection
            SqlConnection connec = new SqlConnection(myconstring);
            DataTable dt = new DataTable();
            try
            {
                //writing sql query
                string sql = "SELECT * FROM emp";

                SqlCommand cmd = new SqlCommand(sql, connec);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                connec.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {


            }
            finally
            {
                connec.Close();
            }
            return dt;
        }
        //inserting data into database
        public bool Insert(EmployeeClass e)
        {

            bool success = false;

            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                string sql = " INSERT INTO emp (FirstName, LastName, ContactNo, HomeContactNo, Address, EmailID, NICNo, Gender, DateOfFirstAppointment, Occupation, Salary, Status, WorkPhone, Name, Relationship, EmeContactNo, EmeAddress) VALUES(@FirstName, @LastName, @ContactNo, @HomeContactNo, @Address, @EmailID, @NICNo, @Gender, @DateOfFirstAppointment, @Occupation, @Salary, @Status, @WorkPhone, @Name, @Relationship, @EmeContactNo, @EmeAddress)";


                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
                cmd.Parameters.AddWithValue("@LastName", e.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", e.ContactNo);
                cmd.Parameters.AddWithValue("@HomeContactNo", e.HomeContactNo);
                cmd.Parameters.AddWithValue("@Address", e.Address);
                cmd.Parameters.AddWithValue("@EmailID", e.EmailID);
                cmd.Parameters.AddWithValue("@NICNo", e.NICNo);
                cmd.Parameters.AddWithValue("@Gender", e.Gender);
                cmd.Parameters.AddWithValue("@DateOfFirstAppointment", e.DateOfFirstAppointment);
                cmd.Parameters.AddWithValue("@Occupation", e.Occupation);
                cmd.Parameters.AddWithValue("@Salary", e.Salary);
                cmd.Parameters.AddWithValue("@Status", e.Status);
                cmd.Parameters.AddWithValue("@WorkPhone", e.WorkPhone);
                cmd.Parameters.AddWithValue("@Name", e.Name);
                cmd.Parameters.AddWithValue("@Relationship", e.EmeRelationship);
                cmd.Parameters.AddWithValue("@EmeContactNo", e.EmeContactNo);
                cmd.Parameters.AddWithValue("@EmeAddress", e.EmeAddress);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
                {
                    success = true;

                }
                else
                {
                    success = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return success;

        }
        //update data into database
        public bool Update(EmployeeClass e)
        {

            bool success = false;

            SqlConnection conn = new SqlConnection(myconstring);

            try
            {
                string sql = " UPDATE emp SET FirstName= '" + e.FirstName + "',LastName = '" + e.LastName + "',ContactNo = '" + e.ContactNo + "', HomeContactNo = '" + e.HomeContactNo + "',Address ='" + e.Address + "',EmailID = '" + e.EmailID + "',NICNo='" + e.NICNo + "',Gender='" + e.Gender + "',DateOfFirstAppointment ='" + e.DateOfFirstAppointment + "',Occupation='" + e.Occupation + "',Salary ='" + e.Salary + "',Status='" + e.Status + "',WorkPhone='" + e.WorkPhone + "',Name='" + e.Name + "',Relationship = '" + e.EmeRelationship + "',EmeContactNo = '" + e.EmeContactNo + "',EmeAddress = '" + e.EmeAddress + "' WHERE EmployeeID = '" + e.EmployeeID + "' ";

                SqlCommand cmd = new SqlCommand(sql, conn);


                // cmd.Parameters.AddWithValue("@FirstName", e.FirstName);
                //cmd.Parameters.AddWithValue("@LastName", e.LastName);
                //cmd.Parameters.AddWithValue("@ContactNo", e.ContactNo);
                //cmd.Parameters.AddWithValue("@HomeContactNo", e.HomeContactNo);
                //cmd.Parameters.AddWithValue("@Address", e.Address);
                //cmd.Parameters.AddWithValue("@EmailID", e.EmailID);
                //cmd.Parameters.AddWithValue("@NICNo", e.NICNo);
                //  cmd.Parameters.AddWithValue("@Gender", e.Gender);
                //cmd.Parameters.AddWithValue("@DateOfFirstAppointment", e.DateOfFirstAppointment);
                //cmd.Parameters.AddWithValue("@Occupation", e.Occupation);
                // cmd.Parameters.AddWithValue("@Salary", e.Salary);
                //cmd.Parameters.AddWithValue("@Status", e.Status);
                // cmd.Parameters.AddWithValue("@WorkPhone", e.WorkPhone);
                //cmd.Parameters.AddWithValue("@Name", e.Name);
                //cmd.Parameters.AddWithValue("@EmeAddress", e.EmeAddress);
                //  cmd.Parameters.AddWithValue("@EmeRelationship", e.EmeRelationship);
                //cmd.Parameters.AddWithValue("@EmeContactNo", e.EmeContactNo);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();


                if (rows > 0)
                {
                    success = true;

                }
                else
                {
                    success = false;
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


            return success;

        }
        //delete the data from the database
        public bool Delete(EmployeeClass e)
        {

            bool isSuccess = false;

            SqlConnection con = new SqlConnection(myconstring);

            try
            {
                string sql = "DELETE FROM emp WHERE EmployeeID = @EmployeeID";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@EmployeeID", e.EmployeeID);

                con.Open();

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
            catch (Exception ex) { }


            finally
            {
                con.Close();
            }

            return isSuccess;
        }
    }
}

    

