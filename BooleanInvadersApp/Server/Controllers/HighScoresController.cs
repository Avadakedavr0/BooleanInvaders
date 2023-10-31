using BooleanInvadersApp.Server.Data;
using BooleanInvadersApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BooleanInvadersApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HighScoresController : ControllerBase
    {
        private readonly HighScoreContext _context;

        public HighScoresController(HighScoreContext context)
        {
            _context = context;
        }

        [HttpGet("top10")]
        public async Task<IResult> GetTop10Scores()
        {
            var highScores = await _context.HighScores
                                           .OrderByDescending(h => h.Score)
                                           .Take(10)
                                           .ToListAsync();
            return Results.Ok(highScores);
        }

        [HttpPost]
        public async Task<IResult> CreateHighScore(HighScore highScore)
        {
            if (!ModelState.IsValid)
            {
                return Results.BadRequest(ModelState);
            }

            _context.HighScores.Add(highScore);
            await _context.SaveChangesAsync();

            // Ensure only top 10 scores are retained
            var scoresToDelete = await _context.HighScores
                                               .OrderByDescending(h => h.Score)
                                               .Skip(10)
                                               .ToListAsync();

            _context.HighScores.RemoveRange(scoresToDelete);
            await _context.SaveChangesAsync();

            return Results.Ok(highScore);
        }

        [HttpGet]
        public async Task<IResult> GetHighScores()
        {
            var highScores = await _context.HighScores.ToListAsync();
            return Results.Ok(highScores);
        }

        [HttpPut("{id}")]
        public async Task<IResult> UpdateHighScore(int id, HighScore highScore)
        {
            if (id != highScore.ID)
            {
                return Results.BadRequest();
            }

            _context.Entry(highScore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.HighScores.Any(e => e.ID == id))
                {
                    return Results.NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Results.NoContent();
        }
    }
}