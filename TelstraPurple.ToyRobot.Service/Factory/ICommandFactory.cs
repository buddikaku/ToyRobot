namespace TelstraPurple.ToyRobot.Service
{
    /// <summary>
    /// Command Factory
    /// </summary>
    public interface ICommandFactory
    {
        /// <summary>
        /// Get Command
        /// </summary>
        /// <param name="commandString"></param>
        /// <returns>Command</returns>
        public ICommand GetCommand(string commandString);
    }
}
