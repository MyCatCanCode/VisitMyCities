using Microsoft.EntityFrameworkCore.Migrations;

namespace VisitMyCities.DataModel.Migrations
{
    public partial class EvaluationBatiments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UtilisateurBatiment",
                columns: table => new
                {
                    BatimentId = table.Column<int>(nullable: false),
                    UtilisateurId = table.Column<string>(nullable: false),
                    NombreEtoiles = table.Column<int>(nullable: false),
                    Commentaire = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilisateurBatiment", x => new { x.UtilisateurId, x.BatimentId });
                    table.ForeignKey(
                        name: "FK_UtilisateurBatiment_Batiment_BatimentId",
                        column: x => x.BatimentId,
                        principalTable: "Batiment",
                        principalColumn: "BatimentId");
                    table.ForeignKey(
                        name: "FK_UtilisateurBatiment_AspNetUsers_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UtilisateurBatiment_BatimentId",
                table: "UtilisateurBatiment",
                column: "BatimentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UtilisateurBatiment");
        }
    }
}
