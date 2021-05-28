using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TLMart_ASP.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public int TotalPoint { get; set; }

        public string Ranking { get; set; }

        public int Status { get; set; }
    }
}
