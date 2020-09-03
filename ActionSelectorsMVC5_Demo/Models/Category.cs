using System.ComponentModel.DataAnnotations;

namespace ActionSelectorsMVC5_Demo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Category")]
        [StringLength(100)]
        public string CategoryName { get; set; }
    }
}