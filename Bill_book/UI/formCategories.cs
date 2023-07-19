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
    public partial class formCategories : Form
    {
        public formCategories()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        categoriesbll c = new categoriesbll();
        CategoriesDAL dal = new CategoriesDAL();
        userDAL udal = new userDAL();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Get the values from Category form
            c.title=textBoxTitle.Text;
            c.description=textBoxDescription.Text;
            c.date=DateTime.Now;

            //Getting ID in Added by field
            string loggedUser = formlogin.loggedinName;
            userbll user = udal.GetIDFromUsername(loggedUser);

            //Passing the id of Logged In User in added by field
            c.added_by = user.id;

            //Creating boolean method to insert data into database
            bool success = dal.Insert(c);

            if (success == true)
            {
                MessageBox.Show("New Category Inserted Successfully...");
                Clear();

                //Refresh DataGridView
                DataTable dt = dal.Select();
                dataGridViewCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed to Insert New Category");
            }
        }
        public void Clear()
        {
            textBoxCategoryID.Text = "";
            textBoxTitle.Text = "";
            textBoxDescription.Text = "";
            textBoxSearch.Text = "";
        }

        private void formCategories_Load(object sender, EventArgs e)
        {
            //To display all the categories in Data Grid View
            DataTable dt = dal.Select();
            dataGridViewCategories.DataSource = dt;
        }

        private void dataGridViewCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Finding the row index of Row Clicked on Data Grid View
            int RowIndex = e.RowIndex;
            textBoxCategoryID.Text = dataGridViewCategories.Rows[RowIndex].Cells[0].Value.ToString();
            textBoxTitle.Text = dataGridViewCategories.Rows[RowIndex].Cells[1].Value.ToString();
            textBoxDescription.Text=dataGridViewCategories.Rows[RowIndex].Cells[2].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Get the values from the Categoryform
            c.id = int.Parse(textBoxCategoryID.Text);
            c.title = textBoxTitle.Text;
            c.description = textBoxDescription.Text;
            c.date = DateTime.Now;

            //Getting ID in Added by field
            string loggedUser = formlogin.loggedinName;
            userbll user = udal.GetIDFromUsername(loggedUser);

            //Passing the id of Logged In User in added by field
            c.added_by = user.id;

            //Creating Boolean value to update categories
            bool success = dal.Update(c);
            if (success == true)
            {
                MessageBox.Show("Details Updated Successfully...");
                Clear();
                DataTable dt = dal.Select();
                dataGridViewCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Detail Failed to Update");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Get the ID to be deleted
            c.id = int.Parse(textBoxCategoryID.Text);

            //Creating boolean variable to delete the category
            bool success = dal.Delete(c);

            if(success == true)
            {
                MessageBox.Show("Category Deleted Successfully...");
                Clear();
                DataTable dt = dal.Select();
                dataGridViewCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Category failed to Delete");
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the keywords
            string keywords = textBoxSearch.Text;

            //Filter the categories based on keywords
            if (keywords != null)
            {
                //Use Search method to display category
                DataTable dt=dal.Search(keywords);
                dataGridViewCategories.DataSource=dt;
            }
            else
            {
                //Use Select method to display all categories
                DataTable dt = dal.Select();
                dataGridViewCategories.DataSource = dt;
            }
        }
    }
}
