using EFCoreBufferingStreaming.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreBufferingStreaming.Database.ModelConfig
{
    public class PersonConfig: IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person");
            builder.HasKey(u => u.PersonId);

            builder.Property(u => u.FirstName).HasMaxLength(100);
            builder.Property(u => u.LastName).HasMaxLength(100);
            builder.Property(u => u.Country).HasMaxLength(80);
            builder.Property(u => u.City).HasMaxLength(80);
        }
    }
}
