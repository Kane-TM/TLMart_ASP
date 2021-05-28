using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TLMart_ASP.Models
{
    public class ImportInvoice
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required]
        public int TotalCash { get; set; }

        [Required]
        public int Status { get; set; }
    }
}
