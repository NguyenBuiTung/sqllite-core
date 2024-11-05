using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CometBarCode.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "CodeEntries",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CodeEntries_AccountId",
                table: "CodeEntries",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_CodeEntries_Accounts_AccountId",
                table: "CodeEntries",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodeEntries_Accounts_AccountId",
                table: "CodeEntries");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_CodeEntries_AccountId",
                table: "CodeEntries");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "CodeEntries");
        }
    }
}
