using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Guncelle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GunlukIsTBLs_KullaniciTBLs_KullaniciID",
                table: "GunlukIsTBLs");

            migrationBuilder.DropIndex(
                name: "IX_GunlukIsTBLs_KullaniciID",
                table: "GunlukIsTBLs");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciTBLKullaniciID",
                table: "GunlukIsTBLs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GunlukIsTBLs_KullaniciTBLKullaniciID",
                table: "GunlukIsTBLs",
                column: "KullaniciTBLKullaniciID");

            migrationBuilder.AddForeignKey(
                name: "FK_GunlukIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID",
                table: "GunlukIsTBLs",
                column: "KullaniciTBLKullaniciID",
                principalTable: "KullaniciTBLs",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GunlukIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID",
                table: "GunlukIsTBLs");

            migrationBuilder.DropIndex(
                name: "IX_GunlukIsTBLs_KullaniciTBLKullaniciID",
                table: "GunlukIsTBLs");

            migrationBuilder.DropColumn(
                name: "KullaniciTBLKullaniciID",
                table: "GunlukIsTBLs");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukIsTBLs_KullaniciID",
                table: "GunlukIsTBLs",
                column: "KullaniciID");

            migrationBuilder.AddForeignKey(
                name: "FK_GunlukIsTBLs_KullaniciTBLs_KullaniciID",
                table: "GunlukIsTBLs",
                column: "KullaniciID",
                principalTable: "KullaniciTBLs",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
