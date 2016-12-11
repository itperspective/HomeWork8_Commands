using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Commands
{
    public class Mail : Command
    {
        
        public Mail(Executer executer) : base(executer)
        {
            this.Name = "Send mail";
        }

        public override void ExecuteCommand()
        {
            executer.Execute(Name);
        }
    }
}
