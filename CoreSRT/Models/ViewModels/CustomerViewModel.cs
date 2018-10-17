using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreSRT.Models.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            Types = new List<CustomerTypeView>{
                new CustomerTypeView{
                    TypeId = 1,
                    Type  = "Retailer"
                },
                new CustomerTypeView{
                    TypeId = 2,
                    Type = "Distributor"
                }
            };
            TypeId = 0;
        }

        public int CustomerId { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }
        [StringLength(200, MinimumLength = 20)]
        [Required]
        public string Address { get; set; }
        public string EmailId { get; set; }
        [StringLength(10, MinimumLength = 9)]
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string GSTNo { get; set; }
        [Required]
        public int TypeId { get; set; }
        public List<CustomerTypeView> Types{ get; set; }
    }

    public class CustomerTypeView
    {
        public int TypeId { get; set; }
        public string Type { get; set; }
    }
}
