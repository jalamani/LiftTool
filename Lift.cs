using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftTool
{
    class Lift
    {
        private List<Muscle> _TargetMuscles;

        private int _Weight;

        public Lift(List<Muscle> targetMuscle, int weight)
        {
            _TargetMuscles = targetMuscle;
            _Weight = weight;
        }

        //internal List<Muscle> TargetMuscle { get => targetMuscles; set => targetMuscles = value; }
        //public int Weight1 { get => Weight; set => Weight = value; }
    }
}
