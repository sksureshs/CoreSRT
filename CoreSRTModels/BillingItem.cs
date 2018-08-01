using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreSRTModels
{
    public class BillingItem
    {
        [Key]
        public int BillingItmeId { get; set; }
        [Required]
        public Item Item { get; set; }
        [Required]
        public double OriginalPrice { get; set; }
        [Required]
        public double SellingPrice { get; set; }
        [Required]
        public double CGST { get; set; }
        [Required]
        public double SGCT { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double TotalPrice { get; set; }
    }
}
