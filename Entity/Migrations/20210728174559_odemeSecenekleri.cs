using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class odemeSecenekleri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "siparisHattiTel",
                table: "siparisHatti",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateTable(
                name: "odemeSecenekleri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    odemeSecenekleriFoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    odemeSecenekleriYazi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_odemeSecenekleri", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "odemeSecenekleri");

            migrationBuilder.AlterColumn<long>(
                name: "siparisHattiTel",
                table: "siparisHatti",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
