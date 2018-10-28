using System;
using System.ComponentModel.DataAnnotations;

namespace CoreSRTModels
{
    public class BillingItemAudit
    {
       [Key]
        public int BillingItemAuditId { get; set; }

        
        public int BillingItemId { get; set; }
        [Required]
        public int BillId { get; set; }

        public int ItemId { get; set; }
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
    }
}
