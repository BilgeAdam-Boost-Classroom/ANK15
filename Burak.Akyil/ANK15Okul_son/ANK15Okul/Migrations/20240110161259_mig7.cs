using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK15Okul.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kutuphaneler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kutuphaneler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KutuphaneKitaplar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapNo = table.Column<int>(type: "int", nullable: false),
                    KutuphaneNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KutuphaneKitaplar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KutuphaneKitaplar_Kitaplar_KitapNo",
                        column: x => x.KitapNo,
                        principalTable: "Kitaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KutuphaneKitaplar_Kutuphaneler_KutuphaneNo",
                        column: x => x.KutuphaneNo,
                        principalTable: "Kutuphaneler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KutuphaneKitaplar_KitapNo",
                table: "KutuphaneKitaplar",
                column: "KitapNo");

            migrationBuilder.CreateIndex(
                name: "IX_KutuphaneKitaplar_KutuphaneNo",
                table: "KutuphaneKitaplar",
                column: "KutuphaneNo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KutuphaneKitaplar");

            migrationBuilder.DropTable(
                name: "Kutuphaneler");
        }
    }
}
