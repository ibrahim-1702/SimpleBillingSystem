using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleBillingSystem;
using SimpleBillingApp;

namespace BillingApp
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ProductID = ProductIDTB.Text;
            string ProductName = ProductNameTB.Text;

            int Price = Convert.ToInt32(PriceTB.Text);
            int Tax = Convert.ToInt32(TaxTB.Text);
            int Discount = Convert.ToInt32(DiscountTB.Text);

            Product newProduct = new Product(ProductID,ProductName,Price,Tax,Discount);
            newProduct.AddProd(Billing.ProductsFile);

            this.Close();

            MessageBox.Show("Product "+ProductName+" Is Added");
            Product.fetchAllProds(Billing.ProductsFile);

        }
    }
}
