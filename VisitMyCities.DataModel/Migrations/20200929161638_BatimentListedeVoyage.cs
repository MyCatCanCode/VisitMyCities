using Microsoft.EntityFrameworkCore.Migrations;

namespace VisitMyCities.DataModel.Migrations
{
    public partial class BatimentListedeVoyage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batiment_ListeDeVoyage_ListeDeVoyageIdListe",
                table: "Batiment");

            migrationBuilder.DropIndex(
                name: "IX_Batiment_ListeDeVoyageIdListe",
                table: "Batiment");

            migrationBuilder.DropColumn(
                name: "ListeDeVoyageIdListe",
                table: "Batiment");

            migrationBuilder.CreateTable(
                name: "BatimentListeDeVoyage",
                columns: table => new
                {
                    BatimentId = table.Column<int>(nullable: false),
                    IdListe = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatimentListeDeVoyage", x => new { x.BatimentId, x.IdListe });
                    table.ForeignKey(
                        name: "FK_BatimentListeDeVoyage_Batiment_BatimentId",
                        column: x => x.BatimentId,
                        principalTable: "Batiment",
                        principalColumn: "BatimentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BatimentListeDeVoyage_ListeDeVoyage_IdListe",
                        column: x => x.IdListe,
                        principalTable: "ListeDeVoyage",
                        principalColumn: "IdListe");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatimentListeDeVoyage_IdListe",
                table: "BatimentListeDeVoyage",
                column: "IdListe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatimentListeDeVoyage");

            migrationBuilder.AddColumn<int>(
                name: "ListeDeVoyageIdListe",
                table: "Batiment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Batiment_ListeDeVoyageIdListe",
                table: "Batiment",
                column: "ListeDeVoyageIdListe");

            migrationBuilder.AddForeignKey(
                name: "FK_Batiment_ListeDeVoyage_ListeDeVoyageIdListe",
                table: "Batiment",
                column: "ListeDeVoyageIdListe",
                principalTable: "ListeDeVoyage",
                principalColumn: "IdListe",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
