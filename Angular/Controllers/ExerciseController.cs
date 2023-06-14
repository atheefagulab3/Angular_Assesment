using Angular.Model;
using Angular.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IExerciseRepo hot;
        public ExerciseController(IExerciseRepo hot)
        {
            this.hot = hot;
        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet]
        public IEnumerable<Exercise>? Get()
        {
            return hot.GetExercise();
        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("{Eid}")]
        public Exercise? GetExerciseById(int Eid)
        {
            return hot.GetExerciseById(Eid);
        }
        [Authorize(Roles = "User,Admin")]
        [HttpPost]
        public Exercise? PostExercise(Exercise Exercise)
        {
            return hot.PostExercise(Exercise);

        }
        [Authorize(Roles = "Admin")]
        [HttpPut("{Eid}")]
        public Exercise? PutExercise(int Eid, Exercise Exercise)
        {

            return hot.PutExercise(Eid, Exercise);
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete("{Eid}")]
        public Exercise? DeleteExercise(int Eid)
        {
            return hot.DeleteExercise(Eid);
        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("{supplement},{timeframe},{wkset}")]
        public object Filter(string supplement, string timeframe, int wkset)
        {
            return hot.Filter(supplement, timeframe, wkset);
        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("Filter/{Wid}")]
        [Authorize(Roles = "User,Admin")]
        public ActionResult<object> GetExercisewid(int Wid)
        {
            var h = hot.GetExercisewid(Wid);
            return Ok(h);
        }
        [Authorize(Roles = "User,Admin")]
        [HttpGet("Count")]
        public object Counte()
        {
            return hot.Counte();
        }
    }
}
