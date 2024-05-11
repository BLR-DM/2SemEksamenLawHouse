using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class opdateretsubscriptiondb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ClientSubscriptions_ClientID",
                table: "ClientSubscriptions");

            migrationBuilder.AddColumn<float>(
                name: "PaidPrice",
                table: "ClientSubscriptions",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateIndex(
                name: "IX_ClientSubscriptions_ClientID",
                table: "ClientSubscriptions",
                column: "ClientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ClientSubscriptions_ClientID",
                table: "ClientSubscriptions");

            migrationBuilder.DropColumn(
                name: "PaidPrice",
                table: "ClientSubscriptions");

            migrationBuilder.CreateIndex(
                name: "IX_ClientSubscriptions_ClientID",
                table: "ClientSubscriptions",
                column: "ClientID",
                unique: true);
        }
    }
}
