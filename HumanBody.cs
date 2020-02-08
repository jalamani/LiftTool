using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftTool
{
    class HumanBody : Body
    {
        private bool _Sex;

        protected Muscle _traps = new Muscle();
        protected Muscle _delts = new Muscle();
        protected Muscle _biceps = new Muscle();
        protected Muscle _triceps = new Muscle();
        protected Muscle _forearms = new Muscle();
        protected Muscle _pecs = new Muscle();
        protected Muscle _obliques = new Muscle();
        protected Muscle _abs = new Muscle();
        protected Muscle _quads = new Muscle();
        protected Muscle _calves = new Muscle();

        public bool Sex { get => _Sex; set => _Sex = value; }
    }
}
