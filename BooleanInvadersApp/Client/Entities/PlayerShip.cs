namespace BooleanInvadersApp.Client.Entities
{
    public class PlayerShip
    {
        public int X { get; set; } // X-coordinate
        public int Y { get; set; } // Y-coordinate
        public int Width { get; } = 50; // Width of the ship
        public int Height { get; } = 20; // Height of the ship
        public int Speed { get; } = 5; // Movement speed
    }
}
