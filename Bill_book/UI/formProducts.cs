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
    public partial class formProducts : Form
    {
        public formProducts()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        CategoriesDAL cdal = new CategoriesDAL();
        productBLL p = new productBLL();
        productsDAL pdal=new productsDAL();
        userDAL udal=new userDAL();
        private void formProducts_Load(object sender, EventArgs e)
        {
            //Creating datatable to hold categories from database
            DataTable categoriesdt = cdal.Select();
            //Specify Datasource for Category Combobox
            comboBoxCategory.DataSource = categoriesdt;
            //Specify Display member and value member for combobox
            comboBoxCategory.DisplayMember = "title";
            comboBoxCategory.ValueMember = "title";

            //Load all the products in Data Grid View
            DataTable dt=pdal.Select();
            dataGridViewProducts.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Get all the values from the form
            p.name=textBoxName.Text;
            p.category = comboBoxCategory.Text;
            p.weight=decimal.Parse(textBoxWeight.Text);
            p.rate=decimal.Parse(textBoxRate.Text);
            p.qty = 0;
            p.date=DateTime.Now;
            //Getting username of logged in user
            String loggedUser = formlogin.loggedinName;
            userbll user=udal.GetIDFromUsername(loggedUser);
            p.added_by = user.id;

            //Create boolean variable to check if the product is added successfully or not
            bool success = pdal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("Product added successfully...");
                Clear();
                //Refresh Datagrid view
                DataTable dt=pdal.Select();
                dataGridViewProducts.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Product failed to add");
            }
        }
        public void Clear()
        {
            textBoxProductID .Text= " ";
            textBoxName.Text = " ";
            textBoxWeight.Text = " ";
            textBoxRate.Text = " ";
            textBoxSearch.Text = "";
        }

        private void dataGridViewProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Create Integer variable to know which product was clicked
            int rowIndex = e.RowIndex;
            //Display the value on Respective /textboxes
            textBoxProductID.Text = dataGridViewProducts.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewProducts.Rows[rowIndex].Cells[1].Value.ToString();
            comboBoxCategory.Text = dataGridViewProducts.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxWeight.Text = dataGridViewProducts.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxRate.Text = dataGridViewProducts.Rows[rowIndex].Cells[4].Value.ToString();

            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Get the values from Product form
            p.id=int.Parse(textBoxProductID.Text);
            p.name=textBoxName.Text;
            p.category=comboBoxCategory.Text;
            p.weight=decimal.Parse(textBoxWeight.Text);
            p.rate=decimal.Parse(textBoxRate.Text);
            p.date=DateTime.Now;
            
            // Getting username of logged in user
            String loggedUser = formlogin.loggedinName;
            userbll user = udal.GetIDFromUsername(loggedUser);
            p.added_by = user.id;

            //Create a boolean variable if the product updated or not
            bool success=pdal.Update(p);
            if (success == true)
            {
                MessageBox.Show("Product Updated Successfully...");
                Clear();
                //Refresh Datagrid view
                DataTable dt = pdal.Select();
                dataGridViewProducts.DataSource = dt;
            }
            else
                MessageBox.Show("Failed to update product");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Get the ID to be deleted
            p.id = int.Parse(textBoxProductID.Text);

            //Create a bool variable to check product deleted or not
            bool success=pdal.Delete(p);
            if (success == true)
            {
                MessageBox.Show("Product Deleted Successfully...");
                Clear();
                //Refresh Datagrid view
                DataTable dt = pdal.Select();
                dataGridViewProducts.DataSource = dt;
            }
            else
                MessageBox.Show("Failed to delete product");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get keyword from form
            string keywords = textBoxSearch.Text;
            if (keywords != null)
            {
                //Search the product
                DataTable dt = pdal.Search(keywords);
                dataGridViewProducts.DataSource=dt;
            }
            else
            {
                //Display all the product
                DataTable dt = pdal.Select();
                dataGridViewProducts.DataSource = dt;
            }
        }
    }
}
