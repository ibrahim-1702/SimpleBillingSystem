using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleBillingSystem;

namespace SimpleBillingSystem
{
    public class BillItem
    {
        private Product product;

        private int Qty;
        private double PerUnitCost;
        private double cost;

        public Product Product 
        {
            get { return product; }
        }

        public double Cost 
        {
            get { return cost; }
        }

        public BillItem(Product ScanedProduct,int QtyOfTheProduct) 
        {
            product = ScanedProduct;
            
            Qty = QtyOfTheProduct;
            PerUnitCost = ScanedProduct.Price;
            cost = PerUnitCost * Qty;
        }

        public override string ToString()
        {
            return product.ProductID + "\t\t" + product.ProductName + "\t\t" + Qty + "\t" + PerUnitCost + "\t\t" + Cost;
        }

    }
}
