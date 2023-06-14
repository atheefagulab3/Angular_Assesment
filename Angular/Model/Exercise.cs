   using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Angular.Model
{
    public class Exercise
    {
        [Key]
        public int Eid { get; set; }

        [ForeignKey("Workout")]
        public int Wid { get; set; }

        public string? Supplement { get; set; }

        public string? TimeFrame { get; set; }

        public int? WkSet { get; set; }

        public int? WkRep { get; set; }

        public string? EquipmentRequired { get; set; }

        public string? Diet { get; set; }


        public Workout? Workout { get; set; }



    }
}
