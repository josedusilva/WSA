﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WSA.Entity;

namespace WSA.Entity.Migrations
{
    [DbContext(typeof(WSAContext))]
    partial class WSAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WSA.Model.Associado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CdAssociado")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Administrador")
                        .HasColumnName("StAdministrador")
                        .HasColumnType("bit");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnName("DsFone")
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("DtAlteracao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("DtCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("DsEmail")
                        .HasColumnType("varchar(60)");

                    b.Property<int>("EnderecoId")
                        .HasColumnName("CdEndereco")
                        .HasColumnType("int");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnName("DtNascimento")
                        .HasColumnType("datetime");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("DsNome")
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("Nome")
                        .HasName("ix_associado_dsnome");

                    b.ToTable("Associados");
                });

            modelBuilder.Entity("WSA.Model.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("CdCidade");

                    b.Property<short>("EstadoId")
                        .HasColumnName("CdUf")
                        .HasColumnType("smallint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("DsCidade")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Cidade");
                });

            modelBuilder.Entity("WSA.Model.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CdEndereco")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnName("DsBairro")
                        .HasColumnType("varchar(60)");

                    b.Property<string>("CEP")
                        .HasColumnName("CEP")
                        .HasColumnType("varchar(9)");

                    b.Property<int>("CidadeId")
                        .HasColumnName("CdCidade")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasColumnName("DsComplemento")
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("DtAlteracao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("DtCriacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Logradouro")
                        .HasColumnName("DsLogradouro")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Numero")
                        .HasColumnName("Numero")
                        .HasColumnType("varchar(16)");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("WSA.Model.Estado", b =>
                {
                    b.Property<short>("Id")
                        .HasColumnName("CdUf")
                        .HasColumnType("smallint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("DsUf")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)))
                        .HasColumnName("SiglaUf")
                        .HasColumnType("char(2)");

                    b.HasKey("Id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("WSA.Model.Associado", b =>
                {
                    b.HasOne("WSA.Model.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WSA.Model.Cidade", b =>
                {
                    b.HasOne("WSA.Model.Estado", "Estado")
                        .WithMany()
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WSA.Model.Endereco", b =>
                {
                    b.HasOne("WSA.Model.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
