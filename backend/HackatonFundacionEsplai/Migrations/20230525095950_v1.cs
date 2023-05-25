using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackatonFundacionEsplai.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Population = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    HDI = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    GDP = table.Column<string>(type: "nvarchar(max)", precision: 2, nullable: false),
                    CroplandFootprint = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    GrazzingFootprint = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    ForestFootprint = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    CarbonFootprint = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    FishFootprint = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    TotalEcological = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    Cropland = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    GrazingLand = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    ForestLand = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    FishingWater = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    UrbanLand = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    TotalBiocapacity = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    BiocapacityDeficit = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    EarthRequired = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    CountriesRequired = table.Column<decimal>(type: "decimal(2,2)", precision: 2, nullable: false),
                    DataQuality = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Countries_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries_RegionId",
                table: "Countries",
                column: "RegionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
