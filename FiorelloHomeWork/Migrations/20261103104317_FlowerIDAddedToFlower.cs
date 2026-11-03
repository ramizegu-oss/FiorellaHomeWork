using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiorelloHomeWork.Migrations
{
    /// <inheritdoc />
    public partial class FlowerIDAddedToFlower : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FlowerId",
                table: "UserComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserComments_FlowerId",
                table: "UserComments",
                column: "FlowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserComments_Flowers_FlowerId",
                table: "UserComments",
                column: "FlowerId",
                principalTable: "Flowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserComments_Flowers_FlowerId",
                table: "UserComments");

            migrationBuilder.DropIndex(
                name: "IX_UserComments_FlowerId",
                table: "UserComments");

            migrationBuilder.DropColumn(
                name: "FlowerId",
                table: "UserComments");
        }
    }
}
