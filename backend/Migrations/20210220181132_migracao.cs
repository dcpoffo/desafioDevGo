using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class migracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PessoaSalaCafe",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PessoaSalaCafe",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PessoaSalaCafe",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PessoaSalaCafe",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PessoaSalaCafe",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PessoaSalaCafe",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PessoaSalaCafe",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PessoaSalaCafe",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PessoaSalaCafe",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SalaCafe",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SalaCafe",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<int>(
                name: "HorarioCafeId",
                table: "PessoaSalaTreinamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalaCafeId",
                table: "PessoaSalaTreinamento",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Etapa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataHoraFim", "DataHoraInicio" },
                values: new object[] { new DateTime(2021, 3, 22, 19, 11, 31, 779, DateTimeKind.Local).AddTicks(9562), new DateTime(2021, 3, 22, 15, 11, 31, 778, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Etapa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataHoraFim", "DataHoraInicio" },
                values: new object[] { new DateTime(2021, 3, 23, 19, 11, 31, 780, DateTimeKind.Local).AddTicks(1743), new DateTime(2021, 3, 23, 15, 11, 31, 780, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataHoraFim", "DataHoraInicio" },
                values: new object[] { new DateTime(2021, 3, 22, 15, 26, 31, 780, DateTimeKind.Local).AddTicks(2547), new DateTime(2021, 3, 22, 17, 11, 31, 780, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataHoraFim", "DataHoraInicio" },
                values: new object[] { new DateTime(2021, 3, 22, 15, 26, 31, 780, DateTimeKind.Local).AddTicks(4212), new DateTime(2021, 3, 23, 17, 11, 31, 780, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HorarioCafeId", "SalaCafeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HorarioCafeId", "SalaCafeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HorarioCafeId", "SalaCafeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HorarioCafeId", "SalaCafeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HorarioCafeId", "SalaCafeId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "HorarioCafeId", "SalaCafeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "HorarioCafeId", "SalaCafeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "HorarioCafeId", "SalaCafeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "HorarioCafeId", "SalaCafeId" },
                values: new object[] { 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_PessoaSalaTreinamento_HorarioCafeId",
                table: "PessoaSalaTreinamento",
                column: "HorarioCafeId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaSalaTreinamento_SalaCafeId",
                table: "PessoaSalaTreinamento",
                column: "SalaCafeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PessoaSalaTreinamento_HorarioCafe_HorarioCafeId",
                table: "PessoaSalaTreinamento",
                column: "HorarioCafeId",
                principalTable: "HorarioCafe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PessoaSalaTreinamento_SalaCafe_SalaCafeId",
                table: "PessoaSalaTreinamento",
                column: "SalaCafeId",
                principalTable: "SalaCafe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PessoaSalaTreinamento_HorarioCafe_HorarioCafeId",
                table: "PessoaSalaTreinamento");

            migrationBuilder.DropForeignKey(
                name: "FK_PessoaSalaTreinamento_SalaCafe_SalaCafeId",
                table: "PessoaSalaTreinamento");

            migrationBuilder.DropIndex(
                name: "IX_PessoaSalaTreinamento_HorarioCafeId",
                table: "PessoaSalaTreinamento");

            migrationBuilder.DropIndex(
                name: "IX_PessoaSalaTreinamento_SalaCafeId",
                table: "PessoaSalaTreinamento");

            migrationBuilder.DropColumn(
                name: "HorarioCafeId",
                table: "PessoaSalaTreinamento");

            migrationBuilder.DropColumn(
                name: "SalaCafeId",
                table: "PessoaSalaTreinamento");

            migrationBuilder.UpdateData(
                table: "Etapa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataHoraFim", "DataHoraInicio" },
                values: new object[] { new DateTime(2021, 2, 20, 1, 43, 51, 526, DateTimeKind.Local).AddTicks(6814), new DateTime(2021, 2, 20, 1, 43, 51, 523, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Etapa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataHoraFim", "DataHoraInicio" },
                values: new object[] { new DateTime(2021, 2, 20, 1, 43, 51, 527, DateTimeKind.Local).AddTicks(3474), new DateTime(2021, 2, 20, 1, 43, 51, 527, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataHoraFim", "DataHoraInicio" },
                values: new object[] { new DateTime(2021, 2, 20, 1, 43, 51, 527, DateTimeKind.Local).AddTicks(5966), new DateTime(2021, 2, 20, 1, 43, 51, 527, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataHoraFim", "DataHoraInicio" },
                values: new object[] { new DateTime(2021, 2, 20, 1, 43, 51, 528, DateTimeKind.Local).AddTicks(2754), new DateTime(2021, 2, 20, 1, 43, 51, 528, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.InsertData(
                table: "PessoaSalaCafe",
                columns: new[] { "Id", "HorarioCafeId", "PessoaId", "SalaCafeId" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 1, 2, 2 },
                    { 3, 1, 3, 2 },
                    { 4, 1, 4, 2 },
                    { 5, 1, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "SalaCafe",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 3, "Café 3" },
                    { 4, "Café 4" }
                });

            migrationBuilder.InsertData(
                table: "PessoaSalaCafe",
                columns: new[] { "Id", "HorarioCafeId", "PessoaId", "SalaCafeId" },
                values: new object[,]
                {
                    { 6, 2, 1, 4 },
                    { 7, 2, 2, 4 },
                    { 8, 2, 3, 4 },
                    { 9, 2, 4, 4 }
                });
        }
    }
}
