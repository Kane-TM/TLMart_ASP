using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TLMart_ASP.Models;

namespace TLMart_ASP.Data
{
    public class TLMartContext : DbContext
    {
        public TLMartContext(DbContextOptions<TLMartContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<Sale> Sales { get; set; }


        public DbSet<SellInvoice> SellInvoices { get; set; }

        public DbSet<SellInvoiceDetail> SellInvoiceDetails { get; set; }

        public DbSet<Staff> Staffs { get; set; }
    }
}

