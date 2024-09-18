using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHRBA.Invoicing.Core.Services;

namespace SHRBA.Invoicing.WinClient.Products
{
    public partial class ProductListForm : Form
    {
        private readonly IProductService productService;

        public ProductListForm(IProductService productService)
        {
            InitializeComponent();
            this.productService = productService;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            var products = productService.GetProducts();
            dgvProducts.DataSource = products;
        }
    }
}
