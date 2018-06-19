using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WSA.Model;

namespace WSA.Entity.Configurations
{
    public class CidadeConfiguration : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder
               .ToTable("Cidade");
            builder
                 .Property(a => a.Id)
                .HasColumnName("CdCidade")
                .ValueGeneratedNever();
            builder
                .Property(a => a.Nome)
                .HasColumnName("DsCidade")
                .HasColumnType("varchar(50)")
                .IsRequired();
            builder
                .Property(a => a.EstadoId)
                .HasColumnName("CdUf")
                .HasColumnType("char(2)")
                .IsRequired();
            builder
               .Property(a => a.EstadoId)
               .HasColumnName("CdUf")
               .HasColumnType("smallint");
            builder
                 .HasKey(a => new { a.Id });
        }
    }
}
