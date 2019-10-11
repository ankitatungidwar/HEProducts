/*using HEProducts.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace HEProducts.DataAccess.InMemory
{
   public class ProductCategoryRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<ProductCategory> productsCategorys;

        public ProductCategoryRepository()
        {
            productsCategorys = cache["productsCategorys"] as List<ProductCategory>;
            if (productsCategorys == null)
            {
                productsCategorys = new List<ProductCategory>();
            }
        }
        public void Commit()
        {
            cache["productsCategorys"] = productsCategorys;
        }

        public void Insert(ProductCategory p)
        {
            productsCategorys.Add(p);
        }

        public void Update(ProductCategory productsCategory)
        {
            ProductCategory productToUpdate =
               productsCategorys.Find(p => p.Id == productsCategory.Id);

            if (productToUpdate != null)
            {
                productToUpdate = productsCategory;
            }
            else
            {
                throw new Exception("Product no found");
            }
        }
        public ProductCategory Find(string Id)
        {
            ProductCategory productsCategory = productsCategorys.Find(p => p.Id == Id);
            if (productsCategory != null)
            {
                return productsCategory;
            }
            else
            {
                throw new Exception("Product no found");
            }
        }

        public IQueryable<ProductCategory> Collection()
        {
            return productsCategorys.AsQueryable();
        }

        public void Delete(string Id)
        {
            ProductCategory productToDelete = productsCategorys.Find(p => p.Id == Id);

            if (productToDelete != null)
            {
                productsCategorys.Remove(productToDelete);
            }
            else
            {
                throw new Exception("Product no found");
            }
        }
    }
}

*/