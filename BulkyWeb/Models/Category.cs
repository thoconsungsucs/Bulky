﻿using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        [MaxLength(20)]
        public String Name { get; set; }
        [Display(Name = "Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be in 1-100")]
        public int DisplayOrder { get; set; }
    }
}

