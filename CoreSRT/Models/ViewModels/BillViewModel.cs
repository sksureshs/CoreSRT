using System;
using System.Collections.Generic;

namespace CoreSRT.Models.ViewModels
{
    public class BillViewModel
    {
        public int BillNo
        {
            get;
            set;
        }

        public CustomerViewModel Customer
        {
            get;
            set;
        }

        public decimal Total
        {
            get;
            set;
        }

        public IList<BillingItemViewModel> BillingItems { get; set; }

        public IList<CustomerViewModel> Customers { get; set; }

        public int CustomerId { get; set; }

        public IList<ItemViewModel> Items { get; set; }
    }
}
