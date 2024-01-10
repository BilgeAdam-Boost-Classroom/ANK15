using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK15Okul.Migrations
{
    public partial class gmi1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Subeler",
                table: "Subeler");

            migrationBuilder.RenameTable(
                name: "Subeler",
                newName: "Sections");

            migrationBuilder.RenameColumn(
                name: "SubeTekilAnahtar",
                table: "Sections",
                newName: "SubeBirincilAnahtar");

            migrationBuilder.AddColumn<int>(
                name: "SubeYabancıAnahtar",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Sections",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Aciklama",
                table: "Sections",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sections",
                table: "Sections",
                column: "SubeBirincilAnahtar");

            migrationBuilder.CreateTable(
                name: "Laboratuvarlar",
                columns: table => new
                {
                    L2 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratuvarlar", x => x.L2);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_SubeYabancıAnahtar",
                table: "Students",
                column: "SubeYabancıAnahtar");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_Ad",
                table: "Sections",
                column: "Ad",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Sections_SubeYabancıAnahtar",
                table: "Students",
                column: "SubeYabancıAnahtar",
                principalTable: "Sections",
                principalColumn: "SubeBirincilAnahtar",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Sections_SubeYabancıAnahtar",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Laboratuvarlar");

            migrationBuilder.DropIndex(
                name: "IX_Students_SubeYabancıAnahtar",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sections",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_Ad",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "SubeYabancıAnahtar",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Aciklama",
                table: "Sections");

            migrationBuilder.RenameTable(
                name: "Sections",
                newName: "Subeler");

            migrationBuilder.RenameColumn(
                name: "SubeBirincilAnahtar",
                table: "Subeler",
                newName: "SubeTekilAnahtar");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Subeler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subeler",
                table: "Subeler",
                column: "SubeTekilAnahtar");
        }
    }
}
