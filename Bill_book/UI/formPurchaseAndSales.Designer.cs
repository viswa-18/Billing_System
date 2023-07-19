namespace Bill_book.UI
{
    partial class formPurchaseAndSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPurchaseAndSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labeltop = new System.Windows.Forms.Label();
            this.labelDealCustTitle = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelDealCust = new System.Windows.Forms.Panel();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.textBoxProductSearch = new System.Windows.Forms.TextBox();
            this.labelQty = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelProductSearch = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridViewAddedProducts = new System.Windows.Forms.DataGridView();
            this.labeldgvTitle = new System.Windows.Forms.Label();
            this.Panelcalculation = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxReturnAmount = new System.Windows.Forms.TextBox();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.textBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.textBoxVAT = new System.Windows.Forms.TextBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.labelReturnAmount = new System.Windows.Forms.Label();
            this.labelPaidAmount = new System.Windows.Forms.Label();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelVat = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCalctTitle = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panelDealCust.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedProducts)).BeginInit();
            this.Panelcalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.labeltop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1625, 47);
            this.panel1.TabIndex = 5;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1488, -3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(57, 47);
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // labeltop
            // 
            this.labeltop.AutoSize = true;
            this.labeltop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltop.Location = new System.Drawing.Point(708, 9);
            this.labeltop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltop.Name = "labeltop";
            this.labeltop.Size = new System.Drawing.Size(228, 28);
            this.labeltop.TabIndex = 1;
            this.labeltop.Text = "PURCHASE AND SALES";
            // 
            // labelDealCustTitle
            // 
            this.labelDealCustTitle.AutoSize = true;
            this.labelDealCustTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDealCustTitle.Location = new System.Drawing.Point(16, 11);
            this.labelDealCustTitle.Name = "labelDealCustTitle";
            this.labelDealCustTitle.Size = new System.Drawing.Size(239, 23);
            this.labelDealCustTitle.TabIndex = 0;
            this.labelDealCustTitle.Text = "Dealer and Customer Details";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(16, 46);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(61, 23);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(16, 88);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 23);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(397, 88);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(70, 23);
            this.labelContact.TabIndex = 7;
            this.labelContact.Text = "Contact";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(1233, 45);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(46, 23);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Date";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(397, 42);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 23);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // panelDealCust
            // 
            this.panelDealCust.Controls.Add(this.dateTimePickerDate);
            this.panelDealCust.Controls.Add(this.textBoxAddress);
            this.panelDealCust.Controls.Add(this.textBoxContact);
            this.panelDealCust.Controls.Add(this.textBoxEMail);
            this.panelDealCust.Controls.Add(this.textBoxName);
            this.panelDealCust.Controls.Add(this.textBoxSearch);
            this.panelDealCust.Controls.Add(this.labelDate);
            this.panelDealCust.Controls.Add(this.labelAddress);
            this.panelDealCust.Controls.Add(this.labelDealCustTitle);
            this.panelDealCust.Controls.Add(this.labelName);
            this.panelDealCust.Controls.Add(this.labelContact);
            this.panelDealCust.Controls.Add(this.labelEmail);
            this.panelDealCust.Controls.Add(this.labelSearch);
            this.panelDealCust.Location = new System.Drawing.Point(12, 64);
            this.panelDealCust.Name = "panelDealCust";
            this.panelDealCust.Size = new System.Drawing.Size(1583, 134);
            this.panelDealCust.TabIndex = 10;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Location = new System.Drawing.Point(1285, 42);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(199, 30);
            this.dateTimePickerDate.TabIndex = 14;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(874, 36);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(279, 79);
            this.textBoxAddress.TabIndex = 13;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContact.Location = new System.Drawing.Point(479, 88);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(223, 30);
            this.textBoxContact.TabIndex = 13;
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEMail.Location = new System.Drawing.Point(479, 39);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(223, 30);
            this.textBoxEMail.TabIndex = 13;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(93, 88);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(223, 30);
            this.textBoxName.TabIndex = 13;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(93, 43);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(223, 30);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(798, 39);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(70, 23);
            this.labelAddress.TabIndex = 11;
            this.labelAddress.Text = "Address";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.textBoxQty);
            this.panel2.Controls.Add(this.textBoxProductName);
            this.panel2.Controls.Add(this.textBoxInventory);
            this.panel2.Controls.Add(this.textBoxRate);
            this.panel2.Controls.Add(this.textBoxProductSearch);
            this.panel2.Controls.Add(this.labelQty);
            this.panel2.Controls.Add(this.labelRate);
            this.panel2.Controls.Add(this.labelProductName);
            this.panel2.Controls.Add(this.labelInventory);
            this.panel2.Controls.Add(this.labelProductSearch);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Location = new System.Drawing.Point(12, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1583, 83);
            this.panel2.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(1395, 29);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(138, 48);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxQty
            // 
            this.textBoxQty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQty.Location = new System.Drawing.Point(1193, 40);
            this.textBoxQty.Name = "textBoxQty";
            this.textBoxQty.Size = new System.Drawing.Size(151, 30);
            this.textBoxQty.TabIndex = 11;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(379, 40);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(175, 30);
            this.textBoxProductName.TabIndex = 10;
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInventory.Location = new System.Drawing.Point(687, 40);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(169, 30);
            this.textBoxInventory.TabIndex = 9;
            // 
            // textBoxRate
            // 
            this.textBoxRate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRate.Location = new System.Drawing.Point(942, 40);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(163, 30);
            this.textBoxRate.TabIndex = 8;
            // 
            // textBoxProductSearch
            // 
            this.textBoxProductSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductSearch.Location = new System.Drawing.Point(93, 40);
            this.textBoxProductSearch.Name = "textBoxProductSearch";
            this.textBoxProductSearch.Size = new System.Drawing.Size(178, 30);
            this.textBoxProductSearch.TabIndex = 7;
            this.textBoxProductSearch.TextChanged += new System.EventHandler(this.textBoxProductSearch_TextChanged);
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQty.Location = new System.Drawing.Point(1150, 43);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(37, 23);
            this.labelQty.TabIndex = 6;
            this.labelQty.Text = "Qty";
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRate.Location = new System.Drawing.Point(892, 43);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(44, 23);
            this.labelRate.TabIndex = 4;
            this.labelRate.Text = "Rate";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(317, 43);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(56, 23);
            this.labelProductName.TabIndex = 3;
            this.labelProductName.Text = "Name";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventory.Location = new System.Drawing.Point(599, 43);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(82, 23);
            this.labelInventory.TabIndex = 2;
            this.labelInventory.Text = "Inventory";
            // 
            // labelProductSearch
            // 
            this.labelProductSearch.AutoSize = true;
            this.labelProductSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductSearch.Location = new System.Drawing.Point(16, 43);
            this.labelProductSearch.Name = "labelProductSearch";
            this.labelProductSearch.Size = new System.Drawing.Size(61, 23);
            this.labelProductSearch.TabIndex = 1;
            this.labelProductSearch.Text = "Search";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(16, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(133, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Product Details";
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Controls.Add(this.dataGridViewAddedProducts);
            this.panelDataGridView.Controls.Add(this.labeldgvTitle);
            this.panelDataGridView.Location = new System.Drawing.Point(12, 335);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(747, 435);
            this.panelDataGridView.TabIndex = 12;
            // 
            // dataGridViewAddedProducts
            // 
            this.dataGridViewAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddedProducts.Location = new System.Drawing.Point(20, 52);
            this.dataGridViewAddedProducts.Name = "dataGridViewAddedProducts";
            this.dataGridViewAddedProducts.RowHeadersWidth = 51;
            this.dataGridViewAddedProducts.RowTemplate.Height = 24;
            this.dataGridViewAddedProducts.Size = new System.Drawing.Size(705, 366);
            this.dataGridViewAddedProducts.TabIndex = 1;
            // 
            // labeldgvTitle
            // 
            this.labeldgvTitle.AutoSize = true;
            this.labeldgvTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldgvTitle.Location = new System.Drawing.Point(16, 14);
            this.labeldgvTitle.Name = "labeldgvTitle";
            this.labeldgvTitle.Size = new System.Drawing.Size(139, 23);
            this.labeldgvTitle.TabIndex = 0;
            this.labeldgvTitle.Text = "Added Products";
            // 
            // Panelcalculation
            // 
            this.Panelcalculation.Controls.Add(this.buttonPrint);
            this.Panelcalculation.Controls.Add(this.buttonSave);
            this.Panelcalculation.Controls.Add(this.textBoxReturnAmount);
            this.Panelcalculation.Controls.Add(this.textBoxPaidAmount);
            this.Panelcalculation.Controls.Add(this.textBoxGrandTotal);
            this.Panelcalculation.Controls.Add(this.textBoxVAT);
            this.Panelcalculation.Controls.Add(this.textBoxDiscount);
            this.Panelcalculation.Controls.Add(this.textBoxSubtotal);
            this.Panelcalculation.Controls.Add(this.labelReturnAmount);
            this.Panelcalculation.Controls.Add(this.labelPaidAmount);
            this.Panelcalculation.Controls.Add(this.labelGrandTotal);
            this.Panelcalculation.Controls.Add(this.labelDiscount);
            this.Panelcalculation.Controls.Add(this.labelVat);
            this.Panelcalculation.Controls.Add(this.labelTotal);
            this.Panelcalculation.Controls.Add(this.labelCalctTitle);
            this.Panelcalculation.Location = new System.Drawing.Point(777, 335);
            this.Panelcalculation.Name = "Panelcalculation";
            this.Panelcalculation.Size = new System.Drawing.Size(818, 435);
            this.Panelcalculation.TabIndex = 13;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(213, 361);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(175, 57);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxReturnAmount
            // 
            this.textBoxReturnAmount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReturnAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.textBoxReturnAmount.Location = new System.Drawing.Point(205, 292);
            this.textBoxReturnAmount.Name = "textBoxReturnAmount";
            this.textBoxReturnAmount.ReadOnly = true;
            this.textBoxReturnAmount.Size = new System.Drawing.Size(494, 43);
            this.textBoxReturnAmount.TabIndex = 12;
            // 
            // textBoxPaidAmount
            // 
            this.textBoxPaidAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaidAmount.Location = new System.Drawing.Point(205, 247);
            this.textBoxPaidAmount.Name = "textBoxPaidAmount";
            this.textBoxPaidAmount.Size = new System.Drawing.Size(494, 30);
            this.textBoxPaidAmount.TabIndex = 11;
            this.textBoxPaidAmount.TextChanged += new System.EventHandler(this.textBoxPaidAmount_TextChanged);
            // 
            // textBoxGrandTotal
            // 
            this.textBoxGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrandTotal.Location = new System.Drawing.Point(205, 192);
            this.textBoxGrandTotal.Name = "textBoxGrandTotal";
            this.textBoxGrandTotal.ReadOnly = true;
            this.textBoxGrandTotal.Size = new System.Drawing.Size(494, 30);
            this.textBoxGrandTotal.TabIndex = 10;
            // 
            // textBoxVAT
            // 
            this.textBoxVAT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVAT.Location = new System.Drawing.Point(205, 146);
            this.textBoxVAT.Name = "textBoxVAT";
            this.textBoxVAT.Size = new System.Drawing.Size(494, 30);
            this.textBoxVAT.TabIndex = 9;
            this.textBoxVAT.TextChanged += new System.EventHandler(this.textBoxVAT_TextChanged);
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(205, 96);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(494, 30);
            this.textBoxDiscount.TabIndex = 8;
            this.textBoxDiscount.TextChanged += new System.EventHandler(this.textBoxDiscount_TextChanged);
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubtotal.Location = new System.Drawing.Point(205, 45);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(494, 30);
            this.textBoxSubtotal.TabIndex = 7;
            this.textBoxSubtotal.Text = "0";
            // 
            // labelReturnAmount
            // 
            this.labelReturnAmount.AutoSize = true;
            this.labelReturnAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturnAmount.Location = new System.Drawing.Point(23, 301);
            this.labelReturnAmount.Name = "labelReturnAmount";
            this.labelReturnAmount.Size = new System.Drawing.Size(128, 23);
            this.labelReturnAmount.TabIndex = 6;
            this.labelReturnAmount.Text = "Return Amount";
            // 
            // labelPaidAmount
            // 
            this.labelPaidAmount.AutoSize = true;
            this.labelPaidAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaidAmount.Location = new System.Drawing.Point(23, 250);
            this.labelPaidAmount.Name = "labelPaidAmount";
            this.labelPaidAmount.Size = new System.Drawing.Size(109, 23);
            this.labelPaidAmount.TabIndex = 5;
            this.labelPaidAmount.Text = "Paid Amount";
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.Location = new System.Drawing.Point(23, 199);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(98, 23);
            this.labelGrandTotal.TabIndex = 4;
            this.labelGrandTotal.Text = "Grand Total";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(23, 103);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(101, 23);
            this.labelDiscount.TabIndex = 3;
            this.labelDiscount.Text = "Discount(%)";
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVat.Location = new System.Drawing.Point(23, 149);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(63, 23);
            this.labelVat.TabIndex = 2;
            this.labelVat.Text = "VAT(%)";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(23, 52);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(80, 23);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Sub Total";
            // 
            // labelCalctTitle
            // 
            this.labelCalctTitle.AutoSize = true;
            this.labelCalctTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalctTitle.Location = new System.Drawing.Point(12, 14);
            this.labelCalctTitle.Name = "labelCalctTitle";
            this.labelCalctTitle.Size = new System.Drawing.Size(159, 23);
            this.labelCalctTitle.TabIndex = 0;
            this.labelCalctTitle.Text = "Calculation Details";
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrint.Location = new System.Drawing.Point(524, 361);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(175, 57);
            this.buttonPrint.TabIndex = 15;
            this.buttonPrint.Text = "PRINT";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // formPurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1625, 802);
            this.Controls.Add(this.Panelcalculation);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDealCust);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPurchaseAndSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPurchaseAndSale";
            this.Load += new System.EventHandler(this.formPurchaseAndSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panelDealCust.ResumeLayout(false);
            this.panelDealCust.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            this.panelDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedProducts)).EndInit();
            this.Panelcalculation.ResumeLayout(false);
            this.Panelcalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label labeltop;
        private System.Windows.Forms.Label labelDealCustTitle;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panelDealCust;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.TextBox textBoxProductSearch;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelProductSearch;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewAddedProducts;
        private System.Windows.Forms.Label labeldgvTitle;
        private System.Windows.Forms.Panel Panelcalculation;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxReturnAmount;
        private System.Windows.Forms.TextBox textBoxPaidAmount;
        private System.Windows.Forms.TextBox textBoxGrandTotal;
        private System.Windows.Forms.TextBox textBoxVAT;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.Label labelReturnAmount;
        private System.Windows.Forms.Label labelPaidAmount;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCalctTitle;
        private System.Windows.Forms.Button buttonPrint;
    }
}