namespace RobotService.Interface
{
    /// <summary>
    /// Interface robot commands
    /// </summary>
    public interface IRobotCommand
    {
        /// <summary>
        /// Lefts this instance.
        /// </summary>
        void Left();

        /// <summary>
        /// Moves this instance.
        /// </summary>
        void Move();

        /// <summary>
        /// Places the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="direction">The direction.</param>
        void Place(int x, int y, EnumDirection direction);

        /// <summary>
        /// Reports this instance.
        /// </summary>
        /// <returns></returns>
        string Report();

        /// <summary>
        /// Rights this instance.
        /// </summary>
        void Right();
    }
}