using System.Data.Entity;

namespace Demo03.Models
{
    public class ProductsContext : DbContext
    {
        // 指定Connection string
        public ProductsContext()
            :base("name=ProductsContext")
        {    
        }

        public DbSet<Product> Products { get; set; }
        
        

    }
}