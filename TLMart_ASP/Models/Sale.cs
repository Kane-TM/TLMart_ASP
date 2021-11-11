using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TLMart_ASP.Models
{
    public class Sale
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }

        [Required]
        public string SaleId { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string ProductId { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Status { get; set; }
    }
}
