using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Customer
    {

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Customer name")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public string Email { get; set; }
    
        public int VisaNumber { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public ICollection <Order> OrdersList { get; set; }
        public ICollection <Product_Customer> CustomerList { get; set; }
        

    }
}
