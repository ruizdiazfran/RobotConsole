namespace RobotService.Interface
{
    /// <summary>
    /// Interface Commands Strategy Patterns
    /// </summary>
    public interface ICommandStrategy
    {
        /// <summary>
        /// Invokes the comand.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        string InvokeComand(params object[] input);
    }
}
