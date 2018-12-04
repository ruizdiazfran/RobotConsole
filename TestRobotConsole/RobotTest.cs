
using Autofac;
using RobotService;
using RobotService.Interface;
using RobotService.Modules;
using Xunit;

namespace TestRobotConsole
{
    public class RobotTest
    {
        private readonly IContainer _container;
        private IRobotCommand _command;

        /// <summary>
        /// Initializes a new instance of the <see cref="RobotTest"/> class.
        /// </summary>
        public RobotTest()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new RobotModule());

            _container = builder.Build();
        }

        /// <summary>
        /// Places the test.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="direction">The direction.</param>
        [Theory]
        [InlineData(0, 0, EnumDirection.SOUTH)]
        public void Place_Test(int x, int y, EnumDirection direction)
        {
            // Arrange
            _command = _container.Resolve<IRobotCommand>();

            // Act
            _command.Place(x, y, direction);
            var result = _command.Report();

            // Assert
            Assert.Contains($"{x},{y},{direction.ToString()}", result);

            // Act
            _command.Move();
            var result1 = _command.Report();

            // Assert
            Assert.Contains($"{x},{y},{direction.ToString()}", result1);

            // Act
            _command.Left();
            var result2 = _command.Report();

            // Assert
            Assert.Contains($"{x},{y},{EnumDirection.WEST}", result2);

            // Act
            _command.Move();
            var result3 = _command.Report();

            // Assert
            Assert.Contains($"{x},{y},{EnumDirection.WEST}", result3);

            // Act
            _command.Right();
            var result4 = _command.Report();

            // Assert
            Assert.Contains($"{x},{y},{EnumDirection.NORTH}", result4);

            // Act
            _command.Move();
            var result5 = _command.Report();

            // Assert
            Assert.Contains($"{x},{y + 1},{EnumDirection.NORTH}", result5);
        }


    }
}
