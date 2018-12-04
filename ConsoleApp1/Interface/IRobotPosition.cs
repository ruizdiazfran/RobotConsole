namespace RobotService.Interface
{
    /// <summary>
    /// Interface calculate position
    /// </summary>
    public interface IRobotPosition
    {
        /// <summary>
        /// Changes the direction.
        /// </summary>
        /// <param name="current">The current.</param>
        void ChangeDirection(EnumTurn current);

        /// <summary>
        /// Changes the position.
        /// </summary>
        void ChangePosition();

        /// <summary>
        /// Sets the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="direction">The direction.</param>
        void Set(int x, int y, EnumDirection direction);

        /// <summary>
        /// Sets the dimension.
        /// </summary>
        /// <param name="dimension">The dimension.</param>
        void SetDimension(int dimension);

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        string Get();
    }
}