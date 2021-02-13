using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainsApp
{
    public abstract class ExerciseTypeClass
    {
        private int kcalBurned;
        private string focusBodyPart;
        private string exerciseType;
        private string exerciseName;

        public int KcalBurned { get => kcalBurned; set => kcalBurned = value; }
        public string FocusBodyPart { get => focusBodyPart; set => focusBodyPart = value; }
        public string ExerciseType { get => exerciseType; set => exerciseType = value; }
        public string ExerciseName { get => exerciseName; set => exerciseName = value; }

        public ExerciseTypeClass()
        {

        }

        public ExerciseTypeClass(int kcalBurned, string focusBodyPart, string exerciseType, string exerciseName)
        {
            this.kcalBurned = kcalBurned;
            this.focusBodyPart = focusBodyPart;
            this.exerciseType = exerciseType;
            this.ExerciseName = exerciseName;

        }
    }
}
