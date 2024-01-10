using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK15Okul.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YazarKitap_Kitaplar_Book",
                table: "YazarKitap");

            migrationBuilder.DropForeignKey(
                name: "FK_YazarKitap_Yazarlar_Author",
                table: "YazarKitap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_YazarKitap",
                table: "YazarKitap");

            migrationBuilder.RenameTable(
                name: "YazarKitap",
                newName: "YazarKitaplar");

            migrationBuilder.RenameIndex(
                name: "IX_YazarKitap_Book",
                table: "YazarKitaplar",
                newName: "IX_YazarKitaplar_Book");

            migrationBuilder.RenameIndex(
                name: "IX_YazarKitap_Author",
                table: "YazarKitaplar",
                newName: "IX_YazarKitaplar_Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_YazarKitaplar",
                table: "YazarKitaplar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_YazarKitaplar_Kitaplar_Book",
                table: "YazarKitaplar",
                column: "Book",
                principalTable: "Kitaplar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_YazarKitaplar_Yazarlar_Author",
                table: "YazarKitaplar",
                column: "Author",
                principalTable: "Yazarlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YazarKitaplar_Kitaplar_Book",
                table: "YazarKitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_YazarKitaplar_Yazarlar_Author",
                table: "YazarKitaplar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_YazarKitaplar",
                table: "YazarKitaplar");

            migrationBuilder.RenameTable(
                name: "YazarKitaplar",
                newName: "YazarKitap");

            migrationBuilder.RenameIndex(
                name: "IX_YazarKitaplar_Book",
                table: "YazarKitap",
                newName: "IX_YazarKitap_Book");

            migrationBuilder.RenameIndex(
                name: "IX_YazarKitaplar_Author",
                table: "YazarKitap",
                newName: "IX_YazarKitap_Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_YazarKitap",
                table: "YazarKitap",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_YazarKitap_Kitaplar_Book",
                table: "YazarKitap",
                column: "Book",
                principalTable: "Kitaplar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_YazarKitap_Yazarlar_Author",
                table: "YazarKitap",
                column: "Author",
                principalTable: "Yazarlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
