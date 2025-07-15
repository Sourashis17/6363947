using System.ComponentModel.DataAnnotations;

namespace _1_Web_API_handson.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
