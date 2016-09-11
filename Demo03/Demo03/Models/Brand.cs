using System.Collections.Generic;

namespace Demo03.Models
{
    public class Brand
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}