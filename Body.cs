using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftTool
{
    public abstract class Body
    {
        private int age;

        private int weight;

        protected int Age { get => age; set => age = value; }
        protected int Weight { get => weight; set => weight = value; }
    }
}
