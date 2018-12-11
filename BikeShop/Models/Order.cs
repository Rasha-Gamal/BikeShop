using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public class Order
    {

        [Key]
        public int OrderID { get; set; }


        [required][Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd:yyyy:mm}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }


        // forgein key customer id 
        public int CustomerID { get; set; }
        public Customer _Customers { get; set; }


        //forgein key product id 
        public int ProductId { get; set; }
        public Product _Prod { get; set; }

    }
}
