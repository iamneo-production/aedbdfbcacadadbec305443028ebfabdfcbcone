using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetmicroservicetwo.Models;

namespace dotnetmicroservicetwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly ReviewDbContext _context;

        public ReviewController(ReviewDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Review>>> GetAllReviews()
        {
            var reviews = await _context.Reviews.ToListAsync();
            return Ok(reviews);
        }
[HttpGet("ReviewerNames")]
public async Task<ActionResult<IEnumerable<string>>> Get()
{
    // Project the ReviewTitle property using Select
    var ReviewerNames = await _context.Reviews
        .OrderBy(x => x.ReviewerName)
        .Select(x => x.ReviewerName)
        .ToListAsync();

    return ReviewerNames;
}
        [HttpPost]
        public async Task<ActionResult> AddReview(Review review)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // Return detailed validation errors
            }
            await _context.Reviews.AddAsync(review);
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid Review id");

            var review = await _context.Reviews.FindAsync(id);
              _context.Reviews.Remove(review);
                await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
