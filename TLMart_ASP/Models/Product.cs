using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TLMart_ASP.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The product name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime MFG { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EXP { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Unit { get; set; }

        public string Note { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        public int Status { get; set; }
    }
}
