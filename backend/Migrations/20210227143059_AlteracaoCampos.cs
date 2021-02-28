using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class AlteracaoCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataHoraInicio",
                table: "HorarioCafe",
                newName: "HoraInicio");

            migrationBuilder.RenameColumn(
                name: "DataHoraFim",
                table: "HorarioCafe",
                newName: "HoraFim");

            migrationBuilder.RenameColumn(
                name: "DataHoraInicio",
                table: "Etapa",
                newName: "HoraInicio");

            migrationBuilder.RenameColumn(
                name: "DataHoraFim",
                table: "Etapa",
                newName: "HoraFim");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "HorarioCafe",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "HorarioCafe",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Etapa",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Etapa",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Etapa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio", "HoraFim", "HoraInicio" },
                values: new object[] { new DateTime(2021, 3, 29, 15, 30, 58, 329, DateTimeKind.Local).AddTicks(2805), new DateTime(2021, 3, 29, 11, 30, 58, 327, DateTimeKind.Local).AddTicks(3297), new DateTime(2021, 2, 27, 11, 30, 58, 329, DateTimeKind.Local).AddTicks(2853), new DateTime(2021, 2, 27, 11, 30, 58, 329, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Etapa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio", "HoraFim", "HoraInicio" },
                values: new object[] { new DateTime(2021, 3, 30, 15, 30, 58, 329, DateTimeKind.Local).AddTicks(8328), new DateTime(2021, 3, 30, 11, 30, 58, 329, DateTimeKind.Local).AddTicks(8309), new DateTime(2021, 2, 27, 11, 30, 58, 329, DateTimeKind.Local).AddTicks(8336), new DateTime(2021, 2, 27, 11, 30, 58, 329, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio", "HoraFim", "HoraInicio" },
                values: new object[] { new DateTime(2021, 3, 29, 11, 45, 58, 329, DateTimeKind.Local).AddTicks(9606), new DateTime(2021, 3, 29, 13, 30, 58, 329, DateTimeKind.Local).AddTicks(9593), new DateTime(2021, 2, 27, 11, 30, 58, 329, DateTimeKind.Local).AddTicks(9638), new DateTime(2021, 2, 27, 11, 30, 58, 329, DateTimeKind.Local).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio", "HoraFim", "HoraInicio" },
                values: new object[] { new DateTime(2021, 3, 29, 11, 45, 58, 330, DateTimeKind.Local).AddTicks(4603), new DateTime(2021, 3, 30, 13, 30, 58, 330, DateTimeKind.Local).AddTicks(4589), new DateTime(2021, 2, 27, 11, 30, 58, 330, DateTimeKind.Local).AddTicks(4612), new DateTime(2021, 2, 27, 11, 30, 58, 330, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalaTreinamentoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalaTreinamentoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 4,
                column: "SalaTreinamentoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 7,
                column: "SalaTreinamentoId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 8,
                column: "SalaTreinamentoId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 9,
                column: "SalaTreinamentoId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "HorarioCafe");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "HorarioCafe");

            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Etapa");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Etapa");

            migrationBuilder.RenameColumn(
                name: "HoraInicio",
                table: "HorarioCafe",
                newName: "DataHoraInicio");

            migrationBuilder.RenameColumn(
                name: "HoraFim",
                table: "HorarioCafe",
                newName: "DataHoraFim");

            migrationBuilder.RenameColumn(
                name: "HoraInicio",
                table: "Etapa",
                newName: "DataHoraInicio");

            migrationBuilder.RenameColumn(
                name: "HoraFim",
                table: "Etapa",
                newName: "DataHoraFim");

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
                keyValue: 2,
                column: "SalaTreinamentoId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalaTreinamentoId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 4,
                column: "SalaTreinamentoId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 7,
                column: "SalaTreinamentoId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 8,
                column: "SalaTreinamentoId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "PessoaSalaTreinamento",
                keyColumn: "Id",
                keyValue: 9,
                column: "SalaTreinamentoId",
                value: 1);
        }
    }
}
