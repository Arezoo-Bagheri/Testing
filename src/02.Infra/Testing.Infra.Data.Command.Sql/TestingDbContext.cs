using Microsoft.EntityFrameworkCore;
using Testing.Core.Domain.People.Entity;
using Testing.Infra.Data.Command.Sql.People;

namespace Testing.Infra.Data.Command.Sql
{
    public class TestingDbContext : DbContext
    {
        public TestingDbContext(DbContextOptions<TestingDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
        }

        public DbSet<Person> People { get; set; }
    }
}
