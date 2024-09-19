namespace SHRBA.Invoicing.WinClient
{
    partial class MainForm
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
            colorDialog1 = new ColorDialog();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            addToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            addToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem2 = new ToolStripMenuItem();
            addToolStripMenuItem2 = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            deleteToolStripMenuItem2 = new ToolStripMenuItem();
            invoicesToolStripMenuItem = new ToolStripMenuItem();
            invoiceListToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addInvoiceToolStripMenuItem = new ToolStripMenuItem();
            invoiceDetailsToolStripMenuItem = new ToolStripMenuItem();
            editInvoiceToolStripMenuItem = new ToolStripMenuItem();
            deleteInvoiceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, categoriesToolStripMenuItem, productsToolStripMenuItem, customersToolStripMenuItem, invoicesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(141, 34);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem, toolStripSeparator2, addToolStripMenuItem, removeToolStripMenuItem, deleteToolStripMenuItem });
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(112, 29);
            categoriesToolStripMenuItem.Text = "Categories";
            categoriesToolStripMenuItem.Click += categoriesToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(241, 34);
            viewToolStripMenuItem.Text = "View Categories";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(238, 6);
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(241, 34);
            addToolStripMenuItem.Text = "Add Category";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(241, 34);
            removeToolStripMenuItem.Text = "Edit Category";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(241, 34);
            deleteToolStripMenuItem.Text = "Delete Category";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem1, toolStripSeparator3, addToolStripMenuItem1, editToolStripMenuItem, deleteToolStripMenuItem1 });
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(98, 29);
            productsToolStripMenuItem.Text = "Products";
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new Size(270, 34);
            viewToolStripMenuItem1.Text = "View Products";
            viewToolStripMenuItem1.Click += viewToolStripMenuItem1_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(267, 6);
            // 
            // addToolStripMenuItem1
            // 
            addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            addToolStripMenuItem1.Size = new Size(270, 34);
            addToolStripMenuItem1.Text = "Add Product";
            addToolStripMenuItem1.Click += addToolStripMenuItem1_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(270, 34);
            editToolStripMenuItem.Text = "Edit Product";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(270, 34);
            deleteToolStripMenuItem1.Text = "Delete Product";
            deleteToolStripMenuItem1.Click += deleteToolStripMenuItem1_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewToolStripMenuItem2, addToolStripMenuItem2, editToolStripMenuItem1, deleteToolStripMenuItem2 });
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(113, 29);
            customersToolStripMenuItem.Text = "Customers";
            // 
            // viewToolStripMenuItem2
            // 
            viewToolStripMenuItem2.Name = "viewToolStripMenuItem2";
            viewToolStripMenuItem2.Size = new Size(246, 34);
            viewToolStripMenuItem2.Text = "View Customers";
            viewToolStripMenuItem2.Click += viewToolStripMenuItem2_Click;
            // 
            // addToolStripMenuItem2
            // 
            addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            addToolStripMenuItem2.Size = new Size(246, 34);
            addToolStripMenuItem2.Text = "Add Customer";
            addToolStripMenuItem2.Click += addToolStripMenuItem2_Click;
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(246, 34);
            editToolStripMenuItem1.Text = "Edit Customer";
            editToolStripMenuItem1.Click += editToolStripMenuItem1_Click;
            // 
            // deleteToolStripMenuItem2
            // 
            deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            deleteToolStripMenuItem2.Size = new Size(246, 34);
            deleteToolStripMenuItem2.Text = "Delete Customer";
            deleteToolStripMenuItem2.Click += deleteToolStripMenuItem2_Click;
            // 
            // invoicesToolStripMenuItem
            // 
            invoicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { invoiceListToolStripMenuItem, toolStripSeparator1, addInvoiceToolStripMenuItem, invoiceDetailsToolStripMenuItem, editInvoiceToolStripMenuItem, deleteInvoiceToolStripMenuItem });
            invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            invoicesToolStripMenuItem.Size = new Size(92, 29);
            invoicesToolStripMenuItem.Text = "Invoices";
            // 
            // invoiceListToolStripMenuItem
            // 
            invoiceListToolStripMenuItem.Name = "invoiceListToolStripMenuItem";
            invoiceListToolStripMenuItem.Size = new Size(270, 34);
            invoiceListToolStripMenuItem.Text = "Invoice List";
            invoiceListToolStripMenuItem.Click += invoiceListToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(267, 6);
            // 
            // addInvoiceToolStripMenuItem
            // 
            addInvoiceToolStripMenuItem.Name = "addInvoiceToolStripMenuItem";
            addInvoiceToolStripMenuItem.Size = new Size(270, 34);
            addInvoiceToolStripMenuItem.Text = "Add Invoice";
            addInvoiceToolStripMenuItem.Click += addInvoiceToolStripMenuItem_Click;
            // 
            // invoiceDetailsToolStripMenuItem
            // 
            invoiceDetailsToolStripMenuItem.Name = "invoiceDetailsToolStripMenuItem";
            invoiceDetailsToolStripMenuItem.Size = new Size(270, 34);
            invoiceDetailsToolStripMenuItem.Text = "Invoice Details";
            invoiceDetailsToolStripMenuItem.Click += invoiceDetailsToolStripMenuItem_Click;
            // 
            // editInvoiceToolStripMenuItem
            // 
            editInvoiceToolStripMenuItem.Name = "editInvoiceToolStripMenuItem";
            editInvoiceToolStripMenuItem.Size = new Size(270, 34);
            editInvoiceToolStripMenuItem.Text = "Edit Invoice";
            editInvoiceToolStripMenuItem.Click += editInvoiceToolStripMenuItem_Click;
            // 
            // deleteInvoiceToolStripMenuItem
            // 
            deleteInvoiceToolStripMenuItem.Name = "deleteInvoiceToolStripMenuItem";
            deleteInvoiceToolStripMenuItem.Size = new Size(270, 34);
            deleteInvoiceToolStripMenuItem.Text = "Delete Invoice";
            deleteInvoiceToolStripMenuItem.Click += deleteInvoiceToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem invoicesToolStripMenuItem;
        private ToolStripMenuItem invoiceListToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem invoiceDetailsToolStripMenuItem;
        private ToolStripMenuItem addInvoiceToolStripMenuItem;
        private ToolStripMenuItem editInvoiceToolStripMenuItem;
        private ToolStripMenuItem deleteInvoiceToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem1;
        private ToolStripMenuItem addToolStripMenuItem1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem viewToolStripMenuItem2;
        private ToolStripMenuItem addToolStripMenuItem2;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem deleteToolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}