using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Angular.Model
{
    public class WorkoutContext :DbContext

    {

        public DbSet<Workout> Workout { get; set; }

        public DbSet<Exercise> Exercise { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<Admin> Admin { get; set; }
        public WorkoutContext(DbContextOptions<WorkoutContext> options) : base(options) { }
    }
}
