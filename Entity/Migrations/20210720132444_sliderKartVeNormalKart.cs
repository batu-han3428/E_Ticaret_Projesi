using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class sliderKartVeNormalKart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sliderKartiVeNormalKart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sliderKartiVeNormalKartFotoAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    icerikYazi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    puan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    puanIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    indirimlifiyat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    asilfiyat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fiyatfark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    butonIcon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sliderKartiVeNormalKart", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sliderKartiVeNormalKart");
        }
    }
}
