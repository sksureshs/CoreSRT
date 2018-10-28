using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreSRTModels
{
    public class BillingAudit
    {
        [Key]
        public int BillingAutiId { get; set; }
        

        public int BillId { get; set; }

        public int ShopCustomerId { get; set; }
        [Required]
        public Customer Shop { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int TotalQuantity { get; set; }
        [Required]
        public Double TotalPrice { get; set; }

        public Double OutStandingAmount { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
