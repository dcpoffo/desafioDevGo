using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Etapa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataHoraInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataHoraFim = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etapa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HorarioCafe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataHoraInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataHoraFim = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioCafe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Sobrenome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalaCafe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaCafe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalaTreinamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Lotacao = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: true),
                    SalaTreinamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaTreinamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalaTreinamento_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SalaTreinamento_SalaTreinamento_SalaTreinamentoId",
                        column: x => x.SalaTreinamentoId,
                        principalTable: "SalaTreinamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PessoaSalaCafe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SalaCafeId = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    HorarioCafeId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "PessoaSalaTreinamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SalaTreinamentoId = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false),
                    EtapaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PessoaSalaTreinamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PessoaSalaTreinamento_Etapa_EtapaId",
                        column: x => x.EtapaId,
                        principalTable: "Etapa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaSalaTreinamento_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PessoaSalaTreinamento_SalaTreinamento_SalaTreinamentoId",
                        column: x => x.SalaTreinamentoId,
                        principalTable: "SalaTreinamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Etapa",
                columns: new[] { "Id", "DataHoraFim", "DataHoraInicio" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 20, 1, 43, 51, 526, DateTimeKind.Local).AddTicks(6814), new DateTime(2021, 2, 20, 1, 43, 51, 523, DateTimeKind.Local).AddTicks(6310) },
                    { 2, new DateTime(2021, 2, 20, 1, 43, 51, 527, DateTimeKind.Local).AddTicks(3474), new DateTime(2021, 2, 20, 1, 43, 51, 527, DateTimeKind.Local).AddTicks(3447) }
                });

            migrationBuilder.InsertData(
                table: "HorarioCafe",
                columns: new[] { "Id", "DataHoraFim", "DataHoraInicio" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 20, 1, 43, 51, 527, DateTimeKind.Local).AddTicks(5966), new DateTime(2021, 2, 20, 1, 43, 51, 527, DateTimeKind.Local).AddTicks(5943) },
                    { 2, new DateTime(2021, 2, 20, 1, 43, 51, 528, DateTimeKind.Local).AddTicks(2754), new DateTime(2021, 2, 20, 1, 43, 51, 528, DateTimeKind.Local).AddTicks(2730) }
                });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "Nome", "Sobrenome" },
                values: new object[,]
                {
                    { 4, "Gabriel", "Poffo" },
                    { 3, "Nicolas", "Poffo" },
                    { 5, "Gengis", "khan" },
                    { 1, "Darlan", "Poffo" },
                    { 2, "Vanessa", "Tanaka" }
                });

            migrationBuilder.InsertData(
                table: "SalaCafe",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Café 1" },
                    { 2, "Café 2" },
                    { 3, "Café 3" },
                    { 4, "Café 4" }
                });

            migrationBuilder.InsertData(
                table: "SalaTreinamento",
                columns: new[] { "Id", "Lotacao", "Nome", "PessoaId", "SalaTreinamentoId" },
                values: new object[,]
                {
                    { 3, 9, "Sala 3", null, null },
                    { 1, 10, "Sala 1", null, null },
                    { 2, 12, "Sala 2", null, null },
                    { 4, 11, "Sala 4", null, null }
                });

            migrationBuilder.InsertData(
                table: "PessoaSalaCafe",
                columns: new[] { "Id", "HorarioCafeId", "PessoaId", "SalaCafeId" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 8, 2, 3, 4 },
                    { 7, 2, 2, 4 },
                    { 6, 2, 1, 4 },
                    { 9, 2, 4, 4 },
                    { 4, 1, 4, 2 },
                    { 3, 1, 3, 2 },
                    { 2, 1, 2, 2 },
                    { 5, 1, 5, 2 }
                });

            migrationBuilder.InsertData(
                table: "PessoaSalaTreinamento",
                columns: new[] { "Id", "EtapaId", "PessoaId", "SalaTreinamentoId" },
                values: new object[,]
                {
                    { 4, 1, 4, 4 },
                    { 1, 1, 1, 1 },
                    { 5, 1, 5, 1 },
                    { 9, 2, 4, 1 },
                    { 2, 1, 2, 2 },
                    { 6, 2, 1, 2 },
                    { 3, 1, 3, 3 },
                    { 7, 2, 2, 3 },
                    { 8, 2, 3, 4 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PessoaSalaTreinamento_EtapaId",
                table: "PessoaSalaTreinamento",
                column: "EtapaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaSalaTreinamento_PessoaId",
                table: "PessoaSalaTreinamento",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PessoaSalaTreinamento_SalaTreinamentoId",
                table: "PessoaSalaTreinamento",
                column: "SalaTreinamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaTreinamento_PessoaId",
                table: "SalaTreinamento",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaTreinamento_SalaTreinamentoId",
                table: "SalaTreinamento",
                column: "SalaTreinamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PessoaSalaCafe");

            migrationBuilder.DropTable(
                name: "PessoaSalaTreinamento");

            migrationBuilder.DropTable(
                name: "HorarioCafe");

            migrationBuilder.DropTable(
                name: "SalaCafe");

            migrationBuilder.DropTable(
                name: "Etapa");

            migrationBuilder.DropTable(
                name: "SalaTreinamento");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
