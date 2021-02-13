using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainsApp
{
    public class CardioTrainingClass : ExerciseTypeClass
    {
        private string anyWeight;
        private int weight;
        private int set;
        private int rep;
        private const string exerciseType = "Cardio";


        public CardioTrainingClass(int kcalBurned, string focusBodyPart) : base(kcalBurned, focusBodyPart, exerciseType, exerciseName)
        {
        }
    }
}
