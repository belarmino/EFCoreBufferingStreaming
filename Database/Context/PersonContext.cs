using EFCoreBufferingStreaming.Data;
using EFCoreBufferingStreaming.Database.ModelConfig;
using EFCoreBufferingStreaming.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBufferingStreaming.Database.Context
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Person { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Connect with database
            options.UseSqlServer($"Data Source=localhost;Initial Catalog=efcore;Integrated Security=True;Persist Security Info=False;Encrypt=False;TrustServerCertificate=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Apply Model configuration
            modelBuilder.ApplyConfiguration(new PersonConfig());

            //Person Seed
            List<Person> fakePersons = GenerateConfig.FakePersonDataConfig(20000);
            modelBuilder.Entity<Person>().HasData(fakePersons);
        }
    }
}
