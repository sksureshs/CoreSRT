using System;
using System.ComponentModel.DataAnnotations;

namespace CoreSRTModels
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string EmailId { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string GSTNo { get; set; }
        [Required]
        public CustomerType Type { get; set; }
    }

    public enum CustomerType
    {
        Retailer = 0,
        Distributor = 1
    }
}
