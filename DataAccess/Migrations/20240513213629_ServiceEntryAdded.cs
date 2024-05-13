using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ServiceEntryAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceEntries",
                columns: table => new
                {
                    ServiceEntryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoursWorked = table.Column<float>(type: "real", nullable: false),
                    CaseServiceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceEntries", x => x.ServiceEntryID);
                    table.ForeignKey(
                        name: "FK_ServiceEntries_CaseServices_CaseServiceID",
                        column: x => x.CaseServiceID,
                        principalTable: "CaseServices",
                        principalColumn: "CaseServiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceEntries_CaseServiceID",
                table: "ServiceEntries",
                column: "CaseServiceID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceEntries");
        }
    }
}
