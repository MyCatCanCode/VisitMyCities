using Microsoft.EntityFrameworkCore.Migrations;

namespace VisitMyCities.DataModel.Migrations
{
    public partial class Tags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    CategorieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomCategorie = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.CategorieId);
                });

            migrationBuilder.CreateTable(
                name: "BatimentCategorie",
                columns: table => new
                {
                    BatimentId = table.Column<int>(type: "int", nullable: false),
                    CategorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatimentCategorie", x => new { x.BatimentId, x.CategorieId });
                    table.ForeignKey(
                        name: "FK_BatimentCategorie_Batiment_BatimentId",
                        column: x => x.BatimentId,
                        principalTable: "Batiment",
                        principalColumn: "BatimentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BatimentCategorie_Categorie_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categorie",
                        principalColumn: "CategorieId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatimentCategorie_CategorieId",
                table: "BatimentCategorie",
                column: "CategorieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatimentCategorie");

            migrationBuilder.DropTable(
                name: "Categorie");
        }
    }
}
