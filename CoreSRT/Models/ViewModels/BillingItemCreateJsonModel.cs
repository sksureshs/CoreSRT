using System;
using System.ComponentModel.DataAnnotations;

namespace CoreSRT.Models.ViewModels
{
    public class BillingItemCreateJsonModel
    {
        [Required]
        public int ItemId { get; set; }
        [Required]
        public int BillingItemId { get; set; }
        [Required]
        public double OriginalPrice { get; set; }
        [Required]
        public double SellingPrice { get; set; }
        [Required]
        public double CGST { get; set; }
        [Required]
        public double SGST { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double TotalPrice { get; set; }
    }
}
