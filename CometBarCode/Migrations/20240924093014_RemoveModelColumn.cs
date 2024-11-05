using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CometBarCode.Migrations
{
    /// <inheritdoc />
    public partial class RemoveModelColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "CodeEntries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "CodeEntries",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
