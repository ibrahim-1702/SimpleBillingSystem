using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace SimpleBillingSystem
{


    public class Product
    {

        public static Dictionary<string, Product> Products = new Dictionary<string, Product>();

        public Product() { }
        private string productID;
        private string productName;
        private double price;
        private double taxPerQty;
        private double discountPerQty;

        

        public string ProductID 
        {
            get { return productID; }
            set { productID = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double TaxPerQty
        {
            get { return taxPerQty; }
            set { taxPerQty = value; }
        }

        public double DiscountPerQty
        {
            get { return discountPerQty; }
            set { discountPerQty = value; }
        }
        public Product(string ProductID, string ProductName,int Cost, int TaxPerQty, int DiscountPerQty) 
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            Price = Cost;
            this.TaxPerQty = TaxPerQty;
            this.DiscountPerQty = DiscountPerQty;
        }


        public static void fetchAllProds(string path) 
        {
            string[] ProdArr;
            ProdArr = File.ReadAllLines(path);
            Products.Clear();
            int NumberOfProducts = ProdArr.Length;
            
            for (int i = 0; i < NumberOfProducts; i++) 
            {
                Product product = new Product(ProdArr[i].Split('|')[0], ProdArr[i].Split('|')[1], int.Parse(ProdArr[i].Split('|')[2]), int.Parse(ProdArr[i].Split('|')[3]), int.Parse(ProdArr[i].Split('|')[4]));
                Products.Add(ProdArr[i].Split('|')[0], product);
            }
        }

        public void AddProd(string path) 
        {
            TextWriter Pen = new StreamWriter(path, true);
            string ProductProperties = productID + '|' + productName + '|' + price+ '|' + taxPerQty + '|' + discountPerQty;
            Pen.WriteLine(ProductProperties);
            Pen.Close();
        }

    }
}
