using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_Command_Pasha_review_
{
    class Mail : Command
    {
        public Mail()
        {
            this.Name = "Send mail";
        }
        public override void Execute()
        {
            Console.WriteLine("Okay I will send a mail");
        }
    }
}
