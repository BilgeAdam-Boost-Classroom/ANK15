using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ank15LoadingChangeTracker.Migrations
{
    /// <inheritdoc />
    public partial class addnullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Bandroller_BandrolId",
                table: "Urunler");

            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Lisanslar_LisansId",
                table: "Urunler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_BandrolId",
                table: "Urunler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_LisansId",
                table: "Urunler");

            migrationBuilder.AlterColumn<int>(
                name: "LisansId",
                table: "Urunler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BandrolId",
                table: "Urunler",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_BandrolId",
                table: "Urunler",
                column: "BandrolId",
                unique: true,
                filter: "[BandrolId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_LisansId",
                table: "Urunler",
                column: "LisansId",
                unique: true,
                filter: "[LisansId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Bandroller_BandrolId",
                table: "Urunler",
                column: "BandrolId",
                principalTable: "Bandroller",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Lisanslar_LisansId",
                table: "Urunler",
                column: "LisansId",
                principalTable: "Lisanslar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Bandroller_BandrolId",
                table: "Urunler");

            migrationBuilder.DropForeignKey(
                name: "FK_Urunler_Lisanslar_LisansId",
                table: "Urunler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_BandrolId",
                table: "Urunler");

            migrationBuilder.DropIndex(
                name: "IX_Urunler_LisansId",
                table: "Urunler");

            migrationBuilder.AlterColumn<int>(
                name: "LisansId",
                table: "Urunler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BandrolId",
                table: "Urunler",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_BandrolId",
                table: "Urunler",
                column: "BandrolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_LisansId",
                table: "Urunler",
                column: "LisansId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Bandroller_BandrolId",
                table: "Urunler",
                column: "BandrolId",
                principalTable: "Bandroller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Urunler_Lisanslar_LisansId",
                table: "Urunler",
                column: "LisansId",
                principalTable: "Lisanslar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
