using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_Command_Pasha_review_
{
    class Condition : Command
    {
        public Condition()
        {
            this.Name = "Turn off the condition";
        }
        public override void Execute()
        {
            Console.WriteLine("Okay I will turn off the condition");
        }
    }
}
