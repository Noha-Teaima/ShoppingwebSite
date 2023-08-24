using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace project.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userShoes_shoes_userId",
                table: "userShoes");

            migrationBuilder.DropForeignKey(
                name: "FK_userShoes_user_shoesId",
                table: "userShoes");

            migrationBuilder.AddForeignKey(
                name: "FK_userShoes_shoes_shoesId",
                table: "userShoes",
                column: "shoesId",
                principalTable: "shoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userShoes_user_userId",
                table: "userShoes",
                column: "userId",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userShoes_shoes_shoesId",
                table: "userShoes");

            migrationBuilder.DropForeignKey(
                name: "FK_userShoes_user_userId",
                table: "userShoes");

            migrationBuilder.AddForeignKey(
                name: "FK_userShoes_shoes_userId",
                table: "userShoes",
                column: "userId",
                principalTable: "shoes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userShoes_user_shoesId",
                table: "userShoes",
                column: "shoesId",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
