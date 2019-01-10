using Microsoft.EntityFrameworkCore;

namespace ResultManagementSystem.Data
{
    public class TestContext:DbContext
    {
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public DbSet<ResultManagementSystem.Models.Actor> Actor { get; set; }
        public DbSet<ResultManagementSystem.Models.Login> Login { get; set; }
        public DbSet<ResultManagementSystem.Models.Student> Student { get; set; }
        public DbSet<ResultManagementSystem.Models.Teacher> Teacher { get; set; }
        public DbSet<ResultManagementSystem.Models.Course> Course { get; set; }
        public DbSet<ResultManagementSystem.Models.Classes> Classes { get; set; }
        public DbSet<ResultManagementSystem.Models.Marks> Marks { get; set; }
    }
}
