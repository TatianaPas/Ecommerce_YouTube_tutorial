using Ecommerce_YouTube_tutorial.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce_YouTube_tutorial.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string PictureUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductCategory Category { get; set; }
        public Color Colors { get; set; }
        public int Size { get; set; }
        public double Price { get; set; }
    }
}
