using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolExercise.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Danisman_DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Danisman",
                table: "Danisman");

            migrationBuilder.RenameTable(
                name: "Danisman",
                newName: "Danismanlar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Danismanlar",
                table: "Danismanlar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Danismanlar_DanismanId",
                table: "Ogrenciler",
                column: "DanismanId",
                principalTable: "Danismanlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Danismanlar_DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Danismanlar",
                table: "Danismanlar");

            migrationBuilder.RenameTable(
                name: "Danismanlar",
                newName: "Danisman");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Danisman",
                table: "Danisman",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Danisman_DanismanId",
                table: "Ogrenciler",
                column: "DanismanId",
                principalTable: "Danisman",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
