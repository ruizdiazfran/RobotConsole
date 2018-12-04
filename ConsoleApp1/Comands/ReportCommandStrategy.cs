using RobotService.Interface;

namespace RobotService.Commands
{
    /// <summary>
    /// Class report command
    /// </summary>
    /// <seealso cref="RobotService.Interface.ICommandStrategy" />
    public class ReportCommandStrategy : ICommandStrategy
    {
        #region Members

        /// <summary>
        /// The robot command
        /// </summary>
        private IRobotCommand _robotCommand;

        #endregion

        #region Constructor 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportCommandStrategy"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        public ReportCommandStrategy(IRobotCommand command)
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
            if (input == null)
            {
                return _robotCommand.Report();
            }

            return string.Empty;
        }
    }
}
