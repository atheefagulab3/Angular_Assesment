using Angular.Model;

namespace Angular.Repository
{
    public interface IworkoutRepo
    {
        public IEnumerable<Workout> GetWorkout();
        public Workout GetWorkoutId(int Wid);
        public Workout PostWorkout(Workout Workout);
        public Workout PutWorkout(int wid, Workout Workout);
        public Workout DeleteWorkout(int Wid);
        public object GetWorkoutbyIntensity(string Intensity);
        public object GetByDate(DateTime dateTime);

        public object Countw();

    }
}
