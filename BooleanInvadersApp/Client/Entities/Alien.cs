namespace BooleanInvadersApp.Client.Entities
{
    public class Alien
    {
        public double X { get; set; } // X-coordinate
        public double Y { get; set; } // Y-coordinate
        public int Width { get; } = 40; // Width of the alien
        public int Height { get; } = 40; // Height of the alien
        public bool MovingRight { get; set; } = true;
        public double moveAccumulator { get; set; } = 0;

    }
}
