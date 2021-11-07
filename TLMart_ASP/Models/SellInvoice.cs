using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TLMart_ASP.Models
{
    public class SellInvoice
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [Required]
        public int StaffId { get; set; }

        public int CustomerId { get; set; }

        public int TotalCash { get; set; }

        [Required]
        public int Status { get; set; }
    }
}
