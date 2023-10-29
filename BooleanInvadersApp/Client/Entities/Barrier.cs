namespace BooleanInvadersApp.Client.Entities
{
    public class Barrier
    {
        public int X { get; set; } // X-coordinate
        public int Y { get; set; } // Y-coordinate
        public int Width { get; } = 60; // Width of the barrier
        public int Height { get; } = 20; // Height of the barrier
    }
}
