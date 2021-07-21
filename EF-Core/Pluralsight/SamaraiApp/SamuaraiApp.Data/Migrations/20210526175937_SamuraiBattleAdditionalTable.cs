using Microsoft.EntityFrameworkCore.Migrations;

namespace SamuaraiApp.Data.Migrations
{
    public partial class SamuraiBattleAdditionalTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleSamurai_Battle_BattlesBattleId",
                table: "BattleSamurai");

            migrationBuilder.RenameColumn(
                name: "BattlesBattleId",
                table: "BattleSamurai",
                newName: "BattlesId");

            migrationBuilder.RenameColumn(
                name: "BattleId",
                table: "Battle",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleSamurai_Battle_BattlesId",
                table: "BattleSamurai",
                column: "BattlesId",
                principalTable: "Battle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BattleSamurai_Battle_BattlesId",
                table: "BattleSamurai");

            migrationBuilder.RenameColumn(
                name: "BattlesId",
                table: "BattleSamurai",
                newName: "BattlesBattleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Battle",
                newName: "BattleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BattleSamurai_Battle_BattlesBattleId",
                table: "BattleSamurai",
                column: "BattlesBattleId",
                principalTable: "Battle",
                principalColumn: "BattleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
