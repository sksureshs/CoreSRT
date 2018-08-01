using System;

namespace CoreSRT.Models.ViewModels
{
    public class ItemViewModel
    {
        public string Description { get; set; }
        
        public double Rate { get; set; }
        
        public double CGST { get; set; }
        
        public double SGST { get; set; }
        
        public DateTime DateFrom { get; set; }
        
        public DateTime DateTo { get; set; }
    }
}
