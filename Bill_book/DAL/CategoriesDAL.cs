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
    class CategoriesDAL
    {
        //Static String Method for Database Connection String
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        
        #region Select Method
        public DataTable Select()
        {
            //Creating Database Connection
            SqlConnection con = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //Writing SQL Query to get all the data from Database
                string sql = "SELECT * FROM tbl_categories";

                SqlCommand cmd = new SqlCommand(sql,con) ;
                
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
        #region Insert New Category
        public bool Insert(categoriesbll c)
        {
            //Creating a boolean variable and set its default value to false
            bool isSuccess = false;

            //Connection to database
            SqlConnection con = new SqlConnection(myconnstrng);
            try
            {
                //Query to Add New Category
                string sql = "INSERT INTO tbl_categories(title,description,date,added_by) VALUES (@title,@description,@date,@added_by)";
                
                //Creating SQL Command to pass value in query
                SqlCommand cmd= new SqlCommand(sql,con);

                //Passing Values through parameters
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description",c.description);
                cmd.Parameters.AddWithValue("@date", c.date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);

                //Open database connection
                con.Open();

                //Creating int variable to execute query
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
        #region Update Method
        public bool Update(categoriesbll c)
        {
            //Creating boolean variable and set its default value to false
            bool isSuccess = false;

            //Creating SQL Connection
            SqlConnection con = new SqlConnection(myconnstrng);

            try
            {
                //Query to Update Category
                string sql = "UPDATE tbl_categories SET title=@title, description=@description, date=@date, added_by=@added_by WHERE id=@id";

                //SQL Command to pass the value on SQL Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //Passing value using cmd
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue ("@description", c.description);
                cmd.Parameters.AddWithValue("@date", c.date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);

                //Open Database connection
                con.Open();

                //Create Int variable to execute query
                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
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
            finally { 
                con.Close(); 
            }
            return isSuccess;
        }
        #endregion
        #region Delete Category
        public bool Delete(categoriesbll c)
        {
            //Create a boolean variable and set its value to false
            bool isSuccess = false;

            SqlConnection con = new SqlConnection(myconnstrng);

            try
            {
                //SQL Query to Delete from Database
                string sql = "DELETE FROM tbl_categories WHERE id=@id";

                //SQL Command to pass the value on SQL Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //Passing value using cmd
                cmd.Parameters.AddWithValue("@id", c.id);

                con.Open();
                
                //Create int variable to execute query
                int rows=cmd.ExecuteNonQuery();

                if( rows > 0)
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
            finally
            {
                con.Close();
            }
            return isSuccess;
        }

        #endregion
        #region Search Method
        public DataTable Search(string keywords)
        {
            //SQL Connection
            SqlConnection con = new SqlConnection(myconnstrng);

            //Creating Datatable to hold data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query to Search Categories from Database
                String sql = "SELECT * FROM tbl_categories WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' OR description LIKE '%" + keywords + "%'";

                //Creating SQL Command to Execute the query
                SqlCommand cmd= new SqlCommand(sql, con);

                //Getting data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open DatabaseConnection
                con.Open();

                //Passing values from adapter to Datatable dt
                adapter.Fill(dt);

                
            }
            catch(Exception ex)
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
    }
}
