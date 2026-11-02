using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiorelloHomeWork.Migrations
{
    /// <inheritdoc />
    public partial class NewComlumnAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowerSliders_FlowerImages_FlowerImageId",
                table: "FlowerSliders");

            migrationBuilder.DropIndex(
                name: "IX_FlowerSliders_FlowerImageId",
                table: "FlowerSliders");

            migrationBuilder.DropColumn(
                name: "FlowerImageId",
                table: "FlowerSliders");

            migrationBuilder.AddColumn<string>(
                name: "FlowerImage",
                table: "FlowerSliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlowerImage",
                table: "FlowerSliders");

            migrationBuilder.AddColumn<int>(
                name: "FlowerImageId",
                table: "FlowerSliders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FlowerSliders_FlowerImageId",
                table: "FlowerSliders",
                column: "FlowerImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowerSliders_FlowerImages_FlowerImageId",
                table: "FlowerSliders",
                column: "FlowerImageId",
                principalTable: "FlowerImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
