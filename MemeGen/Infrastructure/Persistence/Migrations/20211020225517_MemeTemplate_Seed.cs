using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace MemeGen.Infrastructure.Persistence.Migrations
{
    public partial class MemeTemplate_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemeTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TextRectangleOrigin = table.Column<Point>(type: "geography", nullable: false),
                    TextRectangleMaxWidth = table.Column<int>(type: "int", nullable: false),
                    TextRectangleMaxHeight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemeTemplates", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MemeTemplates",
                columns: new[] { "Id", "Name", "TextRectangleMaxHeight", "TextRectangleMaxWidth", "TextRectangleOrigin" },
                values: new object[] { -1, "Test", 250, 500, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (10 10)") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemeTemplates");
        }
    }
}
