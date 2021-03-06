﻿using RobotService.Interface;

namespace RobotService.Commands
{
    /// <summary>
    /// Class left command
    /// </summary>
    /// <seealso cref="ICommandStrategy" />
    public class LeftCommandStrategy : ICommandStrategy
    {
        #region Members

        /// <summary>
        /// The robot command
        /// </summary>
        private IRobotCommand _robotCommand;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LeftCommandStrategy"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        public LeftCommandStrategy(IRobotCommand command)
        {
            _robotCommand = command;
        }

        #endregion

        /// <summary>
        /// Invokes the comand.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public string InvokeComand(string[] input)
        {
            _robotCommand.Left();
            return string.Empty;
        }
    }
}
