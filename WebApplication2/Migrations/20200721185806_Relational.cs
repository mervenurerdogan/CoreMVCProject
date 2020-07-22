using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Relational : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AylikIsTBLs",
                columns: table => new
                {
                    AylikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsBasligi = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    BaslamaTarihi = table.Column<DateTime>(nullable: false),
                    BitisTarihi = table.Column<DateTime>(nullable: false),
                    KullaniciID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AylikIsTBLs", x => x.AylikID);
                    table.ForeignKey(
                        name: "FK_AylikIsTBLs_KullaniciTBLs_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "KullaniciTBLs",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunlukIsTBLs",
                columns: table => new
                {
                    GunlukID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsBasligi = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    BaslamaTarihi = table.Column<DateTime>(nullable: false),
                    BitisTarihi = table.Column<DateTime>(nullable: false),
                    KullaniciID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunlukIsTBLs", x => x.GunlukID);
                    table.ForeignKey(
                        name: "FK_GunlukIsTBLs_KullaniciTBLs_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "KullaniciTBLs",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HaftalikIsTBLs",
                columns: table => new
                {
                    HaftlikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsBasligi = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    BaslamaTarihi = table.Column<DateTime>(nullable: false),
                    BitisTarihi = table.Column<DateTime>(nullable: false),
                    KullaniciID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HaftalikIsTBLs", x => x.HaftlikID);
                    table.ForeignKey(
                        name: "FK_HaftalikIsTBLs_KullaniciTBLs_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "KullaniciTBLs",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotTBLs",
                columns: table => new
                {
                    NotID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotBasligi = table.Column<string>(nullable: true),
                    NotAlinmaTarih = table.Column<DateTime>(nullable: false),
                    Not = table.Column<string>(nullable: true),
                    KullaniciID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotTBLs", x => x.NotID);
                    table.ForeignKey(
                        name: "FK_NotTBLs_KullaniciTBLs_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "KullaniciTBLs",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AylikIsTBLs_KullaniciID",
                table: "AylikIsTBLs",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukIsTBLs_KullaniciID",
                table: "GunlukIsTBLs",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_HaftalikIsTBLs_KullaniciID",
                table: "HaftalikIsTBLs",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_NotTBLs_KullaniciID",
                table: "NotTBLs",
                column: "KullaniciID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AylikIsTBLs");

            migrationBuilder.DropTable(
                name: "GunlukIsTBLs");

            migrationBuilder.DropTable(
                name: "HaftalikIsTBLs");

            migrationBuilder.DropTable(
                name: "NotTBLs");
        }
    }
}
