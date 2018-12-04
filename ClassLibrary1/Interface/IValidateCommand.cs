using System.Collections.Generic;

namespace RobotService.Interface
{
    /// <summary>
    /// Interface validation command
    /// </summary>
    public interface IValidateCommand
    {
        /// <summary>
        /// Runs the specified commands.
        /// </summary>
        /// <param name="commands">The commands.</param>
        /// <returns></returns>
        string Run(List<string> commands);
    }
}