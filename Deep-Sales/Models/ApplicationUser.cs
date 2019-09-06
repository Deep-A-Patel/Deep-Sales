using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deep_Sales.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() { }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

       

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }

    }
}
