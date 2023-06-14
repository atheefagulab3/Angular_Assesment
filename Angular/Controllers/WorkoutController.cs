using Angular.Model;
using Angular.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Angular.Controllers
{
    [Authorize(Roles ="User")]
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutController : ControllerBase
    {
        private readonly IworkoutRepo hot;

        public WorkoutController(IworkoutRepo hot)
        {

            this.hot = hot;
        }
        [Authorize(Roles = "User,Admin" +
            "")]
        [HttpGet]
        public IEnumerable<Workout>? Get()
        {

            return hot.GetWorkout();


        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("/fil/{Wid}")]
        public Workout? GetWorkoutId(int Wid)
        {
            return hot.GetWorkoutId(Wid);
        }
        [Authorize(Roles = "User,Admin")]
        [HttpPost]
        public Workout? PostWorkout(Workout Workout)
        {

            return hot.PostWorkout(Workout);


        }
        [Authorize(Roles = "Admin")]
        [HttpPut("{wid}")]
        public Workout? PutWorkout(int wid, Workout Workout)
        {

            return hot.PutWorkout(wid, Workout);


        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("{Wid}")]
        public Workout? DeleteWorkout(int Wid)
        {

            return hot.DeleteWorkout(Wid);


        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("{Intensity}")]

        public ActionResult<object> GetWorkoutbyIntensity(string Intensity)
        {
            var h = hot.GetWorkoutbyIntensity(Intensity.ToLower());
            return Ok(h);
        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("/filter/{Wdate}")]
        public object GetByDate(DateTime Wdate)
        {
            return hot.GetByDate(Wdate);
        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("Count")]
        public object Countw()
        {
            return hot.Countw();
        }

    }
}
