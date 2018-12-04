using RobotService.Interface;
using System;

namespace RobotService.Commands
{
    /// <summary>
    /// class Place command
    /// </summary>
    /// <seealso cref="RobotService.Interface.ICommandStrategy" />
    public class PlaceCommandStrategy : ICommandStrategy
    {
        #region Members

        /// <summary>
        /// The robot command
        /// </summary>
        private IRobotCommand _robotCommand;

        #endregion

        #region Constructor
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceCommandStrategy"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        public PlaceCommandStrategy(IRobotCommand command)
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
            if (input!=null && input.Length == 3)
            {
                if (int.TryParse(input[0].ToString(),out int x))
                {
                    if(int.TryParse(input[1].ToString(),out int y))
                    {
                        if (Enum.TryParse(input[2].ToString(), out EnumDirection currentDirection))
                        {
                            _robotCommand.Place(x, y, currentDirection);
                        }
                    }
                }
            }

            return string.Empty;
        }
    }
}
