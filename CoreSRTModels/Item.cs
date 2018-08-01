using System;
using System.ComponentModel.DataAnnotations;

namespace CoreSRTModels
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public double CGST { get; set; }
        [Required]
        public double SGST { get; set; }
        [Required]
        public DateTime DateFrom { get; set; }
        [Required]
        public DateTime DateTo { get; set; }
    }
}
