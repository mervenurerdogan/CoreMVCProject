using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class Yeni2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AylikIsTBLs_KullaniciTBLs_KullaniciID",
                table: "AylikIsTBLs");

            migrationBuilder.DropForeignKey(
                name: "FK_HaftalikIsTBLs_KullaniciTBLs_KullaniciID",
                table: "HaftalikIsTBLs");

            migrationBuilder.DropIndex(
                name: "IX_HaftalikIsTBLs_KullaniciID",
                table: "HaftalikIsTBLs");

            migrationBuilder.DropIndex(
                name: "IX_AylikIsTBLs_KullaniciID",
                table: "AylikIsTBLs");

            migrationBuilder.AddColumn<int>(
                name: "KullaniciTBLKullaniciID",
                table: "HaftalikIsTBLs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciTBLKullaniciID",
                table: "AylikIsTBLs",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HaftalikIsTBLs_KullaniciTBLKullaniciID",
                table: "HaftalikIsTBLs",
                column: "KullaniciTBLKullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_AylikIsTBLs_KullaniciTBLKullaniciID",
                table: "AylikIsTBLs",
                column: "KullaniciTBLKullaniciID");

            migrationBuilder.AddForeignKey(
                name: "FK_AylikIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID",
                table: "AylikIsTBLs",
                column: "KullaniciTBLKullaniciID",
                principalTable: "KullaniciTBLs",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HaftalikIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID",
                table: "HaftalikIsTBLs",
                column: "KullaniciTBLKullaniciID",
                principalTable: "KullaniciTBLs",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AylikIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID",
                table: "AylikIsTBLs");

            migrationBuilder.DropForeignKey(
                name: "FK_HaftalikIsTBLs_KullaniciTBLs_KullaniciTBLKullaniciID",
                table: "HaftalikIsTBLs");

            migrationBuilder.DropIndex(
                name: "IX_HaftalikIsTBLs_KullaniciTBLKullaniciID",
                table: "HaftalikIsTBLs");

            migrationBuilder.DropIndex(
                name: "IX_AylikIsTBLs_KullaniciTBLKullaniciID",
                table: "AylikIsTBLs");

            migrationBuilder.DropColumn(
                name: "KullaniciTBLKullaniciID",
                table: "HaftalikIsTBLs");

            migrationBuilder.DropColumn(
                name: "KullaniciTBLKullaniciID",
                table: "AylikIsTBLs");

            migrationBuilder.CreateIndex(
                name: "IX_HaftalikIsTBLs_KullaniciID",
                table: "HaftalikIsTBLs",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_AylikIsTBLs_KullaniciID",
                table: "AylikIsTBLs",
                column: "KullaniciID");

            migrationBuilder.AddForeignKey(
                name: "FK_AylikIsTBLs_KullaniciTBLs_KullaniciID",
                table: "AylikIsTBLs",
                column: "KullaniciID",
                principalTable: "KullaniciTBLs",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HaftalikIsTBLs_KullaniciTBLs_KullaniciID",
                table: "HaftalikIsTBLs",
                column: "KullaniciID",
                principalTable: "KullaniciTBLs",
                principalColumn: "KullaniciID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
