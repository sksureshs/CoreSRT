using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreSRT.Models.ViewModels
{
    public class BillPrintViewModel
    {
        public int BillNo { get; set; }
        public DateTime BillDate { get; set; }
        public CustomerViewModel Seller { get; set; }
        public CustomerViewModel Buyer { get; set; }

        public IList<BillPrintItemViewModel> Items { get; set; }

        public int TotalQuantity { get { return Items.Count(); } }
        public double TotalAmount { get{
                return Items.Sum(i => i.TotalPrice);
            } }
    }
}
