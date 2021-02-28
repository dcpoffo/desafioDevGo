using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class baseOK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PessoaSalaCafe");

            migrationBuilder.UpdateData(
                table: "Etapa",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Inicio", "fim" },
                values: new object[] { new DateTime(2021, 3, 30, 15, 28, 42, 778, DateTimeKind.Local).AddTicks(1976), new DateTime(2021, 3, 30, 19, 28, 42, 779, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Etapa",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Inicio", "fim" },
                values: new object[] { new DateTime(2021, 3, 31, 15, 28, 42, 780, DateTimeKind.Local).AddTicks(486), new DateTime(2021, 3, 31, 19, 28, 42, 780, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fim", "Inicio" },
                values: new object[] { new DateTime(2021, 3, 30, 15, 43, 42, 780, DateTimeKind.Local).AddTicks(1635), new DateTime(2021, 3, 30, 17, 28, 42, 780, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "HorarioCafe",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Fim", "Inicio" },
                values: new object[] { new DateTime(2021, 3, 30, 15, 43, 42, 780, DateTimeKind.Local).AddTicks(3955), new DateTime(2021, 3, 31, 17, 28, 42, 780, DateTimeKind.Local).AddTicks(3943) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PessoaSalaCafe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HorarioCafeId = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    SalaCafeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaSalaCafe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaSalaCafe_HorarioCafe_HorarioCafeId",
                        column: x => x.HorarioCafeId,
                        principalTable: "HorarioCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaSalaCafe_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaSalaCafe_SalaCafe_SalaCafeId",
                        column: x => x.SalaCafeId,
                        principalTable: "SalaCafe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PessoaSalaCafe_HorarioCafeId",
                table: "PessoaSalaCafe",
                column: "HorarioCafeId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaSalaCafe_PessoaId",
                table: "PessoaSalaCafe",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaSalaCafe_SalaCafeId",
                table: "PessoaSalaCafe",
                column: "SalaCafeId");
        }
    }
}
