using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedisyncAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddProsConsAndSeverityToInteraction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cons",
                table: "Interactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pros",
                table: "Interactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Severity",
                table: "Interactions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cons",
                table: "Interactions");

            migrationBuilder.DropColumn(
                name: "Pros",
                table: "Interactions");

            migrationBuilder.DropColumn(
                name: "Severity",
                table: "Interactions");
        }
    }
}
