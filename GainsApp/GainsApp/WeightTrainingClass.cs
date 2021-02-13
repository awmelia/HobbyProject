using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainsApp
{
    public class WeightTrainingClass : ExerciseTypeClass
    {
        private string anyWeight;
        private int weight;
        private int set;
        private int rep;
        private const string exerciseType = "Weight Training";

        public string AnyWeight { get => anyWeight; set => anyWeight = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Set { get => set; set => set = value; }
        public int Rep { get => rep; set => rep = value; }
        public static new string ExerciseType => exerciseType;

        public WeightTrainingClass(int kcalBurned, string focusBodyPart, string exerciseName, 
            string anyWeight, int weight, int set, int rep) : base(kcalBurned, focusBodyPart, exerciseType, exerciseName)
        {
            this.anyWeight = anyWeight;
            this.weight = weight;
            this.set = set;
            this.rep = rep;
        }

    }
}
