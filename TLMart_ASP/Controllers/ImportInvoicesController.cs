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
    public class ImportInvoicesController : ControllerBase
    {
        private readonly TLMartContext _context;

        public ImportInvoicesController(TLMartContext context)
        {
            _context = context;
        }

        // GET: api/ImportInvoices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ImportInvoice>>> GetImportInvoices()
        {
            return await _context.ImportInvoices.ToListAsync();
        }

        // GET: api/ImportInvoices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ImportInvoice>> GetImportInvoice(int id)
        {
            var importInvoice = await _context.ImportInvoices.FindAsync(id);

            if (importInvoice == null)
            {
                return NotFound();
            }

            return importInvoice;
        }

        // PUT: api/ImportInvoices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImportInvoice(int id, ImportInvoice importInvoice)
        {
            if (id != importInvoice.Id)
            {
                return BadRequest();
            }

            _context.Entry(importInvoice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImportInvoiceExists(id))
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

        // POST: api/ImportInvoices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ImportInvoice>> PostImportInvoice(ImportInvoice importInvoice)
        {
            _context.ImportInvoices.Add(importInvoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetImportInvoice", new { id = importInvoice.Id }, importInvoice);
        }

        // DELETE: api/ImportInvoices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImportInvoice(int id)
        {
            var importInvoice = await _context.ImportInvoices.FindAsync(id);
            if (importInvoice == null)
            {
                return NotFound();
            }

            _context.ImportInvoices.Remove(importInvoice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ImportInvoiceExists(int id)
        {
            return _context.ImportInvoices.Any(e => e.Id == id);
        }
    }
}
