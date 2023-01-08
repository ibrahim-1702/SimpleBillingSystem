using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BillingApp
{
    public partial class BillSearch : Form
    {
        public BillSearch()
        {
            InitializeComponent();
            string directoryPath = @"C:\BillingApp\Bills";
            string[] directories = Directory.GetDirectories(directoryPath);

            foreach (string directory in directories)
            {
                FolderLB.Items.Add(directory.Remove(0,20));
            }
        }

        private void FolderLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileLB.Items.Clear();
            string directoryPath = "C:\\BillingApp\\Bills\\"+FolderLB.SelectedItem.ToString();

            string[] files = Directory.GetFiles(directoryPath);

            foreach (string file in files)
            {
                FileLB.Items.Add(file.Remove(0,31));
            }
        }

        private void FileLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillPviewLB.Items.Clear();
            BillPviewLB.Items.Add("ProductID		Product 		Qty	Unit Cost 		Cost");
            
            string filePath = "C:\\BillingApp\\Bills\\"+FolderLB.SelectedItem.ToString()+"\\"+FileLB.SelectedItem.ToString();
            string[] Contents = File.ReadAllLines(filePath);
            
            int NumberOfItems = Contents.Length;
            int totalTax = Convert.ToInt32(Contents[NumberOfItems - 2]);
            int Total = Convert.ToInt32(Contents[NumberOfItems - 1]);
            int payable = totalTax + Total;
            
            for(int i = 0; i < NumberOfItems-2; i++) 
            {
                BillPviewLB.Items.Add(Contents[i]);
            }
            BillPviewLB.Items.Add("\n \n \n");
            BillPviewLB.Items.Add("The Total Tax: " + totalTax);
            BillPviewLB.Items.Add("\nThe Total Amount: " + Total);
            BillPviewLB.Items.Add("\nNet Payable Amount = " + payable);
        }
    }
}
