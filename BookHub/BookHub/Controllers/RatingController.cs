﻿using DataAccessLayer.Data;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly BookHubDbContext _context;

        public RatingController(BookHubDbContext context)
        {
            _context = context;
        }

        // GET: api/Rating
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Rating>>> GetRatings()
        {
            return await _context.Ratings.ToListAsync();
        }

        // GET: api/Rating/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Rating>> GetRating(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);

            if (rating == null)
                return NotFound();

            return rating;
        }

        // PUT: api/Rating/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRating(int id, Rating rating)
        {
            if (id != rating.Id)
                return BadRequest();

            _context.Entry(rating).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RatingExists(id))
                    return NotFound();
                throw;
            }

            return NoContent();
        }

        // POST: api/Rating
        [HttpPost]
        public async Task<ActionResult<Rating>> PostRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRating", new { id = rating.Id }, rating);
        }

        // DELETE: api/Rating/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRating(int id)
        {
            var rating = await _context.Ratings.FindAsync(id);
            if (rating == null)
                return NotFound();

            _context.Ratings.Remove(rating);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RatingExists(int id)
        {
            return _context.Ratings.Any(e => e.Id == id);
        }
    }
}
