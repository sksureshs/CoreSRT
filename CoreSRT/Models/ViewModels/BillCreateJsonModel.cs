using System;
using System.Collections.Generic;

namespace CoreSRT.Models.ViewModels
{
    public class BillCreateJsonModel
    {
        public int CustomerId { get; set; }
        public IList<BillingItemCreateJsonModel> Items { get; set; }
    }
}
