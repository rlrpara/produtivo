using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Produtivo.Repositorio.Migrations
{
    public partial class CriandoBases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bairro",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bairro", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Escolaridade",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escolaridade", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCivil",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCivil", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Sexo",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexo", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Email = table.Column<string>(maxLength: 150, nullable: false),
                    Senha = table.Column<string>(maxLength: 400, nullable: false),
                    Whatsapp = table.Column<string>(maxLength: 15, nullable: false),
                    Celular = table.Column<string>(maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Lancamento",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Documento = table.Column<string>(maxLength: 100, nullable: false),
                    Referencia = table.Column<string>(maxLength: 255, nullable: false),
                    Vencimento = table.Column<DateTime>(type: "TIMESTAMP", nullable: false),
                    EnviadoFinanceiro = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Responsavel = table.Column<string>(maxLength: 150, nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    Pagamento = table.Column<DateTime>(type: "TIMESTAMP", nullable: true),
                    Pago = table.Column<bool>(nullable: false, defaultValue: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "TIMESTAMP", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamento", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Lancamento_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_UsuarioId",
                table: "Lancamento",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bairro");

            migrationBuilder.DropTable(
                name: "Escolaridade");

            migrationBuilder.DropTable(
                name: "EstadoCivil");

            migrationBuilder.DropTable(
                name: "Lancamento");

            migrationBuilder.DropTable(
                name: "Sexo");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
