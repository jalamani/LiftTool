﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftTool
{
    public class Lift
    {
        private List<Muscle> _TargetMuscles;

        private int _Weight;

        public Lift(List<Muscle> targetMuscle, int weight)
        {
            _TargetMuscles = targetMuscle;
            _Weight = weight;
            foreach (Muscle item in targetMuscle)
            {
                item.Strength = weight;
            }
        }

        internal List<Muscle> TargetMuscle { get => _TargetMuscles; set => _TargetMuscles = value; }
        public int Weight { get => _Weight; set => _Weight = value; }
    }
}
