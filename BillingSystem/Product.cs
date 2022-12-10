﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace BillingSystem
{
    public class Product
    {

        public static string ProductPath = @"C:\BillingSystem\Products\";
        public string ProductId;
        public string ProductName;
        public string ProductPrice;
        public string ProductDiscount;
        public string ProductTax;
        public Product() { }
        public Product(string productId, string productName, string productPrice, string productDiscount, string productTax)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductDiscount = productDiscount;
            ProductTax = productTax;
        }
            public static Product GetProductDetails(Product product)
        {

            Console.WriteLine("Enter The Product Name: ");
            product.ProductName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Price: ");
            product.ProductPrice = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Discounts: ");
            product.ProductDiscount = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Taxes: ");
            product.ProductTax = Convert.ToString(Console.ReadLine());

            return product;
        }
        public static void SaveProduct(Product temp) 
        {
            int RandomNumber = new Random().Next(1000, 9999);
            temp.ProductId = "Prod" + RandomNumber;

            FileStream fs = File.Create(ProductPath+temp.ProductId);
            fs.Close();
            StreamWriter writer = new StreamWriter(ProductPath+temp.ProductId);
            writer.WriteLine(temp.ProductId+','+temp.ProductName+','+temp.ProductPrice+','+ temp.ProductDiscount + ','+ temp.ProductTax);
            writer.Close();
        }

        
        public static void ProductMode()
        {
            Console.WriteLine("What to enter a new product (y/n)?");
            char YorNo = Convert.ToChar(Console.ReadLine());
            if (YorNo == 'y' || YorNo == 'Y')
            {
                Console.WriteLine("");
            }
        }
    }
}
