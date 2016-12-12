using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_Command_Pasha_review_
{
    class SMS : Command
    {
        public SMS()
        {
            this.Name = "Send SMS";
        }
        public override void Execute()
        {
            Console.WriteLine("Okay I will send SMS");
        }
    }
}
