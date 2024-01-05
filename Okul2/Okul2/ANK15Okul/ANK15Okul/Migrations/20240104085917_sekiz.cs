using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK15Okul.Migrations
{
    public partial class sekiz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
            name: "Not",
            table: "DersOgrenci",
            nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
            name: "Not",
            table: "DersOgrenci");

        }
    }
}
