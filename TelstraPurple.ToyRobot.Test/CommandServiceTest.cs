using Microsoft.VisualStudio.TestTools.UnitTesting;
using TelstraPurple.ToyRobot.Service;

namespace TelstraPurple.ToyRobot.Test
{
    [TestClass]
    public class CommandServiceTest
    {
        [TestMethod]
        public void TestExecutionExample1()
        {
            var point = new Point(0, 0, 6, 6);
            var commadService = new CommandService(point);
            var commandFactory = new CommandFactory();

            var placeCommand = commandFactory.GetCommand("PLACE 0,0,NORTH");
            var moveCommand = commandFactory.GetCommand("MOVE");
            var reportCommand = commandFactory.GetCommand("REPORT");

            commadService.AddCommands(placeCommand);
            commadService.AddCommands(moveCommand);
            commadService.AddCommands(reportCommand);
            commadService.ProcessCommands();

            Assert.AreEqual(point.OutString, "Output: 0,1,NORTH");
        }

        [TestMethod]
        public void TestExecutionExample2()
        {
            var point = new Point(0, 0, 6, 6);
            var commadService = new CommandService(point);
            var commandFactory = new CommandFactory();

            var placeCommand = commandFactory.GetCommand("PLACE 0,0,NORTH");
            var leftCommand = commandFactory.GetCommand("LEFT");
            var reportCommand = commandFactory.GetCommand("REPORT");

            commadService.AddCommands(placeCommand);
            commadService.AddCommands(leftCommand);
            commadService.AddCommands(reportCommand);
            commadService.ProcessCommands();

            Assert.AreEqual(point.OutString, "Output: 0,0,WEST");
        }

        [TestMethod]
        public void TestExecutionExample3()
        {
            var point = new Point(0, 0, 6, 6);
            var commadService = new CommandService(point);
            var commandFactory = new CommandFactory();

            var placeCommand = commandFactory.GetCommand("PLACE 1,2,EAST");
            var moveCommand1 = commandFactory.GetCommand("MOVE");
            var moveCommand2 = commandFactory.GetCommand("MOVE");
            var leftCommand = commandFactory.GetCommand("LEFT");
            var moveCommand3 = commandFactory.GetCommand("MOVE");
            var reportCommand = commandFactory.GetCommand("REPORT");

            commadService.AddCommands(placeCommand);
            commadService.AddCommands(moveCommand1);
            commadService.AddCommands(moveCommand2);
            commadService.AddCommands(leftCommand);
            commadService.AddCommands(moveCommand3);
            commadService.AddCommands(reportCommand);
            commadService.ProcessCommands();

            Assert.AreEqual(point.OutString, "Output: 3,3,NORTH");
        }

        [TestMethod]
        public void TestExecutionExample4()
        {
            var point = new Point(0, 0, 6, 6);
            var commadService = new CommandService(point);
            var commandFactory = new CommandFactory();

            var placeCommand1 = commandFactory.GetCommand("PLACE 1,2,EAST");
            var moveCommand1 = commandFactory.GetCommand("MOVE");
            var leftCommand = commandFactory.GetCommand("LEFT");
            var moveCommand2 = commandFactory.GetCommand("MOVE");
            var placeCommand2 = commandFactory.GetCommand("PLACE 3,1");
            var moveCommand3 = commandFactory.GetCommand("MOVE");
            var reportCommand = commandFactory.GetCommand("REPORT");

            commadService.AddCommands(placeCommand1);
            commadService.AddCommands(moveCommand1);
            commadService.AddCommands(leftCommand);
            commadService.AddCommands(moveCommand2);
            commadService.AddCommands(placeCommand2);
            commadService.AddCommands(moveCommand3);
            commadService.AddCommands(reportCommand);
            commadService.ProcessCommands();

            Assert.AreEqual(point.OutString, "Output: 3,2,NORTH");
        }






    }
}
