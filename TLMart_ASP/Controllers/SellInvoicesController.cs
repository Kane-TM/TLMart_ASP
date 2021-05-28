using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TLMart_ASP.Data;
using TLMart_ASP.Models;

namespace TLMart_ASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellInvoicesController : ControllerBase
    {
        private readonly TLMartContext _context;

        public SellInvoicesController(TLMartContext context)
        {
            _context = context;
        }

        // GET: api/SellInvoices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SellInvoice>>> GetSellInvoices()
        {
            return await _context.SellInvoices.ToListAsync();
        }

        // GET: api/SellInvoices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SellInvoice>> GetSellInvoice(int id)
        {
            var sellInvoice = await _context.SellInvoices.FindAsync(id);

            if (sellInvoice == null)
            {
                return NotFound();
            }

            return sellInvoice;
        }

        // PUT: api/SellInvoices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSellInvoice(int id, SellInvoice sellInvoice)
        {
            if (id != sellInvoice.Id)
            {
                return BadRequest();
            }

            _context.Entry(sellInvoice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SellInvoiceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SellInvoices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SellInvoice>> PostSellInvoice(SellInvoice sellInvoice)
        {
            _context.SellInvoices.Add(sellInvoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSellInvoice", new { id = sellInvoice.Id }, sellInvoice);
        }

        // DELETE: api/SellInvoices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSellInvoice(int id)
        {
            var sellInvoice = await _context.SellInvoices.FindAsync(id);
            if (sellInvoice == null)
            {
                return NotFound();
            }

            _context.SellInvoices.Remove(sellInvoice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SellInvoiceExists(int id)
        {
            return _context.SellInvoices.Any(e => e.Id == id);
        }
    }
}
