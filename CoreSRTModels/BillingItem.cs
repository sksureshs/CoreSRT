using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreSRTModels
{
    public class BillingItem
    {
        [Key]
        public int BillingItemId { get; set; }
        [Required]
        public Bill Bill { get; set; }

        public int ItemId { get; set; }
        [Required]
        public Item Item { get; set; }
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

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
