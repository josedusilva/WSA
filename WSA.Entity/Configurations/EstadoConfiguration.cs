using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WSA.Model;

namespace WSA.Entity.Configurations
{
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder
                .ToTable("Estado");
            builder
                .Property(a => a.Id)
                .HasColumnName("CdUf")
                .HasColumnType("smallint")
                .ValueGeneratedNever();
            builder
                .Property(a => a.Nome)
                .HasColumnName("DsUf")
                .HasColumnType("varchar(20)")
                .IsRequired();
            builder
                .Property(a => a.Sigla)
                .HasColumnName("SiglaUf")
                .HasColumnType("varchar(2)")
                .IsRequired();
            builder
                .HasKey(a => new { a.Id });
        }
    }
}
