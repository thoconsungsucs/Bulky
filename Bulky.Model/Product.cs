using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BulkyBook.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public String Description { get; set; }
        [Required]
        public String ISBN { get; set; }
        [Required]
        public String Author { get; set; }
        [Required]
        [Display(Name = "List Price")]
        public double? ListPrice { get; set; }

        [Required]
        [Display(Name = "Price 1+")]
        public double? Price { get; set; }

        [Required]
        [Display(Name = "Price 50+")]
        public double? Price50 { get; set; }

        [Required]
        [Display(Name = "Price 100+")]
        public double? Price100 { get; set; }
        [Display(Name = "Category ID")]
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [Required]
        [ValidateNever]
        public string ImageUrl { get; set; }
    }
}
