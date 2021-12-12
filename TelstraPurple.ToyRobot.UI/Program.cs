using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.IO;
using TelstraPurple.ToyRobot.Service;

namespace TelstraPurple.ToyRobot.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            //setup DI
            var serviceProvider = SetupDI();

            // Get services
            var commandService = serviceProvider.GetService<ICommandService>();
            var commandFactory = serviceProvider.GetService<ICommandFactory>();

            // Start execution
            Console.WriteLine("Please enter commands for Toy Robot");
            var command = ReadCommand(commandFactory);
            commandService.AddCommands(command);

            while (!(command is Report))
            {
                command = ReadCommand(commandFactory);
                commandService.AddCommands(command);
            }

            IPoint point = commandService.ProcessCommands();
            Console.WriteLine(point.OutString);
            
            // End of execution
            Console.Read();

        }


        /// <summary>
        /// Setup dependency injection
        /// </summary>
        /// <returns></returns>
        private static ServiceProvider SetupDI()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            int.TryParse(configuration["minX"], out int minX);
            int.TryParse(configuration["minY"], out int minY);
            int.TryParse(configuration["maxX"], out int maxX);
            int.TryParse(configuration["maxY"], out int maxY);

            return new ServiceCollection()
                .AddSingleton<IPoint>(new Point(minX, minY, maxX, maxY))
                .AddSingleton<ICommandService, CommandService>()
                .AddSingleton<ICommandFactory, CommandFactory>()
                .BuildServiceProvider();
        }

        /// <summary>
        /// Read and get command
        /// </summary>
        /// <param name="commandFactory"></param>
        /// <returns>Command</returns>
        private static ICommand ReadCommand(ICommandFactory commandFactory)
        {
            var command = commandFactory.GetCommand(Console.ReadLine());
            while (command == null)
            {
                Console.WriteLine("Please enter commands for Toy Robot");
                command = commandFactory.GetCommand(Console.ReadLine());
            }
            return command;
        }


    }
}
