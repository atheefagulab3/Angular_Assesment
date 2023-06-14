using Angular.Model;

namespace Angular.Repository
{
    public interface IExerciseRepo
    {
         public IEnumerable<Exercise> GetExercise();
        public Exercise GetExerciseById(int Eid);
        public Exercise PostExercise(Exercise Exercise);
        public Exercise PutExercise(int Eid, Exercise Exercise);
        public Exercise DeleteExercise(int Eid);
        public object Filter(string supplement, string timeframe, int wkset);

        public object GetExercisewid(int Wid);

        public object Counte();


    }
}
