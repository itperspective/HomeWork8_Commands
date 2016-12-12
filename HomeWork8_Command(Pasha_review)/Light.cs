using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_Command_Pasha_review_
{
    class Light : Command
    {
        public Light()
        {
            this.Name = "Turn on the light";
        }
        public override void Execute()
        {
            Console.WriteLine("Okay I will turn on the light");
        }
    }
}
