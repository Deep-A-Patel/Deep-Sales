using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Deep_Sales.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [RegularExpression("^[a-zA-Z0-9 ]*$")]
        [Required]
        [StringLength(55, ErrorMessage = "Please shorten the product name to 55 characters")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }
        [Display(Name ="Image")]
        public string ImagePath { get; set; }

        [Required]
        public string UserId { get; set; }


        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Posted On")]
        public DateTime DateCreated { get; set; }


    }
}
