using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CometBarCode.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTypeToCodeEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeEntries_Settings_SettingId",
                table: "CodeEntries");

            migrationBuilder.AlterColumn<int>(
                name: "SettingId",
                table: "CodeEntries",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "CodeEntries",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CodeEntries_Settings_SettingId",
                table: "CodeEntries",
                column: "SettingId",
                principalTable: "Settings",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeEntries_Settings_SettingId",
                table: "CodeEntries");

            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "CodeEntries");

            migrationBuilder.AlterColumn<int>(
                name: "SettingId",
                table: "CodeEntries",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CodeEntries_Settings_SettingId",
                table: "CodeEntries",
                column: "SettingId",
                principalTable: "Settings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
