using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace BookHub.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PriceController : ControllerBase
{
    private readonly BookHubDbContext _context;

    public PriceController(BookHubDbContext context)
    {
        _context = context;
    }

    // GET: api/Price
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Price>>> GetPrices()
    {
        return await _context.Prices.ToListAsync();
    }

    // GET: api/Price/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Price>> GetPrice(int id)
    {
        var price = await _context.Prices.FindAsync(id);

        if (price == null)
            return NotFound();

        return price;
    }

    // PUT: api/Price/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPrice(int id, Price price)
    {
        if (id != price.Id)
            return BadRequest();

        _context.Entry(price).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PriceExists(id))
                return NotFound();
            throw;
        }

        return NoContent();
    }

    // POST: api/Price
    [HttpPost]
    public async Task<ActionResult<Price>> PostPrice(Price price)
    {
        _context.Prices.Add(price);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetPrice", new { id = price.Id }, price);
    }

    // DELETE: api/Price/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePrice(int id)
    {
        var price = await _context.Prices.FindAsync(id);
        if (price == null)
            return NotFound();

        _context.Prices.Remove(price);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PriceExists(int id)
    {
        return _context.Prices.Any(e => e.Id == id);
    }
}
