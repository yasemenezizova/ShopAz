using ShopAz.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAz.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        [Required(ErrorMessage = "Url is a required field.")]
        public string Url { get; set; }

        
        public double? Price { get; set; }

        [Required(ErrorMessage = "Description is a required field.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Description Must be in the range of 5-100 characters.")]

        public string Description { get; set; }

        [Required(ErrorMessage = "ImageUrl is a required field.")]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }

    }
}
