using HEProducts.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEProducts.Core.ViewModel
{
    public class ProductManagerViewModel
    {
        public Product Product { get; set; }//object
        public IEnumerable<ProductCategory> productCategories { get; set; }//collection
    }
}
