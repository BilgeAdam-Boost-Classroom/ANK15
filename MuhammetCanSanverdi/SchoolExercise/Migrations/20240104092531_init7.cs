﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolExercise.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Not",
                table: "OgrenciDersler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Not",
                table: "OgrenciDersler");
        }
    }
}
