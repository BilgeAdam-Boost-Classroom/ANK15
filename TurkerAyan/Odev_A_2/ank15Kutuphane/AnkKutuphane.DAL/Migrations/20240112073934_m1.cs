using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnkKutuphane.DAL.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bandrols",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bandrols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kutuphanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kutuphanes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YayinEvis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YayinEvis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitaps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Etiket = table.Column<int>(type: "int", nullable: false),
                    BasimYeri = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kitaps_Bandrols_Etiket",
                        column: x => x.Etiket,
                        principalTable: "Bandrols",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaps_YayinEvis_BasimYeri",
                        column: x => x.BasimYeri,
                        principalTable: "YayinEvis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kutuphanekitap",
                columns: table => new
                {
                    KutuphanesId = table.Column<int>(type: "int", nullable: false),
                    kitapsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kutuphanekitap", x => new { x.KutuphanesId, x.kitapsId });
                    table.ForeignKey(
                        name: "FK_Kutuphanekitap_Kitaps_kitapsId",
                        column: x => x.kitapsId,
                        principalTable: "Kitaps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kutuphanekitap_Kutuphanes_KutuphanesId",
                        column: x => x.KutuphanesId,
                        principalTable: "Kutuphanes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaps_BasimYeri",
                table: "Kitaps",
                column: "BasimYeri");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaps_Etiket",
                table: "Kitaps",
                column: "Etiket",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kutuphanekitap_kitapsId",
                table: "Kutuphanekitap",
                column: "kitapsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kutuphanekitap");

            migrationBuilder.DropTable(
                name: "Kitaps");

            migrationBuilder.DropTable(
                name: "Kutuphanes");

            migrationBuilder.DropTable(
                name: "Bandrols");

            migrationBuilder.DropTable(
                name: "YayinEvis");
        }
    }
}
