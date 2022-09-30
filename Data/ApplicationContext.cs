using Desafio01IT.Model;
using Microsoft.EntityFrameworkCore;

namespace Desafio01IT.Data
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Time> Times { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=Desafio01T;Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogador>(p =>
            {
                p.ToTable("Elenco");
                p.HasKey(x => x.Id);
                p.Property(x => x.IdTime).HasColumnType("int").IsRequired();
                p.Property(x => x.Nome).HasColumnType("CHAR(20)");
                p.Property(x => x.Posicao).HasColumnType("CHAR(20)");
                p.Property(x => x.Nascimento).HasColumnType("DATETIME");
                p.Property(x => x.Numero).HasColumnType("CHAR(20)");
            });

            modelBuilder.Entity<Time>(p =>
            {
                p.ToTable("Time");
                p.HasKey(x => x.Id);
                p.Property(x => x.Nome).HasColumnType("CHAR(20)");
                p.Property(x => x.Fundacao).HasColumnType("DATETIME");

                p.HasMany(x => x.Elenco)
                    .WithOne(x => x.Time)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
