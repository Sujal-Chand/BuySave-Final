using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuySave_Final.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Display(Name = "Country")]
        public int CountryID { get; set; }
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Join date")]
        public DateTime CreatedDate { get; set; }
        public ICollection<Review> Review { get; set; }
        public Country Country { get; set; }
    }
}
