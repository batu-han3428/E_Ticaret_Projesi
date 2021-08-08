using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations
{
    public partial class urunSistemi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banka",
                columns: table => new
                {
                    BankaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankaAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankaLogo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banka", x => x.BankaId);
                });

            migrationBuilder.CreateTable(
                name: "urunKategorileri",
                columns: table => new
                {
                    urunKategorileriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urunKategorileriKategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urunKategorileriUstId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunKategorileri", x => x.urunKategorileriId);
                });

            migrationBuilder.CreateTable(
                name: "UrunOzellikDegerleri",
                columns: table => new
                {
                    UrunOzellikDegerleriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunOzellikDegerleriOzellikDeger = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunOzellikDegerleri", x => x.UrunOzellikDegerleriId);
                });

            migrationBuilder.CreateTable(
                name: "TaksitSecenekleri",
                columns: table => new
                {
                    TaksitSecenekleriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankaId = table.Column<int>(type: "int", nullable: true),
                    TaksitSecenekleriTaksitSayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaksitSecenekleri", x => x.TaksitSecenekleriId);
                    table.ForeignKey(
                        name: "FK_TaksitSecenekleri_Banka_BankaId",
                        column: x => x.BankaId,
                        principalTable: "Banka",
                        principalColumn: "BankaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "marka",
                columns: table => new
                {
                    markaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urunKategorileriId = table.Column<int>(type: "int", nullable: true),
                    markaAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marka", x => x.markaId);
                    table.ForeignKey(
                        name: "FK_marka_urunKategorileri_urunKategorileriId",
                        column: x => x.urunKategorileriId,
                        principalTable: "urunKategorileri",
                        principalColumn: "urunKategorileriId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "urunKategorileriDetay",
                columns: table => new
                {
                    urunKategorilerDetayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urunKategorileriId = table.Column<int>(type: "int", nullable: true),
                    urunKategorileriDetayLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urunKategorileriKategoriAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunKategorileriDetay", x => x.urunKategorilerDetayId);
                    table.ForeignKey(
                        name: "FK_urunKategorileriDetay_urunKategorileri_urunKategorileriId",
                        column: x => x.urunKategorileriId,
                        principalTable: "urunKategorileri",
                        principalColumn: "urunKategorileriId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "urunOzellikleri",
                columns: table => new
                {
                    urunOzellikleriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunOzellikDegerleriId = table.Column<int>(type: "int", nullable: true),
                    urunOzellikAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunOzellikleri", x => x.urunOzellikleriId);
                    table.ForeignKey(
                        name: "FK_urunOzellikleri_UrunOzellikDegerleri_UrunOzellikDegerleriId",
                        column: x => x.UrunOzellikDegerleriId,
                        principalTable: "UrunOzellikDegerleri",
                        principalColumn: "UrunOzellikDegerleriId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "urunKategorileriTaksitSecenekleri",
                columns: table => new
                {
                    urunKategorileriId = table.Column<int>(type: "int", nullable: false),
                    TaksitSecenekleriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunKategorileriTaksitSecenekleri", x => new { x.urunKategorileriId, x.TaksitSecenekleriId });
                    table.ForeignKey(
                        name: "FK_urunKategorileriTaksitSecenekleri_TaksitSecenekleri_TaksitSecenekleriId",
                        column: x => x.TaksitSecenekleriId,
                        principalTable: "TaksitSecenekleri",
                        principalColumn: "TaksitSecenekleriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_urunKategorileriTaksitSecenekleri_urunKategorileri_urunKategorileriId",
                        column: x => x.urunKategorileriId,
                        principalTable: "urunKategorileri",
                        principalColumn: "urunKategorileriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "urunler",
                columns: table => new
                {
                    urunlerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urunKategorileriId = table.Column<int>(type: "int", nullable: true),
                    markaId = table.Column<int>(type: "int", nullable: true),
                    urunlerAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urunlerAsilFiyat = table.Column<float>(type: "real", nullable: false),
                    urunlerIndirimliFiyat = table.Column<float>(type: "real", nullable: false),
                    urunlerEskiFiyat = table.Column<float>(type: "real", nullable: false),
                    urunlerIndirimYuzde = table.Column<int>(type: "int", nullable: false),
                    urunlerAylikTutar = table.Column<float>(type: "real", nullable: false),
                    urunlerUrunAciklamaAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urunlerUrunAciklamaIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urunlerUrunAciklamaBilgi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    urunlerStok = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_urunler", x => x.urunlerId);
                    table.ForeignKey(
                        name: "FK_urunler_marka_markaId",
                        column: x => x.markaId,
                        principalTable: "marka",
                        principalColumn: "markaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_urunler_urunKategorileri_urunKategorileriId",
                        column: x => x.urunKategorileriId,
                        principalTable: "urunKategorileri",
                        principalColumn: "urunKategorileriId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UrunlerUrunOzellikleri",
                columns: table => new
                {
                    urunlerId = table.Column<int>(type: "int", nullable: false),
                    urunOzellikleriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunlerUrunOzellikleri", x => new { x.urunlerId, x.urunOzellikleriId });
                    table.ForeignKey(
                        name: "FK_UrunlerUrunOzellikleri_urunler_urunlerId",
                        column: x => x.urunlerId,
                        principalTable: "urunler",
                        principalColumn: "urunlerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UrunlerUrunOzellikleri_urunOzellikleri_urunOzellikleriId",
                        column: x => x.urunOzellikleriId,
                        principalTable: "urunOzellikleri",
                        principalColumn: "urunOzellikleriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_marka_urunKategorileriId",
                table: "marka",
                column: "urunKategorileriId");

            migrationBuilder.CreateIndex(
                name: "IX_TaksitSecenekleri_BankaId",
                table: "TaksitSecenekleri",
                column: "BankaId");

            migrationBuilder.CreateIndex(
                name: "IX_urunKategorileriDetay_urunKategorileriId",
                table: "urunKategorileriDetay",
                column: "urunKategorileriId");

            migrationBuilder.CreateIndex(
                name: "IX_urunKategorileriTaksitSecenekleri_TaksitSecenekleriId",
                table: "urunKategorileriTaksitSecenekleri",
                column: "TaksitSecenekleriId");

            migrationBuilder.CreateIndex(
                name: "IX_urunler_markaId",
                table: "urunler",
                column: "markaId");

            migrationBuilder.CreateIndex(
                name: "IX_urunler_urunKategorileriId",
                table: "urunler",
                column: "urunKategorileriId");

            migrationBuilder.CreateIndex(
                name: "IX_UrunlerUrunOzellikleri_urunOzellikleriId",
                table: "UrunlerUrunOzellikleri",
                column: "urunOzellikleriId");

            migrationBuilder.CreateIndex(
                name: "IX_urunOzellikleri_UrunOzellikDegerleriId",
                table: "urunOzellikleri",
                column: "UrunOzellikDegerleriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "urunKategorileriDetay");

            migrationBuilder.DropTable(
                name: "urunKategorileriTaksitSecenekleri");

            migrationBuilder.DropTable(
                name: "UrunlerUrunOzellikleri");

            migrationBuilder.DropTable(
                name: "TaksitSecenekleri");

            migrationBuilder.DropTable(
                name: "urunler");

            migrationBuilder.DropTable(
                name: "urunOzellikleri");

            migrationBuilder.DropTable(
                name: "Banka");

            migrationBuilder.DropTable(
                name: "marka");

            migrationBuilder.DropTable(
                name: "UrunOzellikDegerleri");

            migrationBuilder.DropTable(
                name: "urunKategorileri");
        }
    }
}
