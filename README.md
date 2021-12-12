# ToyRobot

ToyRobot is a .NET 5 C# solution that contains following projects.

 1. TelstraPurple.ToyRobot.UI - Console application (user interface to run the solution)
 2. TelstraPurple.ToyRobot.Service - Service project that contains the logic implementation. Logic is decoupled from the UI project becuase it will allow to reuse the logic assembly with a different UI in future if required.
 3. TelstraPurple.ToyRobot.Common - Contains the common artifcats that will be share across multiple projects.
 4. TelstraPurple.ToyRobot.Test - Unit test project to test the service logic

To build and run the solution, 
1. Open the solution in Visual Studio 2019 
2. Build the solution (Build menu--> click on Build Solution OR Right click on solution and click Build Solution)
4. Run TelstraPurple.ToyRobot.UI
