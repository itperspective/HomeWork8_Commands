using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Commands
{
    class Condition : Command
    {
        
        public Condition(Executer executer) : base(executer)
        {
            this.Name = "Turn off the condition";
        }

        public override void ExecuteCommand()
        {
            executer.Execute(Name);
        }
    }
}
