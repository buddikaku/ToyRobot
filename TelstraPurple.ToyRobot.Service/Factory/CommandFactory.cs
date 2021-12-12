using System;
using System.Text.RegularExpressions;
using TelstraPurple.ToyRobot.Common;

namespace TelstraPurple.ToyRobot.Service
{
    /// <summary>
    /// Command Factory
    /// </summary>
    public class CommandFactory : ICommandFactory
    {
        /// <summary>
        /// Get Command
        /// </summary>
        /// <param name="commandString"></param>
        /// <returns>Command</returns>
        public ICommand GetCommand(string commandString)
        {
            commandString = commandString.ToUpper().Trim();

            if (Regex.IsMatch(commandString, @"(PLACE\s-?\d+,-?\d+(,NORTH|EAST|SOUTH|WEST)?)|MOVE|LEFT|RIGHT|REPORT"))
            {
                var commandParameters = commandString.Split(" ");
                Enum.TryParse(commandParameters[0], out Commands command);
                switch (command)
                {
                    case Commands.PLACE:
                        Direction direction = Direction.NONE;
                        var palceParameters = commandParameters[1].Split(",");
                        var x = Convert.ToInt32(palceParameters[0]);
                        var y = Convert.ToInt32(palceParameters[1]);
                        if (palceParameters.Length > 2)
                        {
                            Enum.TryParse(palceParameters[2], out direction);
                        }
                        return new Place(x, y, direction);
                    case Commands.MOVE:
                        return new Move();
                    case Commands.LEFT:
                        return new Left();
                    case Commands.RIGHT:
                        return new Right();
                    case Commands.REPORT:
                        return new Report();
                }
            }
            return null;
        }
    }
}
