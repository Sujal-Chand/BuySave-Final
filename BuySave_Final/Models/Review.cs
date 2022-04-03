using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuySave_Final.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        //Username gets pulled from Users class
        [Display(Name = "Username")]
        public int UserID { get; set; }
        //Product name gets pulled from Products class
        [Display(Name = "Product Name")]
        public int ProductID { get; set; }
        //This string contains the written product and website review
        [Display(Name = "Review")]
        public string ReviewText { get; set; }
        //An interger for product rating
        [Display(Name = "Product Rating ?/5")]
        public int ItemRating { get; set; }
        //This string is the URL for the website the user purchased from
        [Display(Name = "Website link")]
        public string WebsiteURL { get; set; }
        //An interger for website rating
        [Display(Name = "Website Rating ?/5")]
        public int WebsiteRating { get; set; }
        [Display(Name = "Price NZD$")]
        public int Price { get; set; }
        //The relationships between the user and product classes
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
