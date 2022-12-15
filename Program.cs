using System;
using System.IO;

namespace BillingSystem
{
    public class Program
    {
       public static void Main(string[] args)
        {
            ListOutProd();
            Modes();
        }
        public static void Modes()
        {
            Console.WriteLine("\nTo Add Products In System Press 'A':\nTo Activate Billing Mode Press 'B':\nTo Exit Press 'E': ");
            char Input = Convert.ToChar(Console.ReadLine());
            switch (Input)
            {
                case 'A':
                    Product product = new Product();
                    Product.SaveProduct(Product.GetProductDetails(product));
                    ListOutProd();
                    Modes();
                    break;
                case 'B':
                    Console.WriteLine("Enter The Number Of products : ");
                    Bill.NumberOfProducts = Convert.ToInt32(Console.ReadLine());
                    Bill.Billing(Bill.fetchProds(Bill.selectProduct()));

                    Modes();
                    break;
                case 'E':
                    break;
                default:
                    Console.WriteLine("Entered a wrong input: want to try again (Y/N)?");
                    char YorN = Convert.ToChar(Console.ReadLine());
                    if (YorN == 'Y' || YorN == 'y')
                    {
                        Modes();
                    }
                    break;
            }
        }

        private static void ListOutProd() 
        {
            string[] ProductDetails;
            string Path = @"C:\BillingSystem\Products\";
            string[] files = Directory.GetFiles(Path);
            Console.WriteLine("List Of Products...");
            Console.WriteLine("Product Id....Product Name....Price");
            foreach (string file in files)
            {
                ProductDetails = Convert.ToString(File.ReadAllText(file)).Split(",");
                Console.WriteLine(ProductDetails[0]+"...."+ProductDetails[1]+"...."+ProductDetails[2]);
            }
        }
    }
}
