using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ank15LoadingChangeTracker.Migrations
{
    /// <inheritdoc />
    public partial class Initilation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lisanslar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lisanslar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Onaylar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsSuccess = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Onaylar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bandroller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bandroller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bandroller_Onaylar_OnayId",
                        column: x => x.OnayId,
                        principalTable: "Onaylar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LisansId = table.Column<int>(type: "int", nullable: false),
                    BandrolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Bandroller_BandrolId",
                        column: x => x.BandrolId,
                        principalTable: "Bandroller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Urunler_Lisanslar_LisansId",
                        column: x => x.LisansId,
                        principalTable: "Lisanslar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bandroller_OnayId",
                table: "Bandroller",
                column: "OnayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_BandrolId",
                table: "Urunler",
                column: "BandrolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_LisansId",
                table: "Urunler",
                column: "LisansId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Bandroller");

            migrationBuilder.DropTable(
                name: "Lisanslar");

            migrationBuilder.DropTable(
                name: "Onaylar");
        }
    }
}
