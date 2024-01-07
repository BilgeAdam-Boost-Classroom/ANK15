using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArabamDb_codeFirst.Migrations
{
    /// <inheritdoc />
    public partial class migbir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Muhendisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muhendisler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plakalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plakalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sahipler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sahipler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yil = table.Column<int>(type: "int", nullable: false),
                    PlakaId = table.Column<int>(type: "int", nullable: false),
                    SahipId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arabalar_Plakalar_PlakaId",
                        column: x => x.PlakaId,
                        principalTable: "Plakalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arabalar_Sahipler_SahipId",
                        column: x => x.SahipId,
                        principalTable: "Sahipler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArabaMuhendis",
                columns: table => new
                {
                    ArabalarId = table.Column<int>(type: "int", nullable: false),
                    MuhandislerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArabaMuhendis", x => new { x.ArabalarId, x.MuhandislerId });
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Arabalar_ArabalarId",
                        column: x => x.ArabalarId,
                        principalTable: "Arabalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArabaMuhendis_Muhendisler_MuhandislerId",
                        column: x => x.MuhandislerId,
                        principalTable: "Muhendisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MuhendisArabalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MuhendisId = table.Column<int>(type: "int", nullable: false),
                    ArabaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuhendisArabalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MuhendisArabalar_Arabalar_ArabaId",
                        column: x => x.ArabaId,
                        principalTable: "Arabalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MuhendisArabalar_Muhendisler_MuhendisId",
                        column: x => x.MuhendisId,
                        principalTable: "Muhendisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_PlakaId",
                table: "Arabalar",
                column: "PlakaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arabalar_SahipId",
                table: "Arabalar",
                column: "SahipId");

            migrationBuilder.CreateIndex(
                name: "IX_ArabaMuhendis_MuhandislerId",
                table: "ArabaMuhendis",
                column: "MuhandislerId");

            migrationBuilder.CreateIndex(
                name: "IX_MuhendisArabalar_ArabaId",
                table: "MuhendisArabalar",
                column: "ArabaId");

            migrationBuilder.CreateIndex(
                name: "IX_MuhendisArabalar_MuhendisId",
                table: "MuhendisArabalar",
                column: "MuhendisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArabaMuhendis");

            migrationBuilder.DropTable(
                name: "MuhendisArabalar");

            migrationBuilder.DropTable(
                name: "Arabalar");

            migrationBuilder.DropTable(
                name: "Muhendisler");

            migrationBuilder.DropTable(
                name: "Plakalar");

            migrationBuilder.DropTable(
                name: "Sahipler");
        }
    }
}
