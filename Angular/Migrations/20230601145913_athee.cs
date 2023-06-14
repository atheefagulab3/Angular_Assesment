using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Angular.Migrations
{
    /// <inheritdoc />
    public partial class athee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Diet",
                table: "Exercise",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diet",
                table: "Exercise");
        }
    }
}
