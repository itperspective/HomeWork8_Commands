using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_Command_Pasha_review_
{
    class Program
    {
        static void Main(string[] args)
        {
            Assistant assistant = new Assistant();
             
            //Commands initialization
            SMS sms = new SMS();
            Mail mail = new Mail();
            Light light = new Light();
            Condition condition = new Condition();

            //Add Commands to the list
            assistant.AddCommand(sms);
            assistant.AddCommand(mail);
            assistant.AddCommand(light);
            assistant.AddCommand(condition);

            //Execute user command
            assistant.ExecuteCommand("Turn off the condition");

            //Get commands list
            assistant.GetCommandsList();

            Console.ReadLine();

        }
    }
}
