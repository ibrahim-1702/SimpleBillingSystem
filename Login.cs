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
using System.IO;


namespace SimpleBillingApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            if (!Directory.Exists(Billing.BillsDir)) 
            {
                Directory.CreateDirectory(Billing.BillsDir);
            }
            if (!File.Exists(Billing.ProductsFile)) 
            {
                FileStream productsFile = File.Create(Billing.ProductsFile);
                productsFile.Close();
            }
            if (!File.Exists(@"C:\BillingApp\Employees.txt"))
            {
                FileStream productsFile = File.Create(@"C:\BillingApp\Employees.txt");
                productsFile.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Employee.fetchEmpDetails(@"C:\BillingApp\Employees.txt");
            Product.fetchAllProds(Billing.ProductsFile);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            try
            {
                employee.EmpName = Employee.EmpDetails[EmpPhNumber.Text.Trim()];
                MessageBox.Show("Welcome " + employee.EmpName);
                Billing billing = new Billing();
                billing.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Employee Not Found!!!");
            }

        }
    }
}
