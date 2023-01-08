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
        private int qty;
        private double cost;

        public Product Product 
        {
            get { return product; }
        }

        public double Cost 
        {
            get { return cost; }
        }

        public int Qty {
            get { return qty; }
        }

        public BillItem(Product ScanedProduct,int QtyOfTheProduct) 
        {
            product = ScanedProduct;
            qty = QtyOfTheProduct;
            cost = product.Price * Qty;
        }

        public override string ToString()
        {
            return product.ProductID + "\t\t" + product.ProductName + "\t\t" + Qty + "\t" + product.Price + "\t\t" + Cost;
        }

    }
}
