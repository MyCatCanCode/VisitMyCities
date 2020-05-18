using Microsoft.EntityFrameworkCore.Migrations;

namespace VisitMyCities.DataModel.Migrations
{
    public partial class ModifyBatimentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ville",
                columns: table => new
                {
                    VilleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomVille = table.Column<string>(nullable: false),
                    NomRegion = table.Column<string>(nullable: true),
                    NumDepartement = table.Column<int>(nullable: false),
                    NomDepartement = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ville", x => x.VilleId);
                });

            migrationBuilder.CreateTable(
                name: "Batiment",
                columns: table => new
                {
                    BatimentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomBatiment = table.Column<string>(nullable: true),
                    Adresse = table.Column<string>(nullable: true),
                    URLPhoto = table.Column<string>(nullable: true),
                    TypeBatiment = table.Column<string>(nullable: true),
                    DescriptionBatiment = table.Column<string>(nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    Latitude = table.Column<double>(nullable: true),
                    MonumentHistorique = table.Column<bool>(nullable: true),
                    DateConstruction = table.Column<string>(nullable: true),
                    VilleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batiment", x => x.BatimentId);
                    table.ForeignKey(
                        name: "FK_Batiment_Ville_VilleId",
                        column: x => x.VilleId,
                        principalTable: "Ville",
                        principalColumn: "VilleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailArchitectural",
                columns: table => new
                {
                    DetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomDetail = table.Column<string>(nullable: true),
                    DescriptionDetail = table.Column<string>(nullable: true),
                    BatimentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailArchitectural", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_DetailArchitectural_Batiment_BatimentId",
                        column: x => x.BatimentId,
                        principalTable: "Batiment",
                        principalColumn: "BatimentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batiment_VilleId",
                table: "Batiment",
                column: "VilleId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailArchitectural_BatimentId",
                table: "DetailArchitectural",
                column: "BatimentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailArchitectural");

            migrationBuilder.DropTable(
                name: "Batiment");

            migrationBuilder.DropTable(
                name: "Ville");
        }
    }
}
