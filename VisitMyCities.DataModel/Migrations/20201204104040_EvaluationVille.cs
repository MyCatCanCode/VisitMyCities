using Microsoft.EntityFrameworkCore.Migrations;

namespace VisitMyCities.DataModel.Migrations
{
    public partial class EvaluationVille : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UtilisateurVille",
                columns: table => new
                {
                    VilleId = table.Column<int>(nullable: false),
                    UtilisateurId = table.Column<string>(nullable: false),
                    NombreEtoiles = table.Column<int>(nullable: false),
                    Commentaire = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilisateurVille", x => new { x.UtilisateurId, x.VilleId });
                    table.ForeignKey(
                        name: "FK_UtilisateurVille_AspNetUsers_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UtilisateurVille_Ville_VilleId",
                        column: x => x.VilleId,
                        principalTable: "Ville",
                        principalColumn: "VilleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UtilisateurVille_VilleId",
                table: "UtilisateurVille",
                column: "VilleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UtilisateurVille");
        }
    }
}
