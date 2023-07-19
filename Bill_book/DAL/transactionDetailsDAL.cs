using Bill_book.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_book.DAL
{
    class transactionDetailsDAL
    {
        //Create connection string
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Insert Method for transaction Detail
        public bool InsertTransactionDetail(transactionDetailBLL td)
        {
            //Create boolean value with default value false
            bool isSuccess = false;
            //Create Database connection
            SqlConnection con = new SqlConnection(myconnstrng);
            try
            {
                //SQL Query to insert Transaction details
                string sql = " INSERT INTO tbl_transaction_detail(product_id,rate,qty,total,dealer_customer_id,date,added_by) VALUES (@product_id,@rate,@qty,@total,@dealer_customer_id,@date,@added_by)";

                //Passing the value in SQL Query
                SqlCommand cmd=new SqlCommand(sql, con);
                //Passing values using cmd
                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@rate", td.rate);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@dealer_customer_id", td.dealer_customer_id);
                cmd.Parameters.AddWithValue("@date", td.date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);

                con.Open();
                int rows=cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess=false;
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
    }
}
