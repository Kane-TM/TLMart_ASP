using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TLMart_ASP.Models
{
    public class ProductType
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string TypeName { get; set; }
    }
}
