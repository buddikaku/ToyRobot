using System.Collections.Generic;

namespace TelstraPurple.ToyRobot.Service
{
    /// <summary>
    /// The command service
    /// </summary>
    public class CommandService : ICommandService
    {
        private IList<ICommand> commands;
        private Point point;

        /// <summary>
        /// Instantiate the command service
        /// </summary>
        /// <param name="point">Point object</param>
        public CommandService(Point point)
        {
            this.point = point;
            this.commands = new List<ICommand>();
        }

        /// <summary>
        /// Add command to the commands sequence
        /// </summary>
        /// <param name="command">Command object</param>
        public void AddCommands(ICommand command)
        {
            this.commands.Add(command);
        }

        /// <summary>
        /// Process commands sequence
        /// </summary>
        /// <returns>Final point of the robot</returns>
        public Point ProcessCommands()
        {
            foreach (var command in this.commands)
            {
                command.Execute(this.point);
            }

            return this.point;
        }
    }
}
