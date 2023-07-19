using Bill_book.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_book
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }
        //Set a public static method to specify whether form is Sales or Purchase
        public static string transactionType;
       private void frmAdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Appnamelabel_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsers user = new formUsers();
            user.Show();
        }

        private void frmAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            formlogin login = new formlogin();
            login.Show();
            this.Hide();
        }

        private void frmAdminDashboard_Load_1(object sender, EventArgs e)
        {
            label1loggedUser.Text = formlogin.loggedinName;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCategories categories = new formCategories();
            categories.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProducts products = new formProducts();
            products.Show();
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDealerCustomer dealcust = new formDealerCustomer();
            dealcust.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInventory inventory = new formInventory();
            inventory.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTransactions transaction=new formTransactions();
            transaction.Show();

        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set value on transaction type static method
            transactionType = "Purchase";
            formPurchaseAndSales purchase = new formPurchaseAndSales();
            purchase.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transactionType = "Sales";
            formPurchaseAndSales sales = new formPurchaseAndSales();
            sales.Show();
        }
    }
}
