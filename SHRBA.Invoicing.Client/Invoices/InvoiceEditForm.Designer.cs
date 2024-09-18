namespace SHRBA.Invoicing.WinClient.Invoices
{
    partial class InvoiceEditForm
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
            chkIsPercentage = new CheckBox();
            cmbPaymentMode = new ComboBox();
            cmbCustomer = new ComboBox();
            dtInvoiceDate = new DateTimePicker();
            txtDiscountAmount = new TextBox();
            label16 = new Label();
            label4 = new Label();
            label15 = new Label();
            label3 = new Label();
            label14 = new Label();
            label2 = new Label();
            lblGrandTotal = new Label();
            lblTax = new Label();
            lblSubTotal = new Label();
            label9 = new Label();
            label1 = new Label();
            btnAddLineItem = new Button();
            btnSaveInvoice = new Button();
            dgvEditLineItems = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEditLineItems).BeginInit();
            SuspendLayout();
            // 
            // chkIsPercentage
            // 
            chkIsPercentage.AutoSize = true;
            chkIsPercentage.Location = new Point(702, 164);
            chkIsPercentage.Margin = new Padding(4, 5, 4, 5);
            chkIsPercentage.Name = "chkIsPercentage";
            chkIsPercentage.Size = new Size(159, 29);
            chkIsPercentage.TabIndex = 40;
            chkIsPercentage.Text = "Is Perecentage?";
            chkIsPercentage.UseVisualStyleBackColor = true;
            chkIsPercentage.CheckedChanged += chkIsPercentage_CheckedChanged;
            // 
            // cmbPaymentMode
            // 
            cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMode.FormattingEnabled = true;
            cmbPaymentMode.Items.AddRange(new object[] { "Cash", "Card" });
            cmbPaymentMode.Location = new Point(257, 269);
            cmbPaymentMode.Margin = new Padding(4, 5, 4, 5);
            cmbPaymentMode.Name = "cmbPaymentMode";
            cmbPaymentMode.Size = new Size(187, 33);
            cmbPaymentMode.TabIndex = 39;
            cmbPaymentMode.SelectedIndexChanged += cmbPaymentMode_SelectedIndexChanged;
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(257, 217);
            cmbCustomer.Margin = new Padding(4, 5, 4, 5);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(187, 33);
            cmbCustomer.TabIndex = 38;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // dtInvoiceDate
            // 
            dtInvoiceDate.Location = new Point(257, 161);
            dtInvoiceDate.Margin = new Padding(4, 5, 4, 5);
            dtInvoiceDate.Name = "dtInvoiceDate";
            dtInvoiceDate.Size = new Size(187, 31);
            dtInvoiceDate.TabIndex = 37;
            dtInvoiceDate.ValueChanged += dtInvoiceDate_ValueChanged;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new Point(937, 161);
            txtDiscountAmount.Margin = new Padding(4, 5, 4, 5);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.Size = new Size(141, 31);
            txtDiscountAmount.TabIndex = 35;
            txtDiscountAmount.TextChanged += txtDiscountAmount_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(620, 274);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(102, 25);
            label16.TabIndex = 34;
            label16.Text = "Grand Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 274);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 24;
            label4.Text = "Payment mode";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(620, 217);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(36, 25);
            label15.TabIndex = 31;
            label15.Text = "Tax";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 217);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 30;
            label3.Text = "Customer";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(620, 166);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(82, 25);
            label14.TabIndex = 29;
            label14.Text = "Discount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 167);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 28;
            label2.Text = "Invoice Date";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Location = new Point(937, 274);
            lblGrandTotal.Margin = new Padding(4, 0, 4, 0);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(52, 25);
            lblGrandTotal.TabIndex = 27;
            lblGrandTotal.Text = "9999";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(937, 217);
            lblTax.Margin = new Padding(4, 0, 4, 0);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(52, 25);
            lblTax.TabIndex = 26;
            lblTax.Text = "9999";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(937, 122);
            lblSubTotal.Margin = new Padding(4, 0, 4, 0);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(52, 25);
            lblSubTotal.TabIndex = 25;
            lblSubTotal.Text = "9999";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(620, 122);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 32;
            label9.Text = "Sub-Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 33;
            label1.Text = "Invoice Number";
            // 
            // btnAddLineItem
            // 
            btnAddLineItem.Location = new Point(997, 395);
            btnAddLineItem.Margin = new Padding(4, 5, 4, 5);
            btnAddLineItem.Name = "btnAddLineItem";
            btnAddLineItem.Size = new Size(131, 40);
            btnAddLineItem.TabIndex = 42;
            btnAddLineItem.Text = "Edit Item";
            btnAddLineItem.UseVisualStyleBackColor = true;
            btnAddLineItem.Click += btnAddLineItem_Click;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Location = new Point(257, 395);
            btnSaveInvoice.Margin = new Padding(4, 5, 4, 5);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(119, 49);
            btnSaveInvoice.TabIndex = 41;
            btnSaveInvoice.Text = "Save Invoice";
            btnSaveInvoice.UseVisualStyleBackColor = true;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // dgvEditLineItems
            // 
            dgvEditLineItems.AllowUserToAddRows = false;
            dgvEditLineItems.AllowUserToDeleteRows = false;
            dgvEditLineItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditLineItems.Location = new Point(34, 482);
            dgvEditLineItems.Margin = new Padding(4, 5, 4, 5);
            dgvEditLineItems.Name = "dgvEditLineItems";
            dgvEditLineItems.ReadOnly = true;
            dgvEditLineItems.RowHeadersWidth = 62;
            dgvEditLineItems.RowTemplate.Height = 25;
            dgvEditLineItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEditLineItems.Size = new Size(1270, 417);
            dgvEditLineItems.TabIndex = 27;
            dgvEditLineItems.CellContentClick += dgvEditLineItems_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(1152, 395);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 43;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(54, 395);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(119, 49);
            button3.TabIndex = 45;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(877, 401);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 46;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 47;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(288, 110);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 48;
            // 
            // InvoiceEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 928);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dgvEditLineItems);
            Controls.Add(btnAddLineItem);
            Controls.Add(btnSaveInvoice);
            Controls.Add(chkIsPercentage);
            Controls.Add(cmbPaymentMode);
            Controls.Add(cmbCustomer);
            Controls.Add(dtInvoiceDate);
            Controls.Add(txtDiscountAmount);
            Controls.Add(label16);
            Controls.Add(label4);
            Controls.Add(label15);
            Controls.Add(label3);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubTotal);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "InvoiceEditForm";
            Text = "InvoiceEditForm";
            Load += InvoiceEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEditLineItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkIsPercentage;
        private ComboBox cmbPaymentMode;
        private ComboBox cmbCustomer;
        private DateTimePicker dtInvoiceDate;
        private TextBox txtDiscountAmount;
        private Label label16;
        private Label label4;
        private Label label15;
        private Label label3;
        private Label label14;
        private Label label2;
        private Label lblGrandTotal;
        private Label lblTax;
        private Label lblSubTotal;
        private Label label9;
        private Label label1;
        private Button btnAddLineItem;
        private Button btnSaveInvoice;
        private Button button1;
        private Button button3;
        internal DataGridView dgvEditLineItems;
        private Button button2;
        private Label label5;
        private Label label6;
    }
}