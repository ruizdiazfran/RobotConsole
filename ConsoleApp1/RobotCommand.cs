using RobotService.Interface;

namespace RobotService
{
    public class RobotCommand : IRobotCommand
    {
        #region Members

        private IRobotPosition _position;

        #endregion

        #region Constructor

        public RobotCommand(IRobotPosition position, int dimension = 5)
        {
            _position = position;
            _position.SetDimension(dimension);

        }

        #endregion

        #region Operations        

        /// <summary>
        /// Places the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="direction">The direction.</param>
        public void Place(int x, int y, EnumDirection direction)
        {
            _position.Set(x, y, direction);
        }

        /// <summary>
        /// Moves this instance.
        /// </summary>
        public void Move()
        {
            _position.ChangePosition();
        }

        /// <summary>
        /// Lefts this instance.
        /// </summary>
        public void Left()
        {
            _position.ChangeDirection(EnumTurn.LEFT);
        }

        /// <summary>
        /// Rights this instance.
        /// </summary>
        public void Right()
        {
            _position.ChangeDirection(EnumTurn.RIGHT);
        }

        /// <summary>
        /// Reports this instance.
        /// </summary>
        /// <returns></returns>
        public string Report()
        {
            return _position.Get();
        } 
        
        #endregion
    }
}
