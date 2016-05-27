using System.ComponentModel.DataAnnotations;

namespace JohanThorner_MVC_2016_05.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [StringLength(maximumLength:30)]
        public string Name { get; set; }
        [StringLength(maximumLength: 150)]
        public string ProductText { get; set; }
        [CheckNameAttribute]
        public string ProductNumber { get; set; }
        [Range(minimum:1 ,maximum:10000)]
        public decimal Price { get; set; }
        [Range(minimum: 1, maximum: 100000)]
        public int ProductsInStock { get; set; }
    }

    
}