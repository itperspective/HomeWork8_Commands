using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Commands
{
    class SMS : Command
    {
        
        public SMS(Executer executer) : base(executer)
        {
            this.Name = "Send SMS";
        }

        public override void ExecuteCommand()
        {
            executer.Execute(Name);
        }
    }
}
