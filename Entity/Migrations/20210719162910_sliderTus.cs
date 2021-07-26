using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class sliderTus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<string>(
                name: "fotografAdiTus",
                table: "slider",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fotografAdiTus",
                table: "slider");

           
        }
    }
}
