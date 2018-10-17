using System;
using System.Collections.Generic;

namespace CoreSRT.Models.ViewModels
{
    public class BillingCreateViewModel
    {
        public IList<CustomerViewModel> Customers { get; set; }
        public int CustomerId { get; set; }
    }
}
