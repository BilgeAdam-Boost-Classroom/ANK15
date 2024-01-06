using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ODEV_A_13.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kisi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Muhendis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muhendis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plaka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlakaNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plaka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Araba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlakaId = table.Column<int>(type: "int", nullable: false),
                    KisiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Araba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Araba_Kisi_KisiId",
                        column: x => x.KisiId,
                        principalTable: "Kisi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Araba_Plaka_PlakaId",
                        column: x => x.PlakaId,
                        principalTable: "Plaka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArabaMuhendis",
                columns: table => new
                {
                    ArabalarId = table.Column<int>(type: "int", nullable: false),
                    MuhendislerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaMuhendis", x => new { x.ArabalarId, x.MuhendislerId });
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Araba_ArabalarId",
                        column: x => x.ArabalarId,
                        principalTable: "Araba",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Muhendis_MuhendislerId",
                        column: x => x.MuhendislerId,
                        principalTable: "Muhendis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Araba_KisiId",
                table: "Araba",
                column: "KisiId");

            migrationBuilder.CreateIndex(
                name: "IX_Araba_PlakaId",
                table: "Araba",
                column: "PlakaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ArabaMuhendis_MuhendislerId",
                table: "ArabaMuhendis",
                column: "MuhendislerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArabaMuhendis");

            migrationBuilder.DropTable(
                name: "Araba");

            migrationBuilder.DropTable(
                name: "Muhendis");

            migrationBuilder.DropTable(
                name: "Kisi");

            migrationBuilder.DropTable(
                name: "Plaka");
        }
    }
}
