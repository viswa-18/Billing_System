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
    public partial class formUsers : Form
    {
        public formUsers()
        {
            InitializeComponent();
        }

        userbll u = new userbll();
        userDAL dal = new userDAL();
        private void labeltop_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Getting data from UI
            u.username=textBoxUsername.Text;
            u.password = textBoxPassword.Text;
            u.date=DateTime.Now;

            //Getting Username of the logged in user
            string loggedUser = formlogin.loggedinName;
            userbll usr= dal.GetIDFromUsername(loggedUser);
            u.added_by = usr.id;


            //Inserting Data into Database
            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("User successfully created");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add new user");
            }
        }
        private void clear()
        {
            textBoxUserID.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
