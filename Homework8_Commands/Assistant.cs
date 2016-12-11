using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Commands
{
    public class Assistant
    {
        Command command;
        List<Command> commands = new List<Command>();

        public void AddCommand(Command command)
        {
            commands.Add(command);
        }

        private bool CanExecute(string userCommand)
        {
            for (int i = 0; i<commands.Count; i++)
            {
                if(commands[i].Name == userCommand)
                {
                    command = commands[i];
                    return true;
                }
            }

            return false;
        }

        public void ExecuteCommandByAssistant(string userCommand)
        {
            if (CanExecute(userCommand))
            {
                command.ExecuteCommand();
            }

            else { Console.WriteLine("This command is new for me. Sorry can'r execute"); }
        }

        public void GetCommandsList()
        {
            for (int i=0; i<commands.Count; i++)
            {
                Console.WriteLine(commands[i].Name);
            }
        }

    }
}
