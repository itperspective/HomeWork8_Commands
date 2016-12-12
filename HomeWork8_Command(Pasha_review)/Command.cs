using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8_Command_Pasha_review_
{
    public abstract class Command
    {
        public string Name { get; set; }

        public abstract void Execute();
    }
}
