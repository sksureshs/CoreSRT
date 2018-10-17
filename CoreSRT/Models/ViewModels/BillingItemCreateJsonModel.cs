using System;
namespace CoreSRT.Models.ViewModels
{
    public class BillingItemCreateJsonModel
    {
        public int BillingItemId { get; set; }
        public double OriginalPrice { get; set; }
        public double SellingPrice { get; set; }
        public double CGST { get; set; }
        public double SGST { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
