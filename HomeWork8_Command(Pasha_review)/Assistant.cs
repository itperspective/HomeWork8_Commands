using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_Command_Pasha_review_
{
    class Assistant
    {
        Command command;
        List<Command> commands = new List<Command>();

        public void AddCommand(Command command)
        {
            commands.Add(command);
        }

        private bool CanExecute(string userCommand)
        {
            for (int i = 0; i < commands.Count; i++)
            {
                if (userCommand == commands[i].Name)
                {
                    command = commands[i];
                    return true;
                }
            }
             return false;   
        }

        public void ExecuteCommand(string userCommand)
        {
            if (CanExecute(userCommand))
            {
                command.Execute();
            }
            else { Console.WriteLine("Dont recognize your command"); }
        }

        public void GetCommandsList()
        {
            Console.WriteLine("<<<<<<<List of available commands:");
            for (int i = 0; i<commands.Count; i++)
            {
                Console.WriteLine(commands[i].Name);
            }
        }
    }
}
