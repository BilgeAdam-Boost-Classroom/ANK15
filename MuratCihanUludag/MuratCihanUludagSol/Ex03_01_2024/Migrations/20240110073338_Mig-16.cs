using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KarneId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Transcript",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transcript", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_KarneId",
                table: "Students",
                column: "KarneId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Transcript_KarneId",
                table: "Students",
                column: "KarneId",
                principalTable: "Transcript",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Transcript_KarneId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Transcript");

            migrationBuilder.DropIndex(
                name: "IX_Students_KarneId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "KarneId",
                table: "Students");
        }
    }
}
