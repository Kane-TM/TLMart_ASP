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
    public class SellInvoiceDetailsController : ControllerBase
    {
        private readonly TLMartContext _context;

        public SellInvoiceDetailsController(TLMartContext context)
        {
            _context = context;
        }

        // GET: api/SellInvoiceDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SellInvoiceDetail>>> GetSellInvoiceDetails()
        {
            return await _context.SellInvoiceDetails.ToListAsync();
        }

        // GET: api/SellInvoiceDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SellInvoiceDetail>> GetSellInvoiceDetail(int id)
        {
            var sellInvoiceDetail = await _context.SellInvoiceDetails.FindAsync(id);

            if (sellInvoiceDetail == null)
            {
                return NotFound();
            }

            return sellInvoiceDetail;
        }

        // PUT: api/SellInvoiceDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSellInvoiceDetail(int id, SellInvoiceDetail sellInvoiceDetail)
        {
            if (id != sellInvoiceDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(sellInvoiceDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SellInvoiceDetailExists(id))
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

        // POST: api/SellInvoiceDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SellInvoiceDetail>> PostSellInvoiceDetail(SellInvoiceDetail sellInvoiceDetail)
        {
            _context.SellInvoiceDetails.Add(sellInvoiceDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSellInvoiceDetail", new { id = sellInvoiceDetail.Id }, sellInvoiceDetail);
        }

        // DELETE: api/SellInvoiceDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSellInvoiceDetail(int id)
        {
            var sellInvoiceDetail = await _context.SellInvoiceDetails.FindAsync(id);
            if (sellInvoiceDetail == null)
            {
                return NotFound();
            }

            _context.SellInvoiceDetails.Remove(sellInvoiceDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SellInvoiceDetailExists(int id)
        {
            return _context.SellInvoiceDetails.Any(e => e.Id == id);
        }
    }
}
