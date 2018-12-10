using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Category
    {

        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category name")]
        public string CategoryName { get; set; }



        public ICollection<Product> ProductsList { get; set; }
    }
}
