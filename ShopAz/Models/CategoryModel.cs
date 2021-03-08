using ShopAz.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAz.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Enter a value between 5-100 for the category.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Url is required.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Enter a value between 5-100 for the url.")]

        public string Url { get; set; }

        public List<Product> Products { get; set; }
    }
}
