using System;
namespace CoreSRT.Models.ViewModels
{
    public class CustomerViewModel
    {

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EmailId { get; set; }
        public string ContactNumber { get; set; }
        public string GSTNo { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
    }
}
