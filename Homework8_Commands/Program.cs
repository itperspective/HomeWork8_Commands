using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            Executer exe = new Executer();
            Assistant assistant = new Assistant();

            SMS sms = new SMS(exe);
            Mail mail = new Mail(exe);
            Condition condition = new Condition(exe);
            Light light = new Light(exe);

            //Adding commands as objects to the list
            assistant.AddCommand(sms);
            assistant.AddCommand(mail);
            assistant.AddCommand(condition);
            assistant.AddCommand(light);

            //Ask assistant to execute command
            assistant.ExecuteCommandByAssistant("Send SMS");

            //Get list of available commands
            assistant.GetCommandsList();



            Console.ReadLine();
        }
    }
}
