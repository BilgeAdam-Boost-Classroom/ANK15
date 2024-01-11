using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DersOgrenci_Orenciler_OgrencilerId",
                table: "DersOgrenci");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDerses_Orenciler_OgrenciId",
                table: "OgrenciDerses");

            migrationBuilder.DropForeignKey(
                name: "FK_Orenciler_Danismanlar_DanismanId",
                table: "Orenciler");

            migrationBuilder.DropForeignKey(
                name: "FK_Orenciler_Diplomas_DiplomaId",
                table: "Orenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orenciler",
                table: "Orenciler");

            migrationBuilder.RenameTable(
                name: "Orenciler",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Diplomas",
                newName: "DiplomaBirincilAnahtar");

            migrationBuilder.RenameIndex(
                name: "IX_Orenciler_DiplomaId",
                table: "Students",
                newName: "IX_Students_DiplomaId");

            migrationBuilder.RenameIndex(
                name: "IX_Orenciler_DanismanId",
                table: "Students",
                newName: "IX_Students_DanismanId");

            migrationBuilder.AlterColumn<string>(
                name: "No",
                table: "Diplomas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Diplomas_No",
                table: "Diplomas",
                column: "No",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DersOgrenci_Students_OgrencilerId",
                table: "DersOgrenci",
                column: "OgrencilerId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDerses_Students_OgrenciId",
                table: "OgrenciDerses",
                column: "OgrenciId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Danismanlar_DanismanId",
                table: "Students",
                column: "DanismanId",
                principalTable: "Danismanlar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Diplomas_DiplomaId",
                table: "Students",
                column: "DiplomaId",
                principalTable: "Diplomas",
                principalColumn: "DiplomaBirincilAnahtar");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DersOgrenci_Students_OgrencilerId",
                table: "DersOgrenci");

            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDerses_Students_OgrenciId",
                table: "OgrenciDerses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Danismanlar_DanismanId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Diplomas_DiplomaId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Diplomas_No",
                table: "Diplomas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Orenciler");

            migrationBuilder.RenameColumn(
                name: "DiplomaBirincilAnahtar",
                table: "Diplomas",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DiplomaId",
                table: "Orenciler",
                newName: "IX_Orenciler_DiplomaId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DanismanId",
                table: "Orenciler",
                newName: "IX_Orenciler_DanismanId");

            migrationBuilder.AlterColumn<string>(
                name: "No",
                table: "Diplomas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orenciler",
                table: "Orenciler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DersOgrenci_Orenciler_OgrencilerId",
                table: "DersOgrenci",
                column: "OgrencilerId",
                principalTable: "Orenciler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDerses_Orenciler_OgrenciId",
                table: "OgrenciDerses",
                column: "OgrenciId",
                principalTable: "Orenciler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orenciler_Danismanlar_DanismanId",
                table: "Orenciler",
                column: "DanismanId",
                principalTable: "Danismanlar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orenciler_Diplomas_DiplomaId",
                table: "Orenciler",
                column: "DiplomaId",
                principalTable: "Diplomas",
                principalColumn: "ID");
        }
    }
}
