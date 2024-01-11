using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kutuphane",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kutuphane", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KutuphaneKitap",
                columns: table => new
                {
                    LiblaryNo = table.Column<int>(type: "int", nullable: false),
                    BookNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KutuphaneKitap", x => new { x.LiblaryNo, x.BookNo });
                    table.ForeignKey(
                        name: "FK_KutuphaneKitap_Kitaplar_BookNo",
                        column: x => x.BookNo,
                        principalTable: "Kitaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KutuphaneKitap_Kutuphane_LiblaryNo",
                        column: x => x.LiblaryNo,
                        principalTable: "Kutuphane",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KutuphaneKitap_BookNo",
                table: "KutuphaneKitap",
                column: "BookNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KutuphaneKitap");

            migrationBuilder.DropTable(
                name: "Kutuphane");
        }
    }
}
