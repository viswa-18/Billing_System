using Bill_book.BLL;
using Bill_book.DAL;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Bill_book.UI
{
    public partial class formPurchaseAndSales : Form
    {
        public formPurchaseAndSales()
        {
            InitializeComponent();
        }

        DealerCustomerDAL dcdal = new DealerCustomerDAL(); 
        productsDAL pdal=new productsDAL();
        DataTable transactionDT=new DataTable();
        userDAL uDAL=new userDAL();
        transactionDAL tDAL=new transactionDAL();
        transactionDetailsDAL tdDAL=new transactionDetailsDAL();
        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void formPurchaseAndSales_Load(object sender, EventArgs e)
        {
            //Get transaction type value from Admin Dashboard
            string type = frmAdminDashboard.transactionType;
            //Set the value on label 
            labeltop.Text = type;

            //Specify Columns for transaction Datatable
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from textbox
            string keyword = textBoxSearch.Text;
            if (keyword == "")
            {
                //Clear all textboxes
                textBoxName.Text = "";
                textBoxEMail.Text = "";
                textBoxContact.Text = "";
                textBoxAddress.Text = "";
                return;
            }
            else
            {
                //Return details based on keyword
                DealerCustomerBLL dc = dcdal.SearchDealerCustomerForTransaction(keyword);
                //Transfer value from DealerCustomerBLL to textboxes
                textBoxName.Text = dc.name;
               // textBoxEMail.Text = dc.email;
                textBoxContact.Text = dc.contact;
                textBoxAddress.Text = dc.address;

            }
        }

        private void textBoxProductSearch_TextChanged(object sender, EventArgs e)
        {
            //Get keyword from product Search Textbox
            string keyword=textBoxProductSearch.Text;

            //Check if we have value on Searchproduct or not
            if (keyword == "")
            {
                textBoxProductName.Text = "";
                textBoxInventory.Text = "";
                textBoxRate.Text = "";
                textBoxQty.Text = "";
                return;
            }
            //Search product and display on respective textboxes
            productBLL p=pdal.GetProductsForTransaction(keyword);
            //Set values on textboxes based on p object
            textBoxProductName.Text = p.name;
            textBoxInventory.Text = p.qty.ToString();
            textBoxRate.Text = p.rate.ToString(); 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
             //Get Product Name,Rate and Qty customer wants to buy
            string productName=textBoxProductName.Text;
            decimal rate=decimal.Parse(textBoxRate.Text);
            decimal qty=decimal.Parse(textBoxQty.Text);
            decimal total = rate * qty;

            //Display subtotal in textbox
            //Get the toal value from textbox
            decimal subTotal=decimal.Parse(textBoxSubtotal.Text);
            subTotal = subTotal + total;
             
            //Check whether product is selected or not
            if (productName == "")
            {
                //Display the message
                MessageBox.Show("Select the product first.Try Again");
            }
            else
            {
                //Add product to Data grid view
                 transactionDT.Rows.Add(productName, rate, qty,total);

                //Display in Data Grid View
                dataGridViewAddedProducts.DataSource = transactionDT;
                //Display subtotal
                textBoxSubtotal.Text = subTotal.ToString();
                //Clear textboxes
                textBoxProductSearch.Text = "";
                textBoxProductName.Text = "";
                textBoxInventory.Text = "";
                textBoxRate.Text = "";
                textBoxQty.Text = "";
            }
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            //Get the value from discount textbox
            string value=textBoxDiscount.Text;

            if (value == "")
            {
                //Display error message
                MessageBox.Show("Add Discount First");
            }
            else
            {
                //Get Discount in decimal value
                decimal subTotal=decimal.Parse(textBoxSubtotal.Text);
                decimal discount=decimal.Parse(textBoxDiscount.Text);

                //Calculate Grand total
                decimal grandTotal = ((100 - discount) / 100) * subTotal;
                //Display grandtotal
                textBoxGrandTotal.Text = grandTotal.ToString();
            }
        }

        private void textBoxVAT_TextChanged(object sender, EventArgs e)
        {
            //Check if grandtotal has value or not
            string check = textBoxGrandTotal.Text;
            if (check == "")
            {
                //Display error message
                MessageBox.Show("Calculate Discount and set grand total first");
            }
            else
            {
                string vatchk=textBoxVAT.Text;
                //Calculate VAT
                //Getting VAT%
                decimal previousgt=decimal.Parse(textBoxGrandTotal.Text);
                decimal vat=decimal.Parse(textBoxVAT.Text);
                if (vatchk != "") {
                    decimal grandTotalwithVAT = ((100 + vat) / 100) * previousgt;
                    //Display new grandtotal
                    textBoxGrandTotal.Text = grandTotalwithVAT.ToString();
                }
                else
                {
                    MessageBox.Show("Add VAT%");
                }
            }
        }

        private void textBoxPaidAmount_TextChanged(object sender, EventArgs e)
        {
            //Get value from textbox and grandtotal
            decimal grandtotal=decimal.Parse(textBoxGrandTotal.Text);
            decimal paidamt=decimal.Parse(textBoxPaidAmount.Text);
            decimal returnamount;
            if (paidamt > grandtotal)
            {
                 returnamount = paidamt - grandtotal;
            }
            else
            {
                 returnamount = 0;
            }
            //Display return amount
            textBoxReturnAmount.Text= returnamount.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Get the values from PurchaseSales form
            transactionsBLL transaction = new transactionsBLL();
            transaction.type = labeltop.Text;

            //Get ID of dealer/customer
            //Get name of dealer/customer
            string deacustName=textBoxName.Text;
            DealerCustomerBLL dc=dcdal.GetDeaCustIDFromName(deacustName);

            transaction.dealer_customer_id = dc.id;
            transaction.total = Math.Round(decimal.Parse(textBoxGrandTotal.Text),2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax=decimal.Parse(textBoxVAT.Text);
            transaction.discount=decimal.Parse(textBoxDiscount.Text);

            //Get the username of logged in user
            string username = formlogin.loggedinName;
            userbll u=uDAL.GetIDFromUsername(username);
            transaction.added_by = u.id;
            transaction.transactionDetails = transactionDT;

            //Create boolean variable with default value false
            bool success = false;
           
            //Insert Transaction and Transaction Details
            using(TransactionScope scope=new TransactionScope())
            {
                int transactionID = -1;
                //Create boolean value and insert transaction
                bool w = tDAL.Insert_Transaction(transaction,out transactionID);

                //Use for loop to insert transaction details
                for(int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    //Get all the details of product
                    transactionDetailBLL transactionDetail=new transactionDetailBLL();
                    //Get product name and convert it to ID
                    string ProductName=transactionDT.Rows[i][0].ToString();
                    productBLL p = pdal.GetProductIDFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate=decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty=decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()),2);
                    transactionDetail.dealer_customer_id = dc.id;
                    transactionDetail.date= DateTime.Now;
                    transactionDetail.added_by = u.id;

                    //Insert transaction details inside database
                    bool y=tdDAL.InsertTransactionDetail(transactionDetail);
                    success = w && y;
                }
                
                if (success == true)
                {
                    //Transaction completed
                    scope.Complete();
                    MessageBox.Show("Transaction Completed Successfully");
                   
                }
                else
                {
                    //Transaction Failed
                    MessageBox.Show("Transaction Failed");
                }
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //Create boolean variable with default value false
            bool success=false;
            //Code to print bill
         
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "\r\n\r\n\r\n SRI RAMA JEWELLERS \r\n";
            printer.SubTitle = "Dharmapuri \r\n Phone: \r\n\r\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Discount: " + textBoxDiscount.Text+"% \r\n"+"VAT: "+textBoxVAT.Text+"%\r\n"+"Grand Total:"+textBoxGrandTotal.Text;
            printer.FooterSpacing = 15;
            success=printer.PrintDataGridView(dataGridViewAddedProducts);

            if (success == true)
            {
                MessageBox.Show("Bill printed successfully");
                //Clear Data Grid View and clear textboxes
                dataGridViewAddedProducts.DataSource = null;
                dataGridViewAddedProducts.Rows.Clear();

                textBoxSearch.Text = "";
                textBoxName.Text = "";
                textBoxEMail.Text = "";
                textBoxContact.Text = "";
                textBoxAddress.Text = "";
                textBoxProductSearch.Text = "";
                textBoxInventory.Text = "0";
                textBoxRate.Text = "0";
                textBoxQty.Text = "0";
                textBoxSubtotal.Text = "0";
                textBoxDiscount.Text = "0";
                textBoxVAT.Text = "0";
                textBoxGrandTotal.Text = "0";
                textBoxPaidAmount.Text = "0";
                textBoxReturnAmount.Text = "0";
            }
            else
            {
                MessageBox.Show("Bill failed to print");

            }
        }
    }
}
