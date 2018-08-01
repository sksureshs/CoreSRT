using System;
using System.Collections.Generic;
using System.Text;

namespace CoreSRTModels
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int BillId { get; set; }
        public DateTime Date { get; set; }
        public PaymentType PayemntType { get; set; }
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
