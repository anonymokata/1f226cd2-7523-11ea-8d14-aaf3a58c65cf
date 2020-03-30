namespace WordSearchApplication.Models
{
    public class Coordinate
    {
        public int X { get; }
        public int Y { get; }

        public Coordinate(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Returns a string representation of the coordinate
        /// </summary>
        /// <returns>Returns a string representation of the coordinate: (x,y)</returns>
        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}