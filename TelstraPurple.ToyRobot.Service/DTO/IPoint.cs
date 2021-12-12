using TelstraPurple.ToyRobot.Common;

namespace TelstraPurple.ToyRobot.Service
{
    /// <summary>
    /// A point in the tabletop
    /// </summary>
    public interface IPoint
    {
        /// <summary>
        /// X coordinate of tabletop
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Y coordinate of tabletop
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Direction of Robot
        /// </summary>
        public Direction Direction { get; set; }

        /// <summary>
        /// Final robot location
        /// </summary>
        public string OutString { get; set; }

    }
}
