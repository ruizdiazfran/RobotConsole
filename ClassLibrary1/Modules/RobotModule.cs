using Autofac;
using RobotService.Commands;
using RobotService.Interface;
using System.Collections.Generic;

namespace RobotService.Modules
{
    /// <summary>
    /// Class implementatation modules to Autofac
    /// </summary>
    /// <seealso cref="Module" />
    public class RobotModule : Module
    {

        /// <summary>
        /// Override to add registrations to the container.
        /// </summary>
        /// <param name="builder">The builder through which components can be
        /// registered.</param>
        /// <remarks>
        /// Note that the ContainerBuilder parameter is unique to this module.
        /// </remarks>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RobotPosition>().As<IRobotPosition>().SingleInstance();
            builder.RegisterType<RobotCommand>().As<IRobotCommand>().InstancePerDependency();

            builder.RegisterType<ValidateCommand>().As<IValidateCommand>().SingleInstance();

            // Factory command Strategy
            builder.Register(x =>
            {
                var command = x.Resolve<IRobotCommand>();
                var strategy = new Dictionary<EnumCommand, ICommandStrategy>()
                        {
                            { EnumCommand.PLACE, new PlaceCommandStrategy(command)  },
                            { EnumCommand.MOVE, new MoveCommandStrategy(command)    },
                            { EnumCommand.LEFT, new LeftCommandStrategy(command)    },
                            { EnumCommand.RIGHT, new RightCommandStrategy(command)  },
                            { EnumCommand.REPORT, new ReportCommandStrategy(command) }
                        };
                return new ValidateCommand(strategy);
            }
            ).As<IValidateCommand>().InstancePerDependency();
        }
    }
}
