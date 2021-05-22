using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utopiaSneakerShop
{
    class ProductClass
    {
        private int productID;
        private string color;
        private double price;
        private string styleCode;
        private string condition;
        private int modelID;

        public ProductClass(int productID, string color, double price, string styleCode, string condition, int modelID)
        {
            this.productID = productID;
            this.color = color;
            this.price = price;
            this.styleCode = styleCode;
            this.condition = condition;
            this.modelID = modelID;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string Color { get => color; set => color = value; }
        public double Price { get => price; set => price = value; }
        public string StyleCode { get => styleCode; set => styleCode = value; }
        public string Condition { get => condition; set => condition = value; }
        public int ModelID { get => modelID; set => modelID = value; }
        public override string ToString()
        {
            return this.color;
        }
    }
}
