using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DersOgrenci_Students_OgrencilerId",
                table: "DersOgrenci");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "OgrenciTekilAnahatar");

            migrationBuilder.RenameColumn(
                name: "OgrencilerId",
                table: "DersOgrenci",
                newName: "OgrencilerOgrenciBirincilAnahtar");

            migrationBuilder.RenameIndex(
                name: "IX_DersOgrenci_OgrencilerId",
                table: "DersOgrenci",
                newName: "IX_DersOgrenci_OgrencilerOgrenciBirincilAnahtar");

            migrationBuilder.AddForeignKey(
                name: "FK_DersOgrenci_Students_OgrencilerOgrenciBirincilAnahtar",
                table: "DersOgrenci",
                column: "OgrencilerOgrenciBirincilAnahtar",
                principalTable: "Students",
                principalColumn: "OgrenciTekilAnahatar",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DersOgrenci_Students_OgrencilerOgrenciBirincilAnahtar",
                table: "DersOgrenci");

            migrationBuilder.RenameColumn(
                name: "OgrenciTekilAnahatar",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OgrencilerOgrenciBirincilAnahtar",
                table: "DersOgrenci",
                newName: "OgrencilerId");

            migrationBuilder.RenameIndex(
                name: "IX_DersOgrenci_OgrencilerOgrenciBirincilAnahtar",
                table: "DersOgrenci",
                newName: "IX_DersOgrenci_OgrencilerId");

            migrationBuilder.AddForeignKey(
                name: "FK_DersOgrenci_Students_OgrencilerId",
                table: "DersOgrenci",
                column: "OgrencilerId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
