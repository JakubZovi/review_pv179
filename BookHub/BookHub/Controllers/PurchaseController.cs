using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookHub.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PurchaseController : ControllerBase
{
    private readonly BookHubDbContext _context;

    public PurchaseController(BookHubDbContext context)
    {
        _context = context;
    }

    // GET: api/Purchase
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Purchase>>> GetPurchases()
    {
        return await _context.Purchases.ToListAsync();
    }

    // GET: api/Purchase/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Purchase>> GetPurchase(int id)
    {
        var purchase = await _context.Purchases.FindAsync(id);

        if (purchase == null) return NotFound();

        return purchase;
    }

    // PUT: api/Purchase/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutPurchase(int id, Purchase purchase)
    {
        if (id != purchase.Id) return BadRequest();

        _context.Entry(purchase).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!PurchaseExists(id))
                return NotFound();
            throw;
        }

        return NoContent();
    }

    // POST: api/Purchase
    [HttpPost]
    public async Task<ActionResult<Purchase>> PostPurchase(Purchase purchase)
    {
        _context.Purchases.Add(purchase);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetPurchase", new { id = purchase.Id }, purchase);
    }

    // DELETE: api/Purchase/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePurchase(int id)
    {
        var purchase = await _context.Purchases.FindAsync(id);
        if (purchase == null) return NotFound();

        _context.Purchases.Remove(purchase);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool PurchaseExists(int id)
    {
        return _context.Purchases.Any(e => e.Id == id);
    }
}