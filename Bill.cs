using System;
using System.IO;
using System.Collections.Generic;

namespace BillingSystem
{
    public static class Bill
    {
        public static int NumberOfProducts;
        private static int[] Quatities;
        private static double[] PriceTot;
        private static double TaxTot = 0, DiscountTot = 0, Total;
        public static string[] selectProduct() 
        {
            string input;
            string[] products = new string[NumberOfProducts];
            Quatities = new int[NumberOfProducts];
            for(int i = 0; i < NumberOfProducts; i++) 
            {
                Console.WriteLine("Enter The ProductId:(if want to exit press 'E')");
                input = Console.ReadLine();
                if (input == "E" || input == "Exit") 
                {
                    break;
                }
                Console.WriteLine("Enter The Product Qty");
                Quatities[i] = Convert.ToInt32(Console.ReadLine());
                products[i] = input;
            }
            return products;
        }

        public static Product[] fetchProds(string[] productIds) 
        {
            Product[] products = new Product[productIds.Length];
            string Path = @"C:\BillingSystem\Products\";
            string[] ProdDetails = new string[productIds.Length];
            int i = 0;
            foreach (string Id in productIds)
            {
                ProdDetails = Convert.ToString(File.ReadAllText(Path+Id)).Split(",");
                products[i] = new Product(ProdDetails[0], ProdDetails[1], ProdDetails[2], ProdDetails[3], ProdDetails[4]);
                i++;
            }
            return products;
        }

        public static void Billing(Product[] products) 
        {
            int NumberOfBills = Convert.ToInt32(File.ReadAllText(@"C:\BillingSystem\NumberOfBills.txt"));

            NumberOfBills++;

            File.WriteAllText(@"C:\BillingSystem\NumberOfBills.txt", Convert.ToString(NumberOfBills));

            string Path = @"C:\BillingSystem\Bills\";
            StreamWriter BillPrinter = new StreamWriter(Path + "Bill-" + NumberOfBills);
            PriceTot = new double[products.Length];
            BillPrinter.WriteLine("ProductId\tProductName\tQty\tCost");
            for (int i = 0; i < products.Length; i++)
            {
                PriceTot[i] = Convert.ToDouble(products[i].ProductPrice) * Quatities[i];
                TaxTot += (Convert.ToDouble(products[i].ProductTax) / 100) * PriceTot[i];
                DiscountTot += (Convert.ToDouble(products[i].ProductDiscount) / 100) * PriceTot[i];
                Total += PriceTot[i];

                BillPrinter.WriteLine(products[i].ProductId + "\t" + products[i].ProductName + "\t" + Quatities[i] + "\t" + PriceTot[i] + "\n");
            }

            BillPrinter.WriteLine("\nTotal: " + Total);
            BillPrinter.WriteLine("\nTotal Tax Amount: "+TaxTot);
            BillPrinter.WriteLine("\nTotal Discount Amount: " + DiscountTot);
            Total -= DiscountTot;
            Total += TaxTot;
            BillPrinter.WriteLine("\nTotal NetPayable: " + Total);
            BillPrinter.Close();
        }
    }
}
