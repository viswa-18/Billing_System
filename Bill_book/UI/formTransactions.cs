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
    public partial class formTransactions : Form
    {
        public formTransactions()
        {
            InitializeComponent();
        }

        transactionDAL tdal = new transactionDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void formTransactions_Load(object sender, EventArgs e)
        {
            //Display all the transaction
            DataTable dt = tdal.DisplayAllTransaction();
            dataGridViewTransactions.DataSource = dt;
        }

        private void comboBoxTransactiontype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the value from combobox
            string type = comboBoxTransactiontype.Text;

            DataTable dt = tdal.DisplayTransactionByType(type);
            dataGridViewTransactions.DataSource= dt;
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            //Display all the transaction
            DataTable dt = tdal.DisplayAllTransaction();
            dataGridViewTransactions.DataSource = dt;
        }
    }
}
