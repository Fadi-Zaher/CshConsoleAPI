using System;

namespace CshConsoleAPI
{
    class Program
	{
      private const int ERROR_SUCCESS = 0;


      static int Main(string[] args)
		{
         // Indicates whther to continue reading input.
         bool running = true;

         // Initialize the commands object.
         Commands pCommands = CommandsApi.CommandsInit();

         // Assign the echo command function to the command list.
         CommandsApi.CommandAdd(ref pCommands, AppCommands.CMD_ECHO, AppCommands.CommandEcho);

         // Store user input text.
         string command_line;

         // Continues loop.
         while (running)
         {
            // Print command promped '>'
            Console.Write(AppCommands.CMD_PROMPED);

            // Get console command text"
            command_line = Console.ReadLine();

            // Call for command execution.
            running = CommandsApi.CommandExec(ref pCommands, command_line);
         }

         Environment.ExitCode = ERROR_SUCCESS;
         return ERROR_SUCCESS;
      }
	}
}
