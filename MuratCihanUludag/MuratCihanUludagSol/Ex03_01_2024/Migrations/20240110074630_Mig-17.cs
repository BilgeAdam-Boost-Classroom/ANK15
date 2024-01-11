using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig17 : Migration
    {
        /// <inheritdoc />
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
                newName: "Transcripts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transcripts",
                table: "Transcripts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YazarKitaplar",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YazarKitaplar", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_YazarKitaplar_Kitaplar_BookId",
                        column: x => x.BookId,
                        principalTable: "Kitaplar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_YazarKitaplar_Yazarlar_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Yazarlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_YazarKitaplar_BookId",
                table: "YazarKitaplar",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Transcripts_KarneId",
                table: "Students",
                column: "KarneId",
                principalTable: "Transcripts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Transcripts_KarneId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "YazarKitaplar");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Yazarlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transcripts",
                table: "Transcripts");

            migrationBuilder.RenameTable(
                name: "Transcripts",
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
