namespace SHRBA.Invoicing.WinClient.Invoices
{
    partial class InvoiceListForm
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
            dgvInvoices = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();
            // 
            // dgvInvoices
            // 
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Dock = DockStyle.Fill;
            dgvInvoices.Location = new Point(0, 0);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.RowHeadersWidth = 62;
            dgvInvoices.Size = new Size(800, 450);
            dgvInvoices.TabIndex = 0;
            dgvInvoices.CellContentClick += dgvInvoices_CellContentClick;
            // 
            // InvoiceListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvInvoices);
            Name = "InvoiceListForm";
            Text = "InvoiceListForm";
            Load += InvoiceListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView dgvInvoices;
    }
}