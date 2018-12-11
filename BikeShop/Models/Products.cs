using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Product
    {
        public int ProductId { get; set; }


        [Required(ErrorMessage = "You must enter the Product Name")]
        [Display(Name = "Product Name")]
        public String ProductName { get; set; }

        [Required(ErrorMessage = "You must enter the Unit Price")]
        [Display(Name = "Unit Price")]
        [Column(TypeName = "decimal(10,2)")]
        public String ProductPrice { get; set; }

        public String ProductDescription { get; set; }
        public String ProductImage { get; set; }
        public double Discount { get; set; }
        public double Stock { get; set; }

        //forgein key
        public int CategoryID { get; set; }
        public Category Categories { get; set; }

        public ICollection <Product_Customer> CustomerList { get; set; }
        public IEnumerable<Product_Customer> ProductList { get; internal set; }
    }
}
