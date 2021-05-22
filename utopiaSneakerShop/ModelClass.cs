using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utopiaSneakerShop
{
    class ModelClass
    {
        private int modelID;
        private string name;
        private int brandID;

        public ModelClass(int modelID, string name, int brandID)
        {
            this.modelID = modelID;
            this.name = name;
            this.brandID = brandID;
        }

        public int ModelID { get => modelID; set => modelID = value; }
        public string Name { get => name; set => name = value; }
        public int BrandID { get => brandID; set => brandID = value; }
        public override string ToString()
        {
            return this.name;
        }
    }
}
