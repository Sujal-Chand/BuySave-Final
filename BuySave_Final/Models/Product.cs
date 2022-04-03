using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuySave_Final.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Display(Name = "Catagory")]
        public int CatagoryID { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Upload Date")]
        public DateTime CreatedDate { get; set; }
        public ICollection<Review> Review { get; set; }
        public Catagory Catagory { get; set; }
    }
}
