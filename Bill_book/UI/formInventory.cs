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
    public partial class formInventory : Form
    {
        public formInventory()
        {
            InitializeComponent();
        }

        CategoriesDAL cdal = new CategoriesDAL(); 
        productsDAL pdal = new productsDAL();

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void formInventory_Load(object sender, EventArgs e)
        {
            //Display the category in combobox
            DataTable cdt = cdal.Select();
            comboBoxCategory.DataSource = cdt;

            //Give the value member and display member for combobox
            comboBoxCategory.DisplayMember = "title";
            comboBoxCategory.ValueMember = "title";

            //Display all the products in Datagrid view when the form is loaded
            DataTable pdt = pdal.Select();
            dataGridViewProducts.DataSource = pdt;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Display all the products based on selected category
            string category = comboBoxCategory.Text;

            DataTable dt = pdal.DisplayProductByCategory(category);
            dataGridViewProducts.DataSource= dt;
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            //Display all the products when this button is clicked
            DataTable dt = pdal.Select();
            dataGridViewProducts.DataSource = dt;
        }
    }
}
