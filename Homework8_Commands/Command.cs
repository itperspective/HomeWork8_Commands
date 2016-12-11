using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Commands
{
    public abstract class Command
    {
        protected Executer executer;
        public Command(Executer executer)
        {
            this.executer = executer;
        }
        public string Name{get; set; }

        public abstract void ExecuteCommand();
    }
}
