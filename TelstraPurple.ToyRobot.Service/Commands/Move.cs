using TelstraPurple.ToyRobot.Common;

namespace TelstraPurple.ToyRobot.Service
{
    /// <summary>
    /// Move command
    /// </summary>
    public class Move : ICommand
    {
        /// <summary>
        /// Execute commands
        /// </summary>
        /// <param name="point">Point object</param>
        public void Execute(IPoint point)
        {
            switch (point.Direction)
            {
                case Direction.NORTH:
                    point.Y++;
                    break;
                case Direction.EAST:
                    point.X++;
                    break;
                case Direction.SOUTH:
                    point.Y--;
                    break;
                case Direction.WEST:
                    point.X--;
                    break;
            }
        }
    }
}
