using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CometBarCode.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SettingId",
                table: "CodeEntries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
            migrationBuilder.Sql("UPDATE CodeEntries SET SettingId = (SELECT Id FROM Settings LIMIT 1) WHERE SettingId = 0");

            migrationBuilder.CreateIndex(
                name: "IX_CodeEntries_SettingId",
                table: "CodeEntries",
                column: "SettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_CodeEntries_Settings_SettingId",
                table: "CodeEntries",
                column: "SettingId",
                principalTable: "Settings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeEntries_Settings_SettingId",
                table: "CodeEntries");

            migrationBuilder.DropIndex(
                name: "IX_CodeEntries_SettingId",
                table: "CodeEntries");

            migrationBuilder.DropColumn(
                name: "SettingId",
                table: "CodeEntries");
        }
    }
}
