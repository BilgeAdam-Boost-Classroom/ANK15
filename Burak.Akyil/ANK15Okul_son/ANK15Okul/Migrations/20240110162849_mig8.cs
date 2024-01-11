using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK15Okul.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BandrolNo",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YayinEviNo",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Bandroller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bandroller", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YayinEvleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YayinEvleri", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_BandrolNo",
                table: "Kitaplar",
                column: "BandrolNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YayinEviNo",
                table: "Kitaplar",
                column: "YayinEviNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Bandroller_BandrolNo",
                table: "Kitaplar",
                column: "BandrolNo",
                principalTable: "Bandroller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_YayinEvleri_YayinEviNo",
                table: "Kitaplar",
                column: "YayinEviNo",
                principalTable: "YayinEvleri",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Bandroller_BandrolNo",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_YayinEvleri_YayinEviNo",
                table: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Bandroller");

            migrationBuilder.DropTable(
                name: "YayinEvleri");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_BandrolNo",
                table: "Kitaplar");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_YayinEviNo",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "BandrolNo",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "YayinEviNo",
                table: "Kitaplar");
        }
    }
}
