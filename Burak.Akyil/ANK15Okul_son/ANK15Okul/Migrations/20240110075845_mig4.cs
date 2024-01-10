using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK15Okul.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Transcript_KarneId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transcript",
                table: "Transcript");

            migrationBuilder.RenameTable(
                name: "Transcript",
                newName: "Transcriptler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transcriptler",
                table: "Transcriptler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Transcriptler_KarneId",
                table: "Students",
                column: "KarneId",
                principalTable: "Transcriptler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Transcriptler_KarneId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transcriptler",
                table: "Transcriptler");

            migrationBuilder.RenameTable(
                name: "Transcriptler",
                newName: "Transcript");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transcript",
                table: "Transcript",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Transcript_KarneId",
                table: "Students",
                column: "KarneId",
                principalTable: "Transcript",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
