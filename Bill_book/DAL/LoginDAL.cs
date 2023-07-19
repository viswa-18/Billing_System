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
    class LoginDAL
    {
        //Static String to Connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public bool loginCheck(LoginBLL l)
        {
            //Create a boolean variable and set its value and return it
            bool isSuccess = false;

            //Connecting to Database
            SqlConnection con = new SqlConnection(myconnstrng);
            try
            {
                //SQL Query to check login
                string sql = "SELECT * FROM tbl_users WHERE username=@username AND password=@password";

                //Creating SQL Command to pass value
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Open();

                //Checking the rows in DataTable
                if(dt.Rows.Count > 0)
                {
                    //Login Successful
                    isSuccess = true;
                }
                else
                {
                    //Login Fails
                    isSuccess=false;
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
    } 
}
