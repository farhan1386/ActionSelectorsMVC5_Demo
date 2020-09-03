using System.ComponentModel.DataAnnotations;

namespace ActionSelectorsMVC5_Demo.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}