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
    class transactionDAL
    {
        //Create connection using string variable
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region METHOD TO INSERT TRANSACTION
        public bool Insert_Transaction(transactionsBLL t,out int transactionID)
        {
            //Create a boolean value with default value false
            bool isSuccess = false;
            //Set tje out transactionID to -1
            transactionID = -1;
            //Create SQL Connection
            SqlConnection con=new SqlConnection(myconnstrng);
            try
            {
                //SQL Query to insert transactions
                string sql = "INSERT INTO tbl_transactions(type,dealer_customer_id,total,transaction_date,tax,discount,added_by) VALUES (@type,@dealer_customer_id,@total,@transaction_date,@tax,@discount,@added_by); SELECT @@IDENTITY;";

                //SQL Command to pass the value in SQL Query
                SqlCommand cmd = new SqlCommand(sql, con);

                //Passing the value to SQL Query using cmd
                cmd.Parameters.AddWithValue("@type", t.type);
                cmd.Parameters.AddWithValue("@dealer_customer_id", t.dealer_customer_id);
                cmd.Parameters.AddWithValue("@total", t.total);
                cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
                cmd.Parameters.AddWithValue("@tax", t.tax);
                cmd.Parameters.AddWithValue("@discount", t.discount);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

                con.Open();
                //Execute the query
                object o = cmd.ExecuteScalar();
                //If query executed successfully
                if(o!= null)
                {
                    transactionID = int.Parse(o.ToString());
                    isSuccess = true;
                }
                //Query not executed successfully
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
        #region METHOD TO DISPLAY ALL TRANSACTION
        public DataTable DisplayAllTransaction()
        {
            //SQl Connection
            SqlConnection con = new SqlConnection(myconnstrng);

            //Create Datatable to hold data from database temporarily
            DataTable dt = new DataTable();
            try
            {
                //Sql Query to display all transaction
                string sql = "SELECT * FROM tbl_transactions";

                //SQL Command to execute query
                SqlCommand cmd = new SqlCommand(sql, con);

                //SQL Data Adapter to hold data from database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                con.Open();

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
        #region METHOD TO DISPLAY TRANSACTION BASED ON TRANSACTION TYPE
        public DataTable DisplayTransactionByType(string type)
        {
            //SQL Connection
            SqlConnection con=new SqlConnection(myconnstrng);

            //Create Datatable
            DataTable dt = new DataTable();

            try
            {
                //SQL Query
                string sql = "SELECT * FROM tbl_transactions WHERE type='" + type + "'";

                //SQL Command to execute query
                SqlCommand cmd=new SqlCommand(sql, con);

                //SQL DataAdapter to hold data from database
                SqlDataAdapter adapter=new SqlDataAdapter(cmd);

                con.Open();
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
