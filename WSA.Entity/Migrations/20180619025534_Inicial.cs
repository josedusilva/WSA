using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WSA.Entity.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    CdUf = table.Column<short>(type: "smallint", nullable: false),
                    DsUf = table.Column<string>(type: "varchar(20)", nullable: false),
                    SiglaUf = table.Column<string>(type: "char(2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.CdUf);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    CdCidade = table.Column<int>(nullable: false),
                    DsCidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    CdUf = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.CdCidade);
                    table.ForeignKey(
                        name: "FK_Cidade_Estado_CdUf",
                        column: x => x.CdUf,
                        principalTable: "Estado",
                        principalColumn: "CdUf",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    CdEndereco = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DsLogradouro = table.Column<string>(type: "varchar(255)", nullable: true),
                    DsComplemento = table.Column<string>(type: "varchar(128)", nullable: true),
                    Numero = table.Column<string>(type: "varchar(16)", nullable: true),
                    DsBairro = table.Column<string>(type: "varchar(60)", nullable: false),
                    CEP = table.Column<string>(type: "varchar(9)", nullable: true),
                    CdCidade = table.Column<int>(type: "int", nullable: false),
                    DtAlteracao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    DtCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.CdEndereco);
                    table.ForeignKey(
                        name: "FK_Endereco_Cidade_CdCidade",
                        column: x => x.CdCidade,
                        principalTable: "Cidade",
                        principalColumn: "CdCidade",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Associados",
                columns: table => new
                {
                    CdAssociado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DsEmail = table.Column<string>(type: "varchar(60)", nullable: false),
                    DsNome = table.Column<string>(type: "varchar(60)", nullable: false),
                    DsFone = table.Column<string>(type: "varchar(15)", nullable: false),
                    DtNascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    CdEndereco = table.Column<int>(type: "int", nullable: false),
                    StAdministrador = table.Column<bool>(type: "bit", nullable: false),
                    DtAlteracao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()"),
                    DtCriacao = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associados", x => x.CdAssociado);
                    table.ForeignKey(
                        name: "FK_Associados_Endereco_CdEndereco",
                        column: x => x.CdEndereco,
                        principalTable: "Endereco",
                        principalColumn: "CdEndereco",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Associados_CdEndereco",
                table: "Associados",
                column: "CdEndereco");

            migrationBuilder.CreateIndex(
                name: "ix_associado_dsnome",
                table: "Associados",
                column: "DsNome");

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_CdUf",
                table: "Cidade",
                column: "CdUf");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_CdCidade",
                table: "Endereco",
                column: "CdCidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Associados");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
