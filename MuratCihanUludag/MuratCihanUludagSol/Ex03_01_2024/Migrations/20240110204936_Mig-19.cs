using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex03_01_2024.Migrations
{
    /// <inheritdoc />
    public partial class Mig19 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KutuphaneKitap_Kitaplar_BookNo",
                table: "KutuphaneKitap");

            migrationBuilder.DropForeignKey(
                name: "FK_KutuphaneKitap_Kutuphane_LiblaryNo",
                table: "KutuphaneKitap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KutuphaneKitap",
                table: "KutuphaneKitap");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kutuphane",
                table: "Kutuphane");

            migrationBuilder.RenameTable(
                name: "KutuphaneKitap",
                newName: "KutuphaneKitaplar");

            migrationBuilder.RenameTable(
                name: "Kutuphane",
                newName: "Kutuphaneler");

            migrationBuilder.RenameIndex(
                name: "IX_KutuphaneKitap_BookNo",
                table: "KutuphaneKitaplar",
                newName: "IX_KutuphaneKitaplar_BookNo");

            migrationBuilder.AddColumn<int>(
                name: "BandrolNo",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_KutuphaneKitaplar",
                table: "KutuphaneKitaplar",
                columns: new[] { "LiblaryNo", "BookNo" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kutuphaneler",
                table: "Kutuphaneler",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Bandroller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bandroller", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_BandrolNo",
                table: "Kitaplar",
                column: "BandrolNo",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Bandroller_BandrolNo",
                table: "Kitaplar",
                column: "BandrolNo",
                principalTable: "Bandroller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KutuphaneKitaplar_Kitaplar_BookNo",
                table: "KutuphaneKitaplar",
                column: "BookNo",
                principalTable: "Kitaplar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KutuphaneKitaplar_Kutuphaneler_LiblaryNo",
                table: "KutuphaneKitaplar",
                column: "LiblaryNo",
                principalTable: "Kutuphaneler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Bandroller_BandrolNo",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_KutuphaneKitaplar_Kitaplar_BookNo",
                table: "KutuphaneKitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_KutuphaneKitaplar_Kutuphaneler_LiblaryNo",
                table: "KutuphaneKitaplar");

            migrationBuilder.DropTable(
                name: "Bandroller");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_BandrolNo",
                table: "Kitaplar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kutuphaneler",
                table: "Kutuphaneler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KutuphaneKitaplar",
                table: "KutuphaneKitaplar");

            migrationBuilder.DropColumn(
                name: "BandrolNo",
                table: "Kitaplar");

            migrationBuilder.RenameTable(
                name: "Kutuphaneler",
                newName: "Kutuphane");

            migrationBuilder.RenameTable(
                name: "KutuphaneKitaplar",
                newName: "KutuphaneKitap");

            migrationBuilder.RenameIndex(
                name: "IX_KutuphaneKitaplar_BookNo",
                table: "KutuphaneKitap",
                newName: "IX_KutuphaneKitap_BookNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kutuphane",
                table: "Kutuphane",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KutuphaneKitap",
                table: "KutuphaneKitap",
                columns: new[] { "LiblaryNo", "BookNo" });

            migrationBuilder.AddForeignKey(
                name: "FK_KutuphaneKitap_Kitaplar_BookNo",
                table: "KutuphaneKitap",
                column: "BookNo",
                principalTable: "Kitaplar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KutuphaneKitap_Kutuphane_LiblaryNo",
                table: "KutuphaneKitap",
                column: "LiblaryNo",
                principalTable: "Kutuphane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
