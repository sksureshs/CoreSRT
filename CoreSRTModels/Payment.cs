using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreSRTModels
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [Required]
        public int BillId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public PaymentType PayemntType { get; set; }
        [Required]
        public double Amount { get; set; }
        public string Details { get; set; }
    }

   public enum PaymentType
    {
        Cash = 0,
        DebitCard = 1,
        CreditCard = 2,
        InternetTransfer = 3
    }    
}
