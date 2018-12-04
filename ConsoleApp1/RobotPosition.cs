using RobotService.Interface;

namespace RobotService
{
    public class RobotPosition : IRobotPosition
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="RobotPosition"/> class.
        /// </summary>
        public RobotPosition()
        {

        }

        #endregion

        #region Properties

        public int X { get; protected set; }

        /// <summary>
        /// Gets or sets the y.
        /// </summary>
        /// <value>
        /// The y.
        /// </value>
        public int Y { get; protected set; }

        /// <summary>
        /// Gets or sets the direction.
        /// </summary>
        /// <value>
        /// The direction.
        /// </value>
        public EnumDirection Direction { get; protected set; }

        /// <summary>
        /// Gets the dimension.
        /// </summary>
        /// <value>
        /// The dimension.
        /// </value>
        public int Dimension { get; protected set; }
        #endregion

        #region Operations

        /// <summary>
        /// Changes the direction.
        /// </summary>
        /// <param name="current">The current.</param>
        public void ChangeDirection(EnumTurn currentTurn)
        {
            switch (Direction)
            {
                case EnumDirection.WEST:
                    Direction = (currentTurn == EnumTurn.RIGHT) ? EnumDirection.NORTH : EnumDirection.SOUTH;
                    break;
                case EnumDirection.EAST:
                    Direction = (currentTurn == EnumTurn.RIGHT) ? EnumDirection.SOUTH : EnumDirection.NORTH;
                    break;
                case EnumDirection.NORTH:
                    Direction = (currentTurn == EnumTurn.RIGHT) ? EnumDirection.EAST : EnumDirection.WEST;
                    break;
                case EnumDirection.SOUTH:
                    Direction = (currentTurn == EnumTurn.RIGHT) ? EnumDirection.EAST : EnumDirection.WEST;
                    break;
            }
        }

        /// <summary>
        /// Changes the position.
        /// </summary>
        public void ChangePosition()
        {
            switch (Direction)
            {
                case EnumDirection.WEST:
                    if ((X - 1) >= 0) --X;
                    break;
                case EnumDirection.EAST:
                    if ((X + 1) <= Dimension) ++X;
                    break;
                case EnumDirection.NORTH:
                    if ((Y + 1) <= Dimension) ++Y;
                    break;
                case EnumDirection.SOUTH:
                    if ((Y - 1) >= 0) --Y;
                    break;
            }
        }

        /// <summary>
        /// Sets the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="direction">The direction.</param>
        public void Set(int x, int y, EnumDirection direction)
        {
            X = x;
            Y = y;
            Direction = direction;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public string Get()
        {
            return $"{X},{Y},{Direction.ToString()}";
        }

        /// <summary>
        /// Sets the dimension.
        /// </summary>
        /// <param name="dimension">The dimension.</param>
        public void SetDimension(int dimension)
        {
            Dimension = dimension;
        }

        #endregion
    }
}
