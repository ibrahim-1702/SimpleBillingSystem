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
using BillingApp;

namespace SimpleBillingApp
{
    
    public partial class Billing : Form
    {
        public const string BillsDir = @"C:\BillingApp\Bills";
        public const string ProductsFile = @"C:\BillingApp\Products.txt";
        
        
        int incrementer = 0;
        public Billing()
        {
            InitializeComponent();
            BillBT.Enabled = false;
            button3.Enabled = false;
            button1.Enabled = false;
        }
        int qty;
        Bill bill = new Bill();
        public void Billing_Load(object sender, EventArgs e)
        {
            Product.fetchAllProds(ProductsFile);
            foreach (Product product in Product.Products.Values)
            {
                ProductsLB.Items.Add(product.ProductID);
            }
            if (Product.Products.Values.Count == 0) 
            {
                MessageBox.Show("Oops!!! \nNo Product to display \nPlease Add Products!");
                BillBT.Enabled = false;
            }
               
        }

        private void ProductsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedproducts = ProductsLB.SelectedItems;
            qty = Convert.ToInt32(QtyUpDwn.Value);
            bill = Bill.ScanProduct(selectedproducts[0].ToString(), qty,bill);

            BillPviewLB.Items.Add(bill.BillItems[incrementer].ToString());
            incrementer++;
            BillBT.Enabled = true;
            button3.Enabled = true;
            button1.Enabled = false;
            QtyUpDwn.Value = 1M;
        }

        private void BillBT_Click(object sender, EventArgs e)
        {
            bill = bill.Calculate(bill);
            bill.SaveBills(BillsDir, bill);

            BillPviewLB.Items.Add("\n" + "\n" + "\n");
            BillPviewLB.Items.Add("The Total Tax = " + bill.TotalTax);
            BillPviewLB.Items.Add("The Total Amount  = " + bill.Total+"\n");
            double Payable = bill.Total + bill.TotalTax;
            BillPviewLB.Items.Add("\nNet Payable Amount = " + Payable);
            BillBT.Enabled = false;
        }

        //public void Billing_FormClosing(object sender, CancelEventArgs e)
        //{
        //        if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
        //           MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        {
        //            e.Cancel = true;
        //        }
           
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Login login = new Login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bill = new Bill();
            BillPviewLB.Items.Clear();
            BillPviewLB.Items.Add("ProductID		Product 		Qty	Unit Cost 		Cost");
            BillBT.Enabled = true;
            incrementer = 0;
        }

        private void BillSearchBT_Click(object sender, EventArgs e)
        {
            BillSearch form = new BillSearch();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }
    }
}
