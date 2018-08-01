using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreSRTModels
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        
        public string EmailId { get; set; }
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public AccountDetails AccountDetails { get; set; }
    }

    public class AccountDetails
    {
        [Key]
        public int AccountNo { get; set; }
        [Required]
        public string IFSCCode { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public string Branch { get; set; }
    }
}
