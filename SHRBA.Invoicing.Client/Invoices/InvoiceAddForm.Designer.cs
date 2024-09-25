namespace SHRBA.Invoicing.WinClient.Invoices
{
    partial class InvoiceAddForm
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
            btnAddLineItem = new Button();
            btnSaveInvoice = new Button();
            chkIsPercentage = new CheckBox();
            cmbPaymentMode = new ComboBox();
            cmbCustomer = new ComboBox();
            dtInvoiceDate = new DateTimePicker();
            txtInvoiceNumber = new TextBox();
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
            dgvLineItems = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLineItems).BeginInit();
            SuspendLayout();
            // 
            // btnAddLineItem
            // 
            btnAddLineItem.Location = new Point(1096, 305);
            btnAddLineItem.Margin = new Padding(4, 5, 4, 5);
            btnAddLineItem.Name = "btnAddLineItem";
            btnAddLineItem.Size = new Size(131, 40);
            btnAddLineItem.TabIndex = 25;
            btnAddLineItem.Text = "Add Line Item";
            btnAddLineItem.UseVisualStyleBackColor = true;
            btnAddLineItem.Click += btnAddLineItem_Click;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Location = new Point(32, 288);
            btnSaveInvoice.Margin = new Padding(4, 5, 4, 5);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(131, 57);
            btnSaveInvoice.TabIndex = 24;
            btnSaveInvoice.Text = "Save Invoice";
            btnSaveInvoice.UseVisualStyleBackColor = true;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // chkIsPercentage
            // 
            chkIsPercentage.AutoSize = true;
            chkIsPercentage.Location = new Point(706, 116);
            chkIsPercentage.Margin = new Padding(4, 5, 4, 5);
            chkIsPercentage.Name = "chkIsPercentage";
            chkIsPercentage.Size = new Size(159, 29);
            chkIsPercentage.TabIndex = 23;
            chkIsPercentage.Text = "Is Perecentage?";
            chkIsPercentage.UseVisualStyleBackColor = true;
            chkIsPercentage.CheckedChanged += chkIsPercentage_CheckedChanged;
            // 
            // cmbPaymentMode
            // 
            cmbPaymentMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMode.FormattingEnabled = true;
            cmbPaymentMode.Items.AddRange(new object[] { "Cash", "Card" });
            cmbPaymentMode.Location = new Point(303, 224);
            cmbPaymentMode.Margin = new Padding(4, 5, 4, 5);
            cmbPaymentMode.Name = "cmbPaymentMode";
            cmbPaymentMode.Size = new Size(187, 33);
            cmbPaymentMode.TabIndex = 22;
            cmbPaymentMode.SelectedIndexChanged += cmbPaymentMode_SelectedIndexChanged;
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(303, 172);
            cmbCustomer.Margin = new Padding(4, 5, 4, 5);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(187, 33);
            cmbCustomer.TabIndex = 21;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
            // 
            // dtInvoiceDate
            // 
            dtInvoiceDate.Location = new Point(303, 116);
            dtInvoiceDate.Margin = new Padding(4, 5, 4, 5);
            dtInvoiceDate.Name = "dtInvoiceDate";
            dtInvoiceDate.Size = new Size(187, 31);
            dtInvoiceDate.TabIndex = 20;
            dtInvoiceDate.ValueChanged += dtInvoiceDate_ValueChanged;
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.Location = new Point(303, 64);
            txtInvoiceNumber.Margin = new Padding(4, 5, 4, 5);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.Size = new Size(187, 31);
            txtInvoiceNumber.TabIndex = 19;
            txtInvoiceNumber.TextChanged += txtInvoiceNumber_TextChanged;
            // 
            // txtDiscountAmount
            // 
            txtDiscountAmount.Location = new Point(981, 113);
            txtDiscountAmount.Margin = new Padding(4, 5, 4, 5);
            txtDiscountAmount.Name = "txtDiscountAmount";
            txtDiscountAmount.Size = new Size(141, 31);
            txtDiscountAmount.TabIndex = 18;
            txtDiscountAmount.TextChanged += txtDiscountAmount_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(624, 226);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(102, 25);
            label16.TabIndex = 17;
            label16.Text = "Grand Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 226);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 7;
            label4.Text = "Payment mode";
            label4.Click += label4_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(624, 169);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(36, 25);
            label15.TabIndex = 14;
            label15.Text = "Tax";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 169);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 13;
            label3.Text = "Customer";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(624, 118);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(82, 25);
            label14.TabIndex = 12;
            label14.Text = "Discount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 11;
            label2.Text = "Invoice Date";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Location = new Point(981, 226);
            lblGrandTotal.Margin = new Padding(4, 0, 4, 0);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(22, 25);
            lblGrandTotal.TabIndex = 10;
            lblGrandTotal.Text = "0";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(981, 169);
            lblTax.Margin = new Padding(4, 0, 4, 0);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(47, 25);
            lblTax.TabIndex = 9;
            lblTax.Text = "10%";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(981, 74);
            lblSubTotal.Margin = new Padding(4, 0, 4, 0);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(22, 25);
            lblSubTotal.TabIndex = 8;
            lblSubTotal.Text = "0";
            lblSubTotal.Click += lblSubTotal_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(624, 74);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 15;
            label9.Text = "Sub-Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 16;
            label1.Text = "Invoice Number";
            // 
            // dgvLineItems
            // 
            dgvLineItems.AllowUserToAddRows = false;
            dgvLineItems.AllowUserToDeleteRows = false;
            dgvLineItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLineItems.Location = new Point(13, 366);
            dgvLineItems.Margin = new Padding(4, 5, 4, 5);
            dgvLineItems.Name = "dgvLineItems";
            dgvLineItems.ReadOnly = true;
            dgvLineItems.RowHeadersWidth = 62;
            dgvLineItems.RowTemplate.Height = 25;
            dgvLineItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLineItems.Size = new Size(1235, 396);
            dgvLineItems.TabIndex = 26;
            // 
            // InvoiceAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 784);
            Controls.Add(dgvLineItems);
            Controls.Add(btnAddLineItem);
            Controls.Add(btnSaveInvoice);
            Controls.Add(chkIsPercentage);
            Controls.Add(cmbPaymentMode);
            Controls.Add(cmbCustomer);
            Controls.Add(dtInvoiceDate);
            Controls.Add(txtInvoiceNumber);
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
            Name = "InvoiceAddForm";
            Text = "InvoiceAddForm";
            Load += InvoiceAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLineItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddLineItem;
        private Button btnSaveInvoice;
        private CheckBox chkIsPercentage;
        private ComboBox cmbPaymentMode;
        private ComboBox cmbCustomer;
        private DateTimePicker dtInvoiceDate;
        private TextBox txtInvoiceNumber;
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
        private DataGridView dgvLineItems;
    }
}