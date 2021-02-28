using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class drop_base1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "Inicio");

            migrationBuilder.RenameColumn(
                name: "HoraFim",
                table: "HorarioCafe",
                newName: "Fim");

            migrationBuilder.RenameColumn(
                name: "HoraInicio",
                table: "Etapa",
                newName: "fim");

            migrationBuilder.RenameColumn(
                name: "HoraFim",
                table: "Etapa",
                newName: "Inicio");

            migrationBuilder.UpdateData(
                table: "Etapa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Inicio", "fim" },
                values: new object[] { new DateTime(2021, 3, 29, 15, 31, 2, 613, DateTimeKind.Local).AddTicks(265), new DateTime(2021, 3, 29, 19, 31, 2, 614, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Etapa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Inicio", "fim" },
                values: new object[] { new DateTime(2021, 3, 30, 15, 31, 2, 614, DateTimeKind.Local).AddTicks(2224), new DateTime(2021, 3, 30, 19, 31, 2, 614, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fim", "Inicio" },
                values: new object[] { new DateTime(2021, 3, 29, 15, 46, 2, 614, DateTimeKind.Local).AddTicks(3082), new DateTime(2021, 3, 29, 17, 31, 2, 614, DateTimeKind.Local).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Fim", "Inicio" },
                values: new object[] { new DateTime(2021, 3, 29, 15, 46, 2, 614, DateTimeKind.Local).AddTicks(4584), new DateTime(2021, 3, 30, 17, 31, 2, 614, DateTimeKind.Local).AddTicks(4577) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Inicio",
                table: "HorarioCafe",
                newName: "HoraInicio");

            migrationBuilder.RenameColumn(
                name: "Fim",
                table: "HorarioCafe",
                newName: "HoraFim");

            migrationBuilder.RenameColumn(
                name: "fim",
                table: "Etapa",
                newName: "HoraInicio");

            migrationBuilder.RenameColumn(
                name: "Inicio",
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
                values: new object[] { new DateTime(2021, 3, 29, 19, 9, 20, 193, DateTimeKind.Local).AddTicks(7038), new DateTime(2021, 3, 29, 15, 9, 20, 192, DateTimeKind.Local).AddTicks(6293), new DateTime(2021, 2, 27, 15, 9, 20, 193, DateTimeKind.Local).AddTicks(7064), new DateTime(2021, 2, 27, 15, 9, 20, 193, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Etapa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio", "HoraFim", "HoraInicio" },
                values: new object[] { new DateTime(2021, 3, 30, 19, 9, 20, 193, DateTimeKind.Local).AddTicks(9942), new DateTime(2021, 3, 30, 15, 9, 20, 193, DateTimeKind.Local).AddTicks(9935), new DateTime(2021, 2, 27, 15, 9, 20, 193, DateTimeKind.Local).AddTicks(9946), new DateTime(2021, 2, 27, 15, 9, 20, 193, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio", "HoraFim", "HoraInicio" },
                values: new object[] { new DateTime(2021, 3, 29, 15, 24, 20, 194, DateTimeKind.Local).AddTicks(631), new DateTime(2021, 3, 29, 17, 9, 20, 194, DateTimeKind.Local).AddTicks(625), new DateTime(2021, 2, 27, 15, 9, 20, 194, DateTimeKind.Local).AddTicks(647), new DateTime(2021, 2, 27, 15, 9, 20, 194, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio", "HoraFim", "HoraInicio" },
                values: new object[] { new DateTime(2021, 3, 29, 15, 24, 20, 194, DateTimeKind.Local).AddTicks(2967), new DateTime(2021, 3, 30, 17, 9, 20, 194, DateTimeKind.Local).AddTicks(2960), new DateTime(2021, 2, 27, 15, 9, 20, 194, DateTimeKind.Local).AddTicks(2970), new DateTime(2021, 2, 27, 15, 9, 20, 194, DateTimeKind.Local).AddTicks(2969) });
        }
    }
}
