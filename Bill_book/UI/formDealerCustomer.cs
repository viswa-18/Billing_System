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
    public partial class formDealerCustomer : Form
    {
        public formDealerCustomer()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Code to close this form
            this.Hide();
        }

        DealerCustomerBLL dc = new DealerCustomerBLL();
        DealerCustomerDAL dcdal = new DealerCustomerDAL();
        userDAL udal = new userDAL();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Getting values from form
            dc.type = comboBoxType.Text;
            dc.name=textBoxName.Text;
            dc.contact=textBoxContact.Text;
            dc.address=textBoxAddress.Text;
            dc.date=DateTime.Now;

            //Getting ID from logged in user and pass its value
            string loggedUser = formlogin.loggedinName;
            userbll user=udal.GetIDFromUsername(loggedUser);
            dc.added_by = user.id;

            //Creating boolean variable to check whether dealer/customer added or not
            bool success = dcdal.Insert(dc);

            if (success == true) {
                MessageBox.Show("Dealer/Customer added successfully...");
                Clear();
                //Refresh Datagridview
                DataTable dt = dcdal.Select();
                dataGridViewDealerCustomer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Dealer/Customer details failed to add");
            }
        }
        public void Clear()
        {
            textBoxDealerCustID.Text = "";
            textBoxName.Text = "";
            textBoxContact.Text = "";
            textBoxAddress.Text = "";
            textBoxSearch.Text = "";
        }

        private void formDealerCustomer_Load(object sender, EventArgs e)
        {
            //Refresh Datagridview
            DataTable dt = dcdal.Select();
            dataGridViewDealerCustomer.DataSource = dt;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //Get the values from form
            dc.id = int.Parse(textBoxDealerCustID.Text);
            dc.type = comboBoxType.Text;
            dc.name=textBoxName.Text;
            dc.contact=textBoxContact.Text;
            dc.address=textBoxAddress.Text;
            dc.date=DateTime.Now;

            //Getting ID from logged in user and pass its value
            string loggedUser = formlogin.loggedinName;
            userbll user = udal.GetIDFromUsername(loggedUser);
            dc.added_by = user.id;

            //Creating boolean variable to check whether dealer/customer added or not
            bool success = dcdal.Update(dc);

            if (success == true)
            {
                MessageBox.Show("Dealer/Customer details updated successfully...");
                Clear();
                //Refresh Datagridview
                DataTable dt = dcdal.Select();
                dataGridViewDealerCustomer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Dealer/Customer details failed to update");
            }
        }

        private void dataGridViewDealerCustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Int variable to get identity of row clicked
            int rowIndex=e.RowIndex;

            textBoxDealerCustID.Text = dataGridViewDealerCustomer.Rows[rowIndex].Cells[0].Value.ToString();
            comboBoxType.Text = dataGridViewDealerCustomer.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxName.Text = dataGridViewDealerCustomer.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxContact.Text = dataGridViewDealerCustomer.Rows[rowIndex].Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewDealerCustomer.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Get the id to be deleted from form
            dc.id = int.Parse(textBoxDealerCustID.Text);

            //Create boolean variable to check whether dealer/customer is deleted or not
            bool success = dcdal.Delete(dc);
            if (success == true)
            {
                MessageBox.Show("Dealer/Customer deleted successfully");
                Clear();
                //Refresh Datagridview
                DataTable dt = dcdal.Select();
                dataGridViewDealerCustomer.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Dealer/Customer details failed to delete"); 
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from textbox
            string keyword=textBoxSearch.Text;

            if (keyword != null)
            {
                //Search the dealer/customer
                DataTable dt = dcdal.Search(keyword);
                dataGridViewDealerCustomer.DataSource=dt;
            }
            else
            {
                //Show all the dealer/customer
                DataTable dt = dcdal.Select();
                dataGridViewDealerCustomer.DataSource = dt;

            }
        }
    }
}
