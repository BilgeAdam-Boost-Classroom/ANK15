using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolExercise.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DersId",
                table: "Ogrenciler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DersId",
                table: "Ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
