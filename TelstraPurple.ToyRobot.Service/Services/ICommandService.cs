
namespace TelstraPurple.ToyRobot.Service
{
    /// <summary>
    /// The command service
    /// </summary>
    public interface ICommandService
    {
        /// <summary>
        /// Add command to the commands sequence
        /// </summary>
        /// <param name="command">Command object</param>
        public void AddCommands(ICommand command);

        /// <summary>
        /// Process commands sequence
        /// </summary>
        /// <returns>Final point of the robot</returns>
        public IPoint ProcessCommands();
    }
}
