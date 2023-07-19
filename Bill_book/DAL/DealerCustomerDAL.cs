using Bill_book.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_book.DAL
{
    class DealerCustomerDAL
    {
        //Static string method for Database connection
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
        #region SELECT Method for Dealer and Customer
        public DataTable Select()
        {
            //SQL Connection for Database connection
            SqlConnection con = new SqlConnection(myconnstrng);

            //Datatable to hold value from database
            DataTable dt = new DataTable();
            try
            {
                //Query to select all data from database
                string sql = "SELECT * FROM tbl_dealer_customer";

                //Creating SQL Command to execute query
                SqlCommand cmd = new SqlCommand(sql, con);

                //Creating SQL Data Adapter to store data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                con.Open();

                //Passing the value from SQL Data Adapter to Datatable
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion
        #region INSERT Method to add details for Dealer/Customer
        public bool Insert(DealerCustomerBLL dc)
        {
            //Create SQL Connection
            SqlConnection con=new SqlConnection(myconnstrng);

            //Create boolean value with its default value false
            bool isSuccess = false;
            try
            {
                //SQL Query to Insert Details of Dealer/Customer
                string sql = "INSERT INTO tbl_dealer_customer(type,name,contact,address,date,added_by) VALUES (@type,@name,@contact,@address,@date,@added_by)";

                //SQL Command to pass the value to query and execute
                SqlCommand cmd=new SqlCommand(sql, con);

                //Passing value using parameters
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@date", dc.date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);

                con.Open(); 

                //Check whether query executed or not
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion
        #region UPDATE Method for Dealer and Customer Module
        public bool Update(DealerCustomerBLL dc)
        {
            //SQL Connection for Database connection
            SqlConnection con=new SqlConnection(myconnstrng);

            //Create boolean variable with its default value false
            bool isSuccess = false;
            try
            {
                //SQL Query to update data in database
                string sql = "UPDATE tbl_dealer_customer SET type=@type,name=@name,contact=@contact,address=@address,date=@date,added_by=@added_by WHERE id=@id";

                //SQL Command to pass the value
                SqlCommand cmd = new SqlCommand(sql, con);

                //Passing values through parameters
                cmd.Parameters.AddWithValue("@type",dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@date", dc.date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);

                con.Open();

                //Int variable to check if query executed successfully or not
                int rows=cmd.ExecuteNonQuery();

                if(rows > 0)
                    isSuccess = true;
                else
                    isSuccess = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }

            return isSuccess;
        }
        #endregion
        #region DELETE Method for Dealer and Customer Module
        public bool Delete(DealerCustomerBLL dc)
        {
            //SQL Connection for Database
            SqlConnection con=new SqlConnection(myconnstrng);

            //Create boolean variable with its default value false
            bool isSuccess = false;
            try
            {
                //SQL Query to Delete data from database
                string sql = "DELETE FROM tbl_dealer_customer WHERE id=@id";

                //SQL Command to pass the value
                SqlCommand cmd=new SqlCommand(sql, con);
                //Passing the value
                cmd.Parameters.AddWithValue("@id", dc.id);

                con.Open();

                //Create integer variable to check query executed successfully or not
                int rows=cmd.ExecuteNonQuery();

                if(rows>0)
                    isSuccess=true;
                else
                    isSuccess=false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion
        #region SEARCH Method for Dealer and Customer Module
        public DataTable Search(string keyword)
        {
            //Create SQL Connection
            SqlConnection con = new SqlConnection(myconnstrng);

            //Creating Datatable and returning its value
            DataTable dt = new DataTable();

            try
            {
                //Query to Search Dealer/Customer
                string sql = "SELECT * FROM tbl_dealer_customer WHERE id LIKE '%" + keyword + "%' OR type LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

                //SQL Command to execute query
                SqlCommand cmd= new SqlCommand(sql, con);

                //Sql data adapter to hold database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                con.Open();

                //Pass the value from adapter to datatable
                adapter.Fill(dt);

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion
        #region Method to Search Dealer/Customer for Transaction Module
        public DealerCustomerBLL SearchDealerCustomerForTransaction(string keyword)
        {
            //Create object for DealerCustomer BLL class
            DealerCustomerBLL dc = new DealerCustomerBLL();

            //Create Database connection
            SqlConnection con = new SqlConnection(myconnstrng);

            //Create Datatable to hold value temporarily
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to Search Dealer/Customer
                string sql = "SELECT name,contact,address FROM tbl_dealer_customer WHERE id LIKE '%" + keyword + "%' OR NAME LIKE '%" + keyword + "%'";

                //SQL Data Adapter to execute query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                con.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
            return dc;
        }
        #endregion
        #region Method to get ID of Dealer/Customer based on name
        public DealerCustomerBLL GetDeaCustIDFromName(string Name)
        {
            //Create an object of DeaCustBLL and return it
            DealerCustomerBLL dc = new DealerCustomerBLL();

            //SQL Connection
            SqlConnection con = new SqlConnection(myconnstrng);
            //Data Table to hold data temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Qurey to get ID based on name
                string sql = "SELECT id FROM tbl_dealer_customer WHERE name='" + Name + "'";
                //SQL Data Adapter to execute query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Pass the value from dt to DeaCustBLL dc
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { con.Close(); }
            return dc;
        }
            #endregion
    }
}
