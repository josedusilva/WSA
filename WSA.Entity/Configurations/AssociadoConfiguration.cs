using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using WSA.Model;

namespace WSA.Entity.Configurations
{
    public class AssociadoConfiguration : IEntityTypeConfiguration<Associado>
    {
        public void Configure(EntityTypeBuilder<Associado> builder)
        {
            builder
                .Property(a => a.Id)
                .HasColumnName("CdAssociado");
            builder
                .Property(a => a.Nome)
                .HasColumnName("DsNome")
                .HasColumnType("varchar(60)")
                .IsRequired();
            builder
                .Property(a => a.Email)
                .HasColumnName("DsEmail")
                .HasColumnType("varchar(60)")
                .IsRequired();
            builder
                .Property(a => a.Celular)
                .HasColumnName("DsFone")
                .HasColumnType("varchar(15)")
                .IsRequired();
            builder
                .Property(a => a.EnderecoId)
                .HasColumnName("CdEndereco")
                .HasColumnType("int");
            builder
                .Property(a => a.Nascimento)
                .HasColumnName("DtNascimento")
                .HasColumnType("datetime");
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
                .HasIndex(a => a.Nome)
                .HasName("ix_associado_dsnome");
            builder
              .Property(a => a.Administrador)
              .HasColumnName("StAdministrador")
              .HasColumnType("bit");
            builder
                   .HasKey(a => a.Id);
        }
    }
}
