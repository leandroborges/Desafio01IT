using Desafio01IT.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio01IT.Configurations
{
    public class TimeConfiguration : IEntityTypeConfiguration<Time>
    {
        public void Configure(EntityTypeBuilder<Time> builder)
        {
            builder.ToTable("Time");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("CHAR(20)");
            builder.Property(x => x.Fundacao).HasColumnType("DATETIME");

            builder.HasMany(x => x.Elenco)
                .WithOne(x => x.Time)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
