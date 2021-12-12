using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelstraPurple.ToyRobot.Common;

namespace TelstraPurple.ToyRobot.Service
{
    /// <summary>
    /// Report command
    /// </summary>
    public class Report : ICommand
    {
        /// <summary>
        /// Execute command
        /// </summary>
        /// <param name="point">Point Object</param>
        public void Execute(IPoint point)
        {
            point.OutString = point.Direction == Direction.NONE? 
                "First valid command to the robot is a PLACE command with direction.\nPlease restart and try again." :
                $"Output: {point.X},{point.Y},{point.Direction.ToString()}";
        }
    }
}
