using TelstraPurple.ToyRobot.Common;

namespace TelstraPurple.ToyRobot.Service
{
    /// <summary>
    /// A point in the tabletop
    /// </summary>
    public class Point : IPoint
    {
        private int x;
        private int y;
        private int minX;
        private int maxX;
        private int minY;
        private int maxY;
        private string outString;

        /// <summary>
        /// X coordinate of tabletop
        /// </summary>
        public int X
        {
            get { return x; }
            set
            {
                if (value >= minX && value <= maxX)
                {
                    this.x = value;
                };
            }
        }

        /// <summary>
        /// Y coordinate of tabletop
        /// </summary>
        public int Y
        {
            get { return this.y; }
            set
            {
                if (value >= minY && value <= maxY)
                {
                    this.y = value;
                }
            }
        }

        /// <summary>
        /// Direction of Robot
        /// </summary>
        public Direction Direction { get; set; }

        /// <summary>
        /// Final robot location
        /// </summary>
        public string OutString
        {
            get { return this.outString; }
            set
            {
                this.outString = value;
            }
        }



        /// <summary>
        /// Get a new instance of a Point
        /// </summary>
        /// <param name="minX">Minimum value of X coordinate</param>
        /// <param name="minY">Minimum value of Y coordinate</param>
        /// <param name="maxX">Maximum value of X coordinate</param>
        /// <param name="maxY">Maximum value of Y coordinate</param>
        public Point(int minX, int minY, int maxX, int maxY)
        {
            this.maxX = maxX;
            this.maxY = maxY;
            this.minX = minX;
            this.minY = minY;
        }

    }
}
