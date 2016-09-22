using System.Collections.Generic;

namespace ForeignKey.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CUST_NAME { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}