using Angular.Model;
using Microsoft.EntityFrameworkCore;

namespace Angular.Repository
{
    public class WorkoutRepo :IworkoutRepo
    {
        private readonly WorkoutContext _wContext;
        public WorkoutRepo(WorkoutContext con)
        {
            _wContext = con;
        }
        public IEnumerable<Workout> GetWorkout()
        {
            return _wContext.Workout.Include(x => x.Exercise).ToList();
        }
        public Workout GetWorkoutId(int Wid)
        {
            try
            {
                return _wContext.Workout.FirstOrDefault(x => x.Wid == Wid);
            }
            catch (Exception)
            {
                return null;
            }

        }

        public Workout PostWorkout(Workout Workout)
        {
            try
            {
                _wContext.Workout.Add(Workout);
                _wContext.SaveChanges();
                return Workout;
            }
            catch (Exception)
            {
                return null;
            }


        }

        public Workout PutWorkout(int wid, Workout Workout)
        {
            try
            {
                _wContext.Entry(Workout).State = EntityState.Modified;
                _wContext.SaveChanges();
                return Workout;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Workout? DeleteWorkout(int Wid)
        {
            try
            {
                Workout hot = _wContext.Workout.FirstOrDefault(x => x.Wid == Wid);


                _wContext.Workout.Remove(hot);
                _wContext.SaveChanges();

                return hot;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public object GetWorkoutbyIntensity(string Intensity)
        {
            try
            {
                return _wContext.Workout.Where(Workout => Workout.Intensity.ToLower() == Intensity).ToList();
            }
            catch (Exception)
            {
                return null;
            }


        }
        public object GetByDate(DateTime Wdate)
        {
            try
            {
                return _wContext.Workout.Where(Workout => Workout.Wdate == Wdate).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public object Countw()
        {
            try
            {
                return _wContext.Workout.Count();
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);
            }
        }



    }
}
