

using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Detail{ get; set; }
        public string ?ImageUrl { get; set; }
        [Required]
        [Range(1,100), DataType(DataType.Currency)]

        public decimal Price { get; set; } 
        public bool IsTrendingProduct { get; set; }
    }
}
