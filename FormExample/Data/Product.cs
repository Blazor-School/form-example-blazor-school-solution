using System.ComponentModel.DataAnnotations;

namespace FormExample.Data
{
    public class Product
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(100, double.MaxValue)]
        public double? Price { get; set; }
    }
}
