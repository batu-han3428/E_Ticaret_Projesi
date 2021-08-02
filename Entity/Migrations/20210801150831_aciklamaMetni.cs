using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class aciklamaMetni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aciklamaMetni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aciklamaMetniBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aciklamaMetniYazi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aciklamaMetni", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aciklamaMetni");
        }
    }
}
