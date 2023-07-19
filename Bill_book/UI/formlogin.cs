using Bill_book.BLL;
using Bill_book.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_book.UI
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }

        LoginBLL l = new LoginBLL();
        LoginDAL dal = new LoginDAL();
        public static string loggedinName;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            l.username = textBoxUsername.Text.Trim();
            l.password= textBoxPassword.Text.Trim();

            //Checking the login credentials
            bool success=dal.loginCheck(l);
            if (success == true)
            {
                MessageBox.Show("Login Successful");
                loggedinName = l.username;
                frmAdminDashboard admin=new frmAdminDashboard();
                admin.Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed.Try again");
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            formUsers user=new formUsers();
            user.Show();
        }

        private void formlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
