using System.ComponentModel.DataAnnotations;

namespace Angular.Model
{
    public class Workout
    {
        [Key]

        public int Wid { get; set; }

        public string Wname { get; set; }

        public string Trainer { get; set; }

        public string Intensity { get; set; }

        public DateTime Wdate { get; set; }

        public string? Duration { get; set; }

        public string Maingoal { get; set; }

       
        public ICollection<Exercise>? Exercise { get; set; }

    }
}
