
namespace TelstraPurple.ToyRobot.Service
{
    /// <summary>
    /// Robot commands
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Execute commands
        /// </summary>
        /// <param name="point">Point object</param>
        public void Execute(Point point);
    }
}
