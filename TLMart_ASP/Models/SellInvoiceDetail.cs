using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TLMart_ASP.Models
{
    public class SellInvoiceDetail
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int SellInvoiceId { get; set; }

        [Required]
        public string ProductId { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
