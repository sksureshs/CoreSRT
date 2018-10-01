using System;
namespace CoreSRT.Models.ViewModels
{
    public class BillViewModel
    {
        public int BillNo
        {
            get;
            set;
        }
        public string CustomerName
        {
            get;
            set;
        }
        public decimal Total
        {
            get;
            set;
        }
    }
}
