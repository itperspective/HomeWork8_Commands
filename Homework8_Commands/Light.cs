using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Commands
{
    public class Light : Command
    {
        
        public Light(Executer executer) : base(executer)
        {
            this.Name = "Turn on the light";
        }

        public override void ExecuteCommand()
        {
           executer.Execute(Name);
        }
    }
}
