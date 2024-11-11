using demo.Core.Core;
using demo.Core.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Core.Entities.Categories
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "Category name is required")]
        [StringLength(100, ErrorMessage = "The name cannot exceed 100 characters.")]
        public string Name { get; set; }

        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
