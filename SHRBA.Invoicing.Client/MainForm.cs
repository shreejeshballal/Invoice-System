using Microsoft.Extensions.DependencyInjection;
using SHRBA.Invoicing.Client;
using SHRBA.Invoicing.Core.Models;
using SHRBA.Invoicing.WinClient.Categories;
using SHRBA.Invoicing.WinClient.Customers;
using SHRBA.Invoicing.WinClient.Invoices;
using SHRBA.Invoicing.WinClient.Products;

namespace SHRBA.Invoicing.WinClient
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;

        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void categoriesListMenu_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMyForm<CategoryListForm>();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMyForm<CategoryAddForm>();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowMyForm<ProductListForm>();
        }

        private void viewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ShowMyForm<CustomerListForm>();
        }

        private void invoiceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMyForm<InvoiceListForm>();
        }

        private void invoiceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ShowMyForm<InvoiceDetailsForm>() as InvoiceDetailsForm;
            var f = MdiChildren.SingleOrDefault(f => f.Name == "InvoiceListForm");
            if (f is null) return;
            var ilf = f as InvoiceListForm;
            var selectedInvoice = ilf.dgvInvoices.SelectedRows[0].DataBoundItem as Invoice;
            form.DislpayInvoiceDetails(selectedInvoice);
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            ShowMyForm<CustomerAddForm>();

        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMyForm<InvoiceAddForm>();

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowMyForm<ProductAddForm>();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ShowMyForm<CategoryEditForm>() as CategoryEditForm;
            var f = MdiChildren.SingleOrDefault(f => f.Name == "CategoryListForm");
            if (f is null) return;
            var ilf = f as CategoryListForm;
            var selectedCategory = ilf.dgvCategories.SelectedRows[0].DataBoundItem as Category;
            form.DisplayCategoryDetails(selectedCategory);
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = ShowMyForm<CustomerEditForm>() as CustomerEditForm;
            var f = MdiChildren.SingleOrDefault(f => f.Name == "CustomerListForm");
            if (f is null) return;
            var ilf = f as CustomerListForm;
            var selectedCustomer = ilf.dvgCustomers.SelectedRows[0].DataBoundItem as Customer;
            form.DisplayCustomerDetails(selectedCustomer);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ShowMyForm<ProductEditForm>() as ProductEditForm;
            var f = MdiChildren.SingleOrDefault(f => f.Name == "ProductListForm");
            if (f is null) return;
            var ilf = f as ProductListForm;
            var selectedProduct = ilf.dgvProducts.SelectedRows[0].DataBoundItem as Product;
            form.DisplayProductDetails(selectedProduct);
        }

        private void editInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ShowMyForm<InvoiceEditForm>() as InvoiceEditForm;
            var f = MdiChildren.SingleOrDefault(f => f.Name == "InvoiceListForm");
            if (f is null) return;
            var ilf = f as InvoiceListForm;
            var selectedInvoice = ilf.dgvInvoices.SelectedRows[0].DataBoundItem as Invoice;
            form.DisplayInvoiceDetails(selectedInvoice);
        }

        private void editLineItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private Form ShowMyForm<T>()
        {
            var formToShow = Program.ServiceProvider.GetRequiredService<T>() as Form;
            formToShow.MdiParent = this;
            formToShow.WindowState = FormWindowState.Maximized;
            formToShow.Show();
            return formToShow;
        }
    }
}
