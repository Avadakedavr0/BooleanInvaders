using System.ComponentModel.DataAnnotations;

namespace BooleanInvadersApp.Shared.Models
{
    public class HighScore
    {
        public int ID { get; set; }
        [Required]
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}
