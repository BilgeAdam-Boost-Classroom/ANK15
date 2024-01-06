using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolExercise.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DanismanId",
                table: "Ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Danisman",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Danisman", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_DanismanId",
                table: "Ogrenciler",
                column: "DanismanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Danisman_DanismanId",
                table: "Ogrenciler",
                column: "DanismanId",
                principalTable: "Danisman",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Danisman_DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Danisman");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "DanismanId",
                table: "Ogrenciler");
        }
    }
}
