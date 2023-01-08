using System;
using System.IO;
using System.Collections.Generic;
namespace SimpleBillingSystem
{
    public class Bill
    {
        
        public List<BillItem> BillItems = new List<BillItem>();

        private double totalTax;
        private double total;

        public double TotalTax
        {
            get { return totalTax; }
            set { totalTax += value; }
        }
        public double Total 
        {
            get { return total; }
            set { total += value; }
        }
        
        
        public static Bill ScanProduct(string ProductID, int qty, Bill bill)
        {
            BillItem item = new BillItem(Product.Products[ProductID], qty);
            bill.BillItems.Add(item);
 
            return bill;
        }

        public Bill Calculate(Bill bill) 
        {
            double totalForOneItem;
            double taxCostPerUnit;

            foreach (BillItem item in bill.BillItems)
            {
                bill.Total = item.Cost;
                totalForOneItem = (item.Product.Price * item.Qty);
                taxCostPerUnit = (item.Product.TaxPerQty / 100);
                bill.totalTax =  taxCostPerUnit* totalForOneItem;
            }
            return bill;
        }

        public void SaveBills(string path,Bill bill) 
        {
            string todaysDate = DateTime.Today.ToString("d");
            string currentTime = DateTime.Now.ToString("h l m l s"); //Using The Current Time To Name The Text File separated with the letter l
            string folder = path+"\\"+todaysDate;
            string textFile = folder+"\\" + currentTime+".txt"; //Concating the folder path with the file name
            string Contents = "";

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            StreamWriter writer = File.CreateText(textFile);
            foreach (BillItem item in bill.BillItems)
            {
                Contents += item.ToString();
                Contents += "\n";
            }
            Contents += bill.TotalTax+"\n";
            Contents += bill.Total;
            writer.Write(Contents);
            writer.Close();
        }

        public string[] GetTheBill(string FilePath)
        {
            string[] Contents;
            Contents = File.ReadAllText(FilePath).Split('\n');
            return Contents;
        }


    }
}
