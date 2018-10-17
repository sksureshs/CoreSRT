using System;
using System.ComponentModel.DataAnnotations;
namespace CoreSRT.Models.ViewModels
{
    public class BillPrintItemViewModel
    {
        public int BillingItemId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double CGST { get; set; }
        [Required]
        public double SGST { get; set; }
        [Required]
        public int Quantity { get; set; }

        public double CGSTAmount { get { return Price * (CGST / 100d); } }

        public double SGSTAmount { get { return Price * (SGST / 100d);  }}
        [Required]
        public double TotalPrice { get{
                return (Price + CGSTAmount + SGSTAmount) * Quantity;
            } }
    }
}
