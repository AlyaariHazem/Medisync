using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedisyncAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDefualtUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "Username" },
                values: new object[] { 2, "$2a$11$N0HhZNL2F3wNrHpWyPbm/.3AJQ6cIRf3.5xqhPLL0k0eb6GPpGTOS", "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
