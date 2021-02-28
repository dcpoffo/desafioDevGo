using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class drop_base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
