using RobotService.Interface;
using System;

namespace RobotService.Commands
{
    /// <summary>
    /// Class right commands
    /// </summary>
    /// <seealso cref=ICommandStrategy" />
    public class RightCommandStrategy : ICommandStrategy
    {
        #region Members

        /// <summary>
        /// The robot command
        /// </summary>
        private IRobotCommand _robotCommand;

        #endregion

        #region Constructor
        
        /// <summary>
        /// Initializes a new instance of the <see cref="RightCommandStrategy"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        public RightCommandStrategy(IRobotCommand command)
        {
            _robotCommand = command;
        }

        #endregion

        /// <summary>
        /// Invokes the comand.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public string InvokeComand(params object[] input)
        {
            _robotCommand.Right();
            return string.Empty;
        }
    }
}
