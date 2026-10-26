using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiorelloHomeWork.Migrations
{
    /// <inheritdoc />
    public partial class propertiesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Flowers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Flowers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Flowers");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Flowers");
        }
    }
}
