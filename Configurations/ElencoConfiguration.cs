using Desafio01IT.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio01IT.Configurations
{
    public class ElencoConfiguration : IEntityTypeConfiguration<Jogador>
    {
        public void Configure(EntityTypeBuilder<Jogador> builder)
        {
            builder.ToTable("Elenco");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdTime).HasColumnType("int").IsRequired();
            builder.Property(x => x.Nome).HasColumnType("CHAR(20)");
            builder.Property(x => x.Posicao).HasColumnType("CHAR(20)");
            builder.Property(x => x.Nascimento).HasColumnType("DATETIME");
            builder.Property(x => x.Numero).HasColumnType("CHAR(20)");
        }
    }
}
