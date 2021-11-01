using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCurrency.Models;

namespace MyCurrency.Controllers
{
    [Route("api/currency-storage")]
    [ApiController]
    public class CurrencyStorageController : ControllerBase
    {
        private readonly CurrencyStorageContext _context;

        public CurrencyStorageController(CurrencyStorageContext context)
        {
            _context = context;
        }

        // GET: api/CurrencyStorage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurrencyStorage>>> GetCurrencyStorages()
        {
            return await _context.CurrencyStorages.ToListAsync();
        }

        // GET: api/CurrencyStorage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurrencyStorage>> GetCurrencyStorage(long id)
        {
            var currencyStorage = await _context.CurrencyStorages.FindAsync(id);

            if (currencyStorage == null)
            {
                return NotFound();
            }

            return currencyStorage;
        }

        // PUT: api/CurrencyStorage/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurrencyStorage(long id, CurrencyStorage currencyStorage)
        {
            if (id != currencyStorage.Id)
            {
                return BadRequest();
            }

            _context.Entry(currencyStorage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurrencyStorageExists(id))
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

        // POST: api/CurrencyStorage
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CurrencyStorage>> PostCurrencyStorage(CurrencyStorage currencyStorage)
        {
            _context.CurrencyStorages.Add(currencyStorage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurrencyStorage", new { id = currencyStorage.Id }, currencyStorage);
        }

        // DELETE: api/CurrencyStorage/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCurrencyStorage(long id)
        {
            var currencyStorage = await _context.CurrencyStorages.FindAsync(id);
            if (currencyStorage == null)
            {
                return NotFound();
            }

            _context.CurrencyStorages.Remove(currencyStorage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CurrencyStorageExists(long id)
        {
            return _context.CurrencyStorages.Any(e => e.Id == id);
        }
    }
}
