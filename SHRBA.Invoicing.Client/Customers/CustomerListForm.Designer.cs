namespace SHRBA.Invoicing.WinClient.Customers
{
    partial class CustomerListForm
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
            dvgCustomers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgCustomers).BeginInit();
            SuspendLayout();
            // 
            // dvgCustomers
            // 
            dvgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgCustomers.Dock = DockStyle.Fill;
            dvgCustomers.Location = new Point(0, 0);
            dvgCustomers.Name = "dvgCustomers";
            dvgCustomers.RowHeadersWidth = 62;
            dvgCustomers.Size = new Size(800, 450);
            dvgCustomers.TabIndex = 0;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dvgCustomers);
            Name = "CustomerListForm";
            Text = "CustomerListForm";
            Load += CustomerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dvgCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal DataGridView dvgCustomers;
    }
}