using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deep_Sales.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
