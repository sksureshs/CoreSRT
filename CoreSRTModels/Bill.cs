using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreSRTModels
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        [Required]
        public Customer ShopId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int TotalQuantity { get; set; }
        [Required]
        public Double TotalPrice { get; set; }
        [Required]
        public IList<Payment> Payments { get; set; }
        [Required]
        public Double OutStandingAmount { get; set; }
    }

    public enum BillStatus
    {
        Pending = 0,
        PartiallyPaid = 1,
        Cleared  = 2
    }
}   

