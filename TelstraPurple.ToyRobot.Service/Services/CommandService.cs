using System.Collections.Generic;

namespace TelstraPurple.ToyRobot.Service
{
    /// <summary>
    /// The command service
    /// </summary>
    public class CommandService : ICommandService
    {
        private IList<ICommand> commandsList;
        private IPoint point;

        /// <summary>
        /// Instantiate the command service
        /// </summary>
        /// <param name="point">Point object</param>
        public CommandService(IPoint point)
        {
            this.point = point;
            this.commandsList = new List<ICommand>();
        }

        /// <summary>
        /// Add command to the commands sequence
        /// </summary>
        /// <param name="command">Command object</param>
        public void AddCommands(ICommand command)
        {
            this.commandsList.Add(command);
        }

        /// <summary>
        /// Process commands sequence
        /// </summary>
        /// <returns>Final point of the robot</returns>
        public IPoint ProcessCommands()
        {
            foreach (var command in this.commandsList)
            {
                command.Execute(this.point);
            }

            return this.point;
        }

    }
}
