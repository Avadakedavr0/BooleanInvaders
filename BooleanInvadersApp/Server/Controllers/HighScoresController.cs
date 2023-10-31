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

        [HttpPost]
        public async Task<IResult> CreateHighScore(HighScore highScore)
        {
            _context.HighScores.Add(highScore);
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