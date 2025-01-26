using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedisyncAPI.Migrations
{
    /// <inheritdoc />
    public partial class correctUsers1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { 1, "AQAAAAIAAYagAAAAEJyertoLqyDqocoCfAIteShHhJ//OQf2YepX70lTxSxX0p+UWZ1H8INxPQCzWlU8bg==", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { 2, "$2a$11$q6SQ4Z3B/Qj5CMYEDlURHeTWVq2uTp2WS6roBNKi9cg2raKfsov.q", "Admin" });
        }
    }
}
