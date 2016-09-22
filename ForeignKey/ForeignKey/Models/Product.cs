using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeignKey.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Brand Brand { get; set; }

        [ForeignKey("Brand")]
        public int Brand_No { get; set; }

        public ICollection<Customer> Customers { get; set; }

    }
}