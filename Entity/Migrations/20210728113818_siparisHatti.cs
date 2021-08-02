﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class siparisHatti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "siparisHattiTel",
                table: "siparisHatti",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "siparisHattiTel",
                table: "siparisHatti",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
