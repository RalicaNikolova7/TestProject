using TestProject.Data;
using Microsoft.EntityFrameworkCore;
using TestProject.Data.Models;


namespace TestProject.Infrastructure
{
    public class TestProjectDbContext : DbContext
    {
        public TestProjectDbContext(DbContextOptions<TestProjectDbContext> options) 
            : base(options)
        {
        }
        public DbSet<Follow> Follow { get; set; } = null!;
        public DbSet<Post> Post { get; set; } = null!;
        public DbSet<User> User { get; set; } = null!;
    }
}