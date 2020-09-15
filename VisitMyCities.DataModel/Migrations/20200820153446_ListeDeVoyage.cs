using Microsoft.EntityFrameworkCore.Migrations;

namespace VisitMyCities.DataModel.Migrations
{
    public partial class ListeDeVoyage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListeDeVoyageIdListe",
                table: "Batiment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomUtilisateur",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrenomUtilisateur",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SeSouvenir",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ListeDeVoyage",
                columns: table => new
                {
                    IdListe = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitreListe = table.Column<string>(nullable: true),
                    VilleId = table.Column<int>(nullable: true),
                    UtilisateurId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListeDeVoyage", x => x.IdListe);
                    table.ForeignKey(
                        name: "FK_ListeDeVoyage_AspNetUsers_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListeDeVoyage_Ville_VilleId",
                        column: x => x.VilleId,
                        principalTable: "Ville",
                        principalColumn: "VilleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batiment_ListeDeVoyageIdListe",
                table: "Batiment",
                column: "ListeDeVoyageIdListe");

            migrationBuilder.CreateIndex(
                name: "IX_ListeDeVoyage_UtilisateurId",
                table: "ListeDeVoyage",
                column: "UtilisateurId");

            migrationBuilder.CreateIndex(
                name: "IX_ListeDeVoyage_VilleId",
                table: "ListeDeVoyage",
                column: "VilleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Batiment_ListeDeVoyage_ListeDeVoyageIdListe",
                table: "Batiment",
                column: "ListeDeVoyageIdListe",
                principalTable: "ListeDeVoyage",
                principalColumn: "IdListe",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batiment_ListeDeVoyage_ListeDeVoyageIdListe",
                table: "Batiment");

            migrationBuilder.DropTable(
                name: "ListeDeVoyage");

            migrationBuilder.DropIndex(
                name: "IX_Batiment_ListeDeVoyageIdListe",
                table: "Batiment");

            migrationBuilder.DropColumn(
                name: "ListeDeVoyageIdListe",
                table: "Batiment");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NomUtilisateur",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PrenomUtilisateur",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SeSouvenir",
                table: "AspNetUsers");
        }
    }
}
