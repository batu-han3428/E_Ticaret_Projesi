using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class alisverisKredisiSecenekleri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alisverisKredisiSecenekleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    alisverisKredisiSecenekleriFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alisverisKredisiSecenekleriYazi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alisverisKredisiSecenekleri", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alisverisKredisiSecenekleri");
        }
    }
}
