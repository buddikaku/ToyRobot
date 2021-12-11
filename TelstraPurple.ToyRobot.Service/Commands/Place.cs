using TelstraPurple.ToyRobot.Common;

namespace TelstraPurple.ToyRobot.Service
{
    /// <summary>
    /// Place command
    /// </summary>
    class Place : ICommand
    {
        private int x;
        private int y;
        private Direction direction;

        /// <summary>
        /// Private constructor - to enforce instantiation using parameterize constructor 
        /// </summary>
        private Place() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">X coordinate of tabletop </param>
        /// <param name="y">Y coordinate of tabletop</param>
        /// <param name="direction">Robot direction</param>
        public Place(int x,int y, Direction direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }

        /// <summary>
        /// Execute commands
        /// </summary>
        /// <param name="point">Point object</param>
        public void Execute(Point point)
        {
            point.X = this.x;
            point.Y = this.y;
            point.Direction = this.direction;
        }
    }
}
