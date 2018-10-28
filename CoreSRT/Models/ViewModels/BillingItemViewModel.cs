using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CoreSRT.Models.ViewModels
{
    public class BillingItemViewModel
    {
        public int BillingItemId { get; set; }

        public int ItemId { get; set; }
        [Required]
        public string Description { get; set; }
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

        public double CGSTAmount { get; set; }
        public double SGSTAmount { get; set; }
        public double PerItemPrice { get; set; }

        public int Index { get; set; }
        public IList<ItemViewModel> Items { get; set; }

    }
}
