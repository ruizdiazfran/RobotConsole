using Autofac;
using RobotService.Interface;
using RobotService.Modules;
using System;
using System.Linq;

namespace RobotConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("RobotConsole  [path file command]");
                        var container = LoadConfiguraation();

            try
            {
                // Read file commands
                var commands =  ReadFile.Get(args);

                if (commands.Any())
                {
                    var instance = container.Resolve<IValidateCommand>();
                    var result = instance.Run(commands);

                    Console.WriteLine("**************** COMMANDS *************");
                    foreach (var command in commands)
                    {
                        Console.WriteLine(command);
                    }

                    Console.WriteLine($"Result = {result}");
                }
                else
                {
                    Console.WriteLine($"Error: No commands file");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Error Fatal");
            }
            finally
            {
                Console.WriteLine("Click a key to termine");
                Console.ReadLine();
            }
        }


        #region Methods private

        protected static IContainer LoadConfiguraation()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new RobotModule());

            return builder.Build();
        }

        #endregion

    }
}
