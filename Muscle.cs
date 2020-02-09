using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftTool
{
    public class Muscle
    {
        private int _Strength;
        //private string _Name;

        public Muscle()
        {
            _Strength = 0;
        }

        public int Strength { get => _Strength; set => _Strength = value; }
    }
}
