using RobotService.Interface;

namespace RobotService.Commands
{
    public class MoveCommandStrategy : ICommandStrategy
    {
        #region Members

        /// <summary>
        /// The robot command
        /// </summary>
        private IRobotCommand _robotCommand;

        #endregion

        #region Members

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveCommandStrategy"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        public MoveCommandStrategy(IRobotCommand command)
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
            if (input == null)
            {
                _robotCommand.Move();
            }

            return string.Empty;
        }
    }
}
