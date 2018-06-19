using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WSA.Model;

namespace WSA.Entity.Configurations
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder
               .ToTable("Endereco");
            builder
                .Property(a => a.Id)
                .HasColumnName("CdEndereco");
            builder
                .Property(a => a.Logradouro)
                .HasColumnName("DsLogradouro")
                .HasColumnType("varchar(255)");
            builder
                .Property(a => a.Complemento)
                .HasColumnName("DsComplemento")
                .HasColumnType("varchar(128)");
            builder
                .Property(a => a.Bairro)
                .HasColumnName("DsBairro")
                .HasColumnType("varchar(60)")
                .IsRequired();
            builder
                .Property(a => a.Numero)
                .HasColumnName("Numero")
                .HasColumnType("varchar(16)");
            builder
               .Property<DateTime>("DtCriacao")
               .HasColumnType("datetime")
               .HasDefaultValueSql("getdate()")
               .IsRequired();
            builder
               .Property<DateTime>("DtAlteracao")
               .HasColumnType("datetime")
               .HasDefaultValueSql("getdate()")
               .IsRequired();
            builder
               .Property(a => a.CidadeId)
               .HasColumnName("CdCidade")
               .HasColumnType("int");
            builder
               .Property(a => a.CEP)
              .HasColumnName("CEP")
              .HasColumnType("varchar(9)");
            builder
              .HasKey(a => a.Id);
        }
    }
}
