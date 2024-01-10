using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ANK15Okul.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDersler_Ogrenciler_OgrenciId",
                table: "OgrenciDersler");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Danismanlar_DanismanId",
                table: "Ogrenciler");

            migrationBuilder.DropForeignKey(
                name: "FK_Ogrenciler_Diplomalar_DiplomaId",
                table: "Ogrenciler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogrenciler",
                table: "Ogrenciler");

            migrationBuilder.RenameTable(
                name: "Ogrenciler",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Diplomalar",
                newName: "DiplomaBirincilAnahtar");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "Students",
                newName: "OgrenciAd");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "OgrenciTekilNo");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenciler_DiplomaId",
                table: "Students",
                newName: "IX_Students_DiplomaId");

            migrationBuilder.RenameIndex(
                name: "IX_Ogrenciler_DanismanId",
                table: "Students",
                newName: "IX_Students_DanismanId");

            migrationBuilder.AlterColumn<string>(
                name: "No",
                table: "Diplomalar",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OgrenciAd",
                table: "Students",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "OgrenciTekilNo");

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    CalisanPrimaryKey = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sicilNo = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.CalisanPrimaryKey);
                });

            migrationBuilder.CreateTable(
                name: "Subeler",
                columns: table => new
                {
                    SubeTekilAnahtar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subeler", x => x.SubeTekilAnahtar);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diplomalar_No",
                table: "Diplomalar",
                column: "No",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personal_sicilNo",
                table: "Personal",
                column: "sicilNo",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDersler_Students_OgrenciId",
                table: "OgrenciDersler",
                column: "OgrenciId",
                principalTable: "Students",
                principalColumn: "OgrenciTekilNo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Danismanlar_DanismanId",
                table: "Students",
                column: "DanismanId",
                principalTable: "Danismanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Diplomalar_DiplomaId",
                table: "Students",
                column: "DiplomaId",
                principalTable: "Diplomalar",
                principalColumn: "DiplomaBirincilAnahtar");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgrenciDersler_Students_OgrenciId",
                table: "OgrenciDersler");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Danismanlar_DanismanId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Diplomalar_DiplomaId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropTable(
                name: "Subeler");

            migrationBuilder.DropIndex(
                name: "IX_Diplomalar_No",
                table: "Diplomalar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Ogrenciler");

            migrationBuilder.RenameColumn(
                name: "DiplomaBirincilAnahtar",
                table: "Diplomalar",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OgrenciAd",
                table: "Ogrenciler",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "OgrenciTekilNo",
                table: "Ogrenciler",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DiplomaId",
                table: "Ogrenciler",
                newName: "IX_Ogrenciler_DiplomaId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DanismanId",
                table: "Ogrenciler",
                newName: "IX_Ogrenciler_DanismanId");

            migrationBuilder.AlterColumn<string>(
                name: "No",
                table: "Diplomalar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Ad",
                table: "Ogrenciler",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogrenciler",
                table: "Ogrenciler",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgrenciDersler_Ogrenciler_OgrenciId",
                table: "OgrenciDersler",
                column: "OgrenciId",
                principalTable: "Ogrenciler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Danismanlar_DanismanId",
                table: "Ogrenciler",
                column: "DanismanId",
                principalTable: "Danismanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ogrenciler_Diplomalar_DiplomaId",
                table: "Ogrenciler",
                column: "DiplomaId",
                principalTable: "Diplomalar",
                principalColumn: "Id");
        }
    }
}
