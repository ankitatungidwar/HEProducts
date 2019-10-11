using HEProducts.Core.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEProducts.DataAccess.SQL
{
    public class DataContext : DbContext//class of EF
    {
        public DataContext() :base("mycon")
        { }

        public DbSet<Product> Products { get; set; } //bdset is collection
        public DbSet<ProductCategory> ProductCategories { get; set; }

    }
}
