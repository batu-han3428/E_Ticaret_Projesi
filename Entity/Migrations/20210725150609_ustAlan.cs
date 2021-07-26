using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class ustAlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ustAlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ustAlanIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ustAlanYazi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ustAlan", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ustAlan");
        }
    }
}
