namespace BooleanInvadersApp.Client.Entities
{
    public class PlayerBullet
    {
        public int X { get; set; } // X-coordinate
        public int Y { get; set; } // Y-coordinate
        public int Speed { get; } = 10; // Movement speed
    }
}
