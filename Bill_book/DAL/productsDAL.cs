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
    class productsDAL
    {
        //Creating static string method for Database connection
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select method for product module
        public DataTable Select()
        {
            //Create SQL Connection to connect database
            SqlConnection con = new SqlConnection(myconnstrng);

            //Datatable to hold the data from database
            DataTable dt = new DataTable();

            try
            {
                //Query to Select all products from database
                String sql = "SELECT * FROM tbl_product";

                //SQL Command to execute query
                SqlCommand cmd = new SqlCommand(sql, con);

                //SQL Data Adapter to hold value from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                con.Open();

                //Adding the value from adapter to Datatable
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
        #region Method to Insert Product in Database
        public bool Insert(productBLL p)
        {
            //Create boolean variable and set its default value to false
            bool isSuccess = false;

            //Sql Connection for Database
            SqlConnection con = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to insert product into Database
                String sql = "INSERT INTO tbl_product(name,category,weight,rate,qty,date,added_by) VALUES (@name,@category,@weight,@rate,@qty,@date,@added_by)";

                //SQL Command to pass the values 
                SqlCommand cmd = new SqlCommand(sql, con);

                //Passing values through parameters
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@weight", p.weight);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@date", p.date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

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
            catch (Exception ex)
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
        #region Method to Update Product in Database
        public bool Update(productBLL p)
        {
            //Create boolean variable with its default value false
            bool isSuccess = false;

            //Create SQL Connection for Database
            SqlConnection con = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Update Data in Database
                String sql = "UPDATE tbl_product SET name=@name,category=@category,weight=@weight,rate=@rate,qty=@qty,date=@date,added_by=@added_by WHERE id=@id";
                
                //SQL Command to pass value to query
                SqlCommand cmd=new SqlCommand(sql, con);

                //Passing values using parameters and cmd
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@weight",p.weight);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@date", p.date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);

                con.Open();

                int rows= cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess=true;
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
            finally { 
                con.Close(); 
            }
            return isSuccess;
        }
        #endregion
        #region Method to Delete Product from Database
        public bool Delete(productBLL p)
        {
            //Create boolean variable with default value false
            bool isSuccess = false;

            //SQL Connection for Database
            SqlConnection con = new SqlConnection(myconnstrng);

            try
            {
                //Query to Delete Product from Database
                String sql = "DELETE FROM tbl_product WHERE id=@id";

                //SQL Command to Pass the value
                SqlCommand cmd = new SqlCommand(sql, con);

                //Passing value using cmd
                cmd.Parameters.AddWithValue("@id", p.id);

                con.Open();

                int rows=cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess=true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
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
        #region Method to Search Product from Database
        public DataTable Search(string keywords)
        {
            //SQL Connection for Database connection
            SqlConnection con = new SqlConnection(myconnstrng);
            //Creating Datatable to hold value from database
            DataTable dt = new DataTable();
            try
            {
                //SQL Query to search product
                String sql = "SELECT * FROM tbl_product WHERE id LIKE '%" + keywords + "%' OR NAME LIKE '%" + keywords + "%' OR category LIKE '%" + keywords + "%'";
                //SQL Command to execute query
                SqlCommand cmd = new SqlCommand(sql,con);
                //SQL Data Adapter to hold the data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                con.Open();

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
        #region DISPLAY PRODUCTS BASED ON CATEGORY
        public DataTable DisplayProductByCategory(string category)
        {
            //SQL Connection
            SqlConnection con=new SqlConnection(myconnstrng);

            DataTable dt=new DataTable();

            try
            {
                //SQL Query to Display product based on category
                string sql = "SELECT * FROM tbl_product WHERE category='" + category + "'";
                
                //SQL Command to execute thsi query
                SqlCommand cmd=new SqlCommand(sql,con);
                
                //SQL Data Adapter to hold data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                con.Open();

                //Pass value to datatable
                adapter.Fill(dt);
            }
            catch( Exception e)
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
        #region METHOD TO SEARCH PRODUCT IN TRANSACTION MODULE
        public productBLL GetProductsForTransaction(string keyword)
        {
            //Create an object of productsBLL and return it
            productBLL p = new productBLL();
            //SQL Connection
            SqlConnection con = new SqlConnection(myconnstrng);
            //Datatable to store data temporarily
            DataTable dt = new DataTable();
            try
            { 
                //SQL Query to get details
                string sql = "SELECT name,rate,qty FROM tbl_product WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
                //Create SQl Data Adapter to execute query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                con.Open();
                //Pass the value from adapter to dt
                adapter.Fill(dt);

                //If we have any values on dt, then set the value to productBLL
                if (dt.Rows.Count > 0)
                {
                    p.name=dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { con.Close(); }
            return p;
        }
        #endregion
        #region METHOD TO GET PRODUCT ID BASED ON PRODUCT NAME
        public productBLL GetProductIDFromName(string ProductName)
        {
            //Create an object of DeaCustBLL and return it
            productBLL p = new productBLL();

            //SQL Connection
            SqlConnection con = new SqlConnection(myconnstrng);
            //Data Table to hold data temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Qurey to get ID based on name
                string sql = "SELECT id FROM tbl_product WHERE name='" + ProductName + "'";
                //SQL Data Adapter to execute query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //Pass the value from dt to DeaCustBLL dc
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { con.Close(); }
            return p;
        }
        #endregion
    }
}
