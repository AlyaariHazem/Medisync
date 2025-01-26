using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedisyncAPI.Migrations
{
    /// <inheritdoc />
    public partial class correctUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$q6SQ4Z3B/Qj5CMYEDlURHeTWVq2uTp2WS6roBNKi9cg2raKfsov.q");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$LL0raB/vJRtJjXeo6VEO3uiSYYfSYM3RQdMiJDSDeNiAI5XhqEvkS");
        }
    }
}
