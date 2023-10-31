using BooleanInvadersApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BooleanInvadersApp.Server.Data
{
    public class HighScoreContext : DbContext
    {
        public HighScoreContext(DbContextOptions<HighScoreContext> options) : base(options) { }
        public DbSet<HighScore> HighScores { get; set; }
    }
}