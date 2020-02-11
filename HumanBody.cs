using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftTool
{
    public enum sex { Male, Female, };
    public class HumanBody : Body
    {
        
        private sex _Sex;

        private Muscle _Traps = new Muscle();
        private Muscle _Delts = new Muscle();
        private Muscle _Biceps = new Muscle();
        private Muscle _Triceps = new Muscle();
        private Muscle _Forearms = new Muscle();
        private Muscle _Pecs = new Muscle();
        private Muscle _Obliques = new Muscle();
        private Muscle _Abs = new Muscle();
        private Muscle _Quads = new Muscle();
        private Muscle _Calves = new Muscle();
        private Muscle _Glutes = new Muscle();

        public HumanBody(sex sex)
        {
            _Sex = sex;
        }

        public int GetPhysicalScore()
        {
            return (this.Traps.Strength+this.Delts.Strength + this.Biceps.Strength + this.Triceps.Strength + this.Forearms.Strength + this.Pecs.Strength + this.Obliques.Strength + this.Abs.Strength + this.Quads.Strength + this.Calves.Strength)/11;
        }
        public sex Sex { get => _Sex; set => _Sex = value; }
        public Muscle Traps { get => _Traps; set => _Traps = value; }
        protected Muscle Delts { get => _Delts; set => _Delts = value; }
        protected Muscle Biceps { get => _Biceps; set => _Biceps = value; }
        protected Muscle Triceps { get => _Triceps; set => _Triceps = value; }
        protected Muscle Forearms { get => _Forearms; set => _Forearms = value; }
        protected Muscle Pecs { get => _Pecs; set => _Pecs = value; }
        protected Muscle Obliques { get => _Obliques; set => _Obliques = value; }
        protected Muscle Abs { get => _Abs; set => _Abs = value; }
        protected Muscle Quads { get => _Quads; set => _Quads = value; }
        protected Muscle Calves { get => _Calves; set => _Calves = value; }
        protected Muscle Glutes { get => _Glutes; set => _Glutes = value; }
    }
}
