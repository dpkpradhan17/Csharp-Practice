using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayProductDetails
{
    public class Product
    {
        int ProductId;
        string ProductName;
        float ProductCost;

        public Product(int productID, string ProductName, float ProductCost)
        {
            this.ProductId = productID;
            this.ProductName = ProductName;
            this.ProductCost = ProductCost;
        }

        public int getID() { return this.ProductId; }
        public string getProductName() { return this.ProductName; }
        public float getProductCost() { return this.ProductCost; }
    }
}
