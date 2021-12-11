using TelstraPurple.ToyRobot.Common;

namespace TelstraPurple.ToyRobot.Service.Commands
{
    /// <summary>
    /// Right command
    /// </summary>
    public class Right : ICommand
    {
        /// <summary>
        /// Execute commands
        /// </summary>
        /// <param name="point">Point object</param>
        public void Execute(Point point)
        {
            switch (point.Direction)
            {
                case Direction.NORTH:
                    point.Direction = Direction.EAST;
                    break;
                case Direction.EAST:
                    point.Direction = Direction.SOUTH;
                    break;
                case Direction.SOUTH:
                    point.Direction = Direction.WEST;
                    break;
                case Direction.WEST:
                    point.Direction = Direction.NORTH;
                    break;
            }

        }
    }
}
