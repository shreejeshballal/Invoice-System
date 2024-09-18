namespace SHRBA.Invoicing.WinClient.Invoices
{
    partial class InvoiceDetailsForm
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
            dgvLineItems = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label9 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            lblInvoiceNumber = new Label();
            lblInvoiceDate = new Label();
            lblCustomer = new Label();
            lblPaymentMode = new Label();
            lblSubTotal = new Label();
            lblDiscount = new Label();
            lblTax = new Label();
            lblGrandTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLineItems).BeginInit();
            SuspendLayout();
            // 
            // dgvLineItems
            // 
            dgvLineItems.AllowUserToDeleteRows = false;
            dgvLineItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLineItems.Location = new Point(12, 337);
            dgvLineItems.Name = "dgvLineItems";
            dgvLineItems.ReadOnly = true;
            dgvLineItems.RowHeadersWidth = 62;
            dgvLineItems.Size = new Size(1013, 361);
            dgvLineItems.TabIndex = 0;
            dgvLineItems.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 2;
            label1.Text = "Invoice Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 140);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 3;
            label2.Text = "Invoice Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 198);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 4;
            label3.Text = "Customer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 249);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 5;
            label4.Text = "Payament Mode";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(639, 86);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(87, 25);
            label9.TabIndex = 6;
            label9.Text = "Sub-Total";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(639, 140);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(82, 25);
            label14.TabIndex = 7;
            label14.Text = "Discount";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(639, 198);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(36, 25);
            label15.TabIndex = 8;
            label15.Text = "Tax";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(639, 249);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(102, 25);
            label16.TabIndex = 9;
            label16.Text = "Grand Total";
            // 
            // lblInvoiceNumber
            // 
            lblInvoiceNumber.AutoSize = true;
            lblInvoiceNumber.Location = new Point(250, 86);
            lblInvoiceNumber.Margin = new Padding(4, 0, 4, 0);
            lblInvoiceNumber.Name = "lblInvoiceNumber";
            lblInvoiceNumber.Size = new Size(52, 25);
            lblInvoiceNumber.TabIndex = 10;
            lblInvoiceNumber.Text = "9999";
            lblInvoiceNumber.Click += lblInvoiceNumber_Click;
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Location = new Point(250, 140);
            lblInvoiceDate.Margin = new Padding(4, 0, 4, 0);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(52, 25);
            lblInvoiceDate.TabIndex = 11;
            lblInvoiceDate.Text = "9999";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(250, 198);
            lblCustomer.Margin = new Padding(4, 0, 4, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(52, 25);
            lblCustomer.TabIndex = 12;
            lblCustomer.Text = "9999";
            // 
            // lblPaymentMode
            // 
            lblPaymentMode.AutoSize = true;
            lblPaymentMode.Location = new Point(250, 249);
            lblPaymentMode.Margin = new Padding(4, 0, 4, 0);
            lblPaymentMode.Name = "lblPaymentMode";
            lblPaymentMode.Size = new Size(52, 25);
            lblPaymentMode.TabIndex = 13;
            lblPaymentMode.Text = "9999";
            lblPaymentMode.Click += lblPaymentMode_Click;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(825, 86);
            lblSubTotal.Margin = new Padding(4, 0, 4, 0);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(52, 25);
            lblSubTotal.TabIndex = 14;
            lblSubTotal.Text = "9999";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(825, 140);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(52, 25);
            lblDiscount.TabIndex = 15;
            lblDiscount.Text = "9999";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(825, 198);
            lblTax.Margin = new Padding(4, 0, 4, 0);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(52, 25);
            lblTax.TabIndex = 16;
            lblTax.Text = "9999";
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Location = new Point(825, 251);
            lblGrandTotal.Margin = new Padding(4, 0, 4, 0);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(52, 25);
            lblGrandTotal.TabIndex = 17;
            lblGrandTotal.Text = "9999";
            // 
            // InvoiceDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 698);
            Controls.Add(lblGrandTotal);
            Controls.Add(lblTax);
            Controls.Add(lblDiscount);
            Controls.Add(lblSubTotal);
            Controls.Add(lblPaymentMode);
            Controls.Add(lblCustomer);
            Controls.Add(lblInvoiceDate);
            Controls.Add(lblInvoiceNumber);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvLineItems);
            Name = "InvoiceDetailsForm";
            Text = "InvoiceDetailsForm";
            Load += InvoiceDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLineItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLineItems;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label9;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label lblInvoiceNumber;
        private Label lblInvoiceDate;
        private Label lblCustomer;
        private Label lblPaymentMode;
        private Label lblSubTotal;
        private Label lblDiscount;
        private Label lblTax;
        private Label lblGrandTotal;
    }
}