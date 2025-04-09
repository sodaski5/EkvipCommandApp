Ekvip Command Console App

Description
This C# console app lets you work with an initial result value and apply different "Precepts" (commands) to change that value. You can change the number using commands like increment, decrement, double, randadd, or undo. Every time you apply a command, it's saved and you can use undo to reverse it.

How to Get Started

1. System Requirements
   .NET Core 3.1 or higher

Windows, Linux, or macOS (any of these will work)

2. Before You Begin
   Install Visual Studio or any other IDE like Visual Studio Code with .NET SDK installed.

Or you can just get the dotnet SDK if you prefer to run it from the terminal.

3. Clone the Project
   If you want to run it locally, clone this repo:

git clone https://github.com/yourusername/PreceptCommandApp.git
cd EkvipCommandApp

4. Build and Run the Project
   Build the project:

dotnet build

Run the project:

To start the program with an initial value of 3, use:

dotnet run -- 3
Just make sure your starting value is a valid integer.

How to Use the Program
Once you run the program, it will ask you to input a command to change the result. Here's a list of available commands:

Available Commands:
increment: Increases the current value by 1.

decrement: Decreases the current value by 1.

double: Doubles the current value.

randadd: Adds a random number between -10 and +10 to the current value.

undo: Reverts the last command (if there is one to undo).

Error Handling
If something goes wrong, the program will show you a message explaining what happened:

Unknown command: If you type something that isn't a valid command, it will show an error message.

Invalid input: If you don't give a valid number as the starting value, it will ask you to provide a proper integer.

Technical Details
The program is written in C# and uses .NET Core 3.1. It follows an interface-based approach to define the commands (increment, decrement, etc.), and a history of commands is saved so you can undo them if needed.

Libraries Used:
.NET Core 3.1 (or higher)

Contributors
Abubakar Sadiq Abdulhameed

License: MIT License
Changes and Extensions
Add new Precepts: You can easily add more commands by implementing the IPrecept interface and adding new classes with the specific logic for each command.

Improve random generation: The randadd command currently uses a range between -10 and +10, but you can change that if you need a different range.

Summary:
Starting value: Must be an integer (e.g., 3).

Commands: increment, decrement, double, randadd, undo.

Undo: Reverts the last command, if available.

Output: Displays the new value after each command.
