using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreSRT.Models.ViewModels
{
    public class BillCreateJsonModel
    {
        [Required]
        public int CustomerId { get; set; }
        public DateTime BillDate { get; set; }
        public IList<BillingItemCreateJsonModel> Items { get; set; }
    }
}
