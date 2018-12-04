using RobotService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotService
{
    public class ValidateCommand : IValidateCommand
    {
        #region Members
        /// <summary>
        /// The strategies dictionary
        /// </summary>
        private static Dictionary<EnumCommand, ICommandStrategy> _strategies;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateCommand"/> class.
        /// </summary>
        /// <param name="strategy">The strategy.</param>
        public ValidateCommand(Dictionary<EnumCommand, ICommandStrategy> strategy)
        {
            _strategies = strategy;
        }

        #endregion

        #region Operations

        /// <summary>
        /// Runs the specified commands.
        /// </summary>
        /// <param name="commands">The commands.</param>
        /// <returns></returns>
        public string Run(List<string> commands)
        {
            var result = string.Empty;

            foreach (var command in commands)
            {
                var delimiterCommands = command.Split(',').ToList();
                var firstCommand = (delimiterCommands != null && delimiterCommands.Count > 0) ? delimiterCommands[0] : string.Empty;

                if (Enum.TryParse(firstCommand, out EnumCommand currentCommand))
                {
                    delimiterCommands.RemoveAt(0);
                    result = _strategies[currentCommand].InvokeComand(delimiterCommands);
                }
            }

            return result;
        } 
        #endregion
    }
}
