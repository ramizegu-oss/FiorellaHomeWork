using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiorelloHomeWork.Migrations
{
    /// <inheritdoc />
    public partial class someNewPopertiesCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMain",
                table: "FlowerImages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMain",
                table: "FlowerImages");
        }
    }
}
