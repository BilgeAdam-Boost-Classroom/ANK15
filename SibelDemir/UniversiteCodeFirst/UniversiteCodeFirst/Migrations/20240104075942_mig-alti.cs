using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversiteCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class migalti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DersId",
                table: "Ogrenciler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Dersler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kredi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dersler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ogrenciler_DersId",
                table: "Ogrenciler",
                column: "DersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Dersler_DersId",
                table: "Ogrenciler",
                column: "DersId",
                principalTable: "Dersler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Dersler_DersId",
                table: "Ogrenciler");

            migrationBuilder.DropTable(
                name: "Dersler");

            migrationBuilder.DropIndex(
                name: "IX_Ogrenciler_DersId",
                table: "Ogrenciler");

            migrationBuilder.DropColumn(
                name: "DersId",
                table: "Ogrenciler");
        }
    }
}
