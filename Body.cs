using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftTool
{
    public abstract class Body
    {
        protected int _Age;

        protected int _Weight;

        protected int Age { get => _Age; set => _Age = value; }
        protected int Weight { get => _Weight; set => _Weight = value; }
    }
}
