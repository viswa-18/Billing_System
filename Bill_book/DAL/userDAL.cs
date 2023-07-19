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
    class userDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Data from Database
        public DataTable Select()
        {
            //Static method to connect Database
            SqlConnection con = new SqlConnection(myconnstrng);
            //To hold data from database
            DataTable dt=new DataTable();
            try
            {
                //SQL Query to get data from database
                String sql = "SELECT * FROM tbl_users";
                //Command to execute
                SqlCommand cmd=new SqlCommand(sql, con);
                //Getting data from database
                SqlDataAdapter adapter=new SqlDataAdapter(cmd);
                //Database Connection Open
                con.Open();
                //Fill data in datatable
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                //Closing connection
                con.Close();
            }
            //Return the value in datatable
            return dt;
        }
        #endregion
        #region Insert Data in Database
        public bool Insert(userbll u)
        {
            bool isSuccess=false;
            SqlConnection con = new SqlConnection(myconnstrng);
            try
            {
                String sql = "INSERT INTO tbl_users(username,password,date,added_by) VALUES(@username,@password,@date,@added_by)";
                SqlCommand cmd= new SqlCommand(sql, con);
               
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@date", u.date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                con.Open();
                int rows=cmd.ExecuteNonQuery();
                //If the query is executed successfully then the value to rows will be greater than 0 else it will be less than 0
                if(rows>0)
                {
                    //Query successful
                    isSuccess=true;
                }
                else
                {
                    //Query fail
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
        #region Update Data in Database
        public bool Update(userbll u)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE tbl_users SET username=@username,password=@password,date=@date,added_by=@added_by WHERE id=@id"; 
                SqlCommand cmd = new SqlCommand(sql,con);
                
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@date", u.date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@id", u.id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //Query Successful
                    isSuccess = true;
                }
                else
                {
                    //Query Fails
                    isSuccess=false;
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
            return isSuccess;
        }
        #endregion
        #region Delete Data in Database
        public bool Delete(userbll u)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM tbl_users WHERE id=@id";
                SqlCommand cmd=new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", u.id);
                con.Open();
                int rows=cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }
        #endregion
        #region Getting User ID from Username
        public userbll GetIDFromUsername(string username)
        {
            userbll u = new userbll();
            SqlConnection con = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id FROM tbl_users WHERE username='" + username + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                con.Open();

                adapter.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    u.id = int.Parse(dt.Rows[0]["id"].ToString());
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
            return u;
        }
        #endregion
    }
}
