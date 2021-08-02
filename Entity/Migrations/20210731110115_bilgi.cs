using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class bilgi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bilgi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bilgiIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bilgiBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bilgiYazi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bilgi", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bilgi");
        }
    }
}
