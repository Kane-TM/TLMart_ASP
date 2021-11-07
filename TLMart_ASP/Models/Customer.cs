using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TLMart_ASP.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public int TotalPoint { get; set; }

        [Required]
        public int Status { get; set; }
    }
}
