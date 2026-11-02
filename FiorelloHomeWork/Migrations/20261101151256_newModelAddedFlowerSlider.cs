using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiorelloHomeWork.Migrations
{
    /// <inheritdoc />
    public partial class newModelAddedFlowerSlider : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlowerSliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlowerImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerSliders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlowerSliders_FlowerImages_FlowerImageId",
                        column: x => x.FlowerImageId,
                        principalTable: "FlowerImages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlowerSliders_FlowerImageId",
                table: "FlowerSliders",
                column: "FlowerImageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowerSliders");
        }
    }
}
