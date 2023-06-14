using Angular.Model;
using Microsoft.EntityFrameworkCore;

namespace Angular.Repository
{
    public class ExerciseRepo : IExerciseRepo
    {
        private readonly WorkoutContext _wContext;
        public ExerciseRepo(WorkoutContext con)
        {
            _wContext = con;
        }
        public IEnumerable<Exercise> GetExercise()
        {
            return _wContext.Exercise.ToList();
        }
        public Exercise GetExerciseById(int Eid)
        {
            try
            {
                return _wContext.Exercise.FirstOrDefault(x => x.Eid == Eid);

            }
            catch (Exception ex)
            {
                return null;
            }



        }

        public Exercise PostExercise(Exercise Exercise)
        {
            try
            {
                _wContext.Exercise.Add(Exercise);
                _wContext.SaveChanges();
                return Exercise;
            }

            catch (Exception ex)
            {
                return null;
            }


        }

        public Exercise PutExercise(int Eid, Exercise Exercise)
        {
            try
            {
                _wContext.Entry(Exercise).State = EntityState.Modified;
                _wContext.SaveChanges();
                return Exercise;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public Exercise DeleteExercise(int Eid)
        {
            try
            {
                Exercise hot = _wContext.Exercise.FirstOrDefault(x => x.Eid == Eid);

                _wContext.Exercise.Remove(hot);

                _wContext.SaveChanges();

                return hot;
            }

            catch (Exception ex)
            {
                return null;
            }


        }
        public object Filter(string supplement, string timeframe, int wkset)
        {
            try
            {
                return _wContext.Exercise.Where(a => a.Supplement.ToLower() == supplement.ToLower() && a.TimeFrame.ToLower() == timeframe.ToLower() && a.WkSet == wkset).ToList();
            }
            catch (Exception)
            {
                return null;
            }

        }
        public object GetExercisewid(int Wid)
        {
            try
            {
                return _wContext.Exercise.Where(Exercise => Exercise.Wid == Wid).ToList();
            }
            catch (Exception)
            {
                return null;
            }


        }
        public object Counte()
        {
            try
            {
                return _wContext.Exercise.Count();
            }
            catch (Exception ex)
            {
                throw new Exception("Not able to get the details" + ex.Message);
            }
        }


    }
}
