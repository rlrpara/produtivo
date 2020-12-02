using Microsoft.EntityFrameworkCore.Migrations;

namespace Produtivo.Repositorio.Migrations
{
    public partial class CargaInicialPadrao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Escolaridade",
                columns: new[] { "Codigo", "Descricao" },
                values: new object[,]
                {
                    { 1, "Fundamental - Incompleto" },
                    { 12, "Pós-graduação (Stricto sensu, nível doutor) - Completo" },
                    { 11, "Pós-graduação (Stricto sensu, nível doutor) - Incompleto" },
                    { 9, "Pós-graduação (Stricto sensu, nível mestrado) - Incompleto" },
                    { 8, "Pós-graduação (Lato senso) - Completo" },
                    { 7, "Pós-graduação (Lato senso) - Incompleto" },
                    { 10, "Pós-graduação (Stricto sensu, nível mestrado) - Completo" },
                    { 5, "Superior - Incompleto" },
                    { 4, "Médio - Completo" },
                    { 3, "Médio - Incompleto" },
                    { 2, "Fundamental - Completo" },
                    { 6, "Superior - Completo" }
                });

            migrationBuilder.InsertData(
                table: "EstadoCivil",
                columns: new[] { "Codigo", "Descricao" },
                values: new object[,]
                {
                    { 1, "Solteiro" },
                    { 2, "Casado" },
                    { 3, "Viúvo" },
                    { 4, "Separado judicialmente" },
                    { 5, "Divorciado" }
                });

            migrationBuilder.InsertData(
                table: "Sexo",
                columns: new[] { "Codigo", "Descricao" },
                values: new object[,]
                {
                    { 1, "Masculino" },
                    { 2, "Feminino" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Escolaridade",
                keyColumn: "Codigo",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EstadoCivil",
                keyColumn: "Codigo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EstadoCivil",
                keyColumn: "Codigo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EstadoCivil",
                keyColumn: "Codigo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EstadoCivil",
                keyColumn: "Codigo",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EstadoCivil",
                keyColumn: "Codigo",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sexo",
                keyColumn: "Codigo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sexo",
                keyColumn: "Codigo",
                keyValue: 2);
        }
    }
}
