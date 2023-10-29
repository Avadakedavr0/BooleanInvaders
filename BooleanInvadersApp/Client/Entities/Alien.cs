namespace BooleanInvadersApp.Client.Entities
{
    public class Alien
    {
        public int X { get; set; } // X-coordinate
        public int Y { get; set; } // Y-coordinate
        public int Width { get; } = 40; // Width of the alien
        public int Height { get; } = 40; // Height of the alien
        public int Speed { get; } = 2; // Movement speed
        public bool MovingRight { get; set; } = true;

    }
}
