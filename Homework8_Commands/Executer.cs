using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Commands
{
    public class Executer
    {
        
        public void Execute(string commandName)
        {
            switch (commandName)
            {

                case "Send SMS":
                    Console.WriteLine("Ok I will send SMS");
                    break;
                case "Send mail":
                    Console.WriteLine("Ok I will send mail");
                    break;
                case "Turn on the light":
                    Console.WriteLine("Ok I will turn on the light");
                    break;
                case "Turn off the condition":
                    Console.WriteLine("Okay I will turn off the condition");
                    break;
            }

        }
    }
}
