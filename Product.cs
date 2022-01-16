using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppL14
{
    public enum ProductCategory
    {
        Food,
        Tech
    }
    public class  Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public ProductCategory Category { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }

}
