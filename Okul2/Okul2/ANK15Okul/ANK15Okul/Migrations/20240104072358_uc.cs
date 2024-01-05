using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK15Okul.Migrations
{
    public partial class uc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ogrenci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numara = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiplomaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrenci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrenci_Diplomalar_DiplomaId",
                        column: x => x.DiplomaId,
                        principalTable: "Diplomalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenci_DiplomaId",
                table: "Ogrenci",
                column: "DiplomaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrenci");
        }
    }
}
