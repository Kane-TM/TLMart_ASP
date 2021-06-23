using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TLMart_ASP.Models
{
    public class ImportInvoiceDetail
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int ImportInvoiceId { get; set; }

        [Required]
        public string ProdcutId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
