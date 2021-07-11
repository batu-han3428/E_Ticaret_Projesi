using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class siteReklam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Site_Reklam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    yazi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site_Reklam", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Site_Reklam");
        }
    }
}
