namespace CoreSRT.Models.ViewModels
{
    public class BillIndexViewModel
    {
        public int BillId { get; set; }
        public string Customer { get; set; }
        public  int TotalQuantity { get; set; }
        public double TotalAmount { get; set; }
    }
}