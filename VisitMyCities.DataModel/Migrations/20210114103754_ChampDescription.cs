using Microsoft.EntityFrameworkCore.Migrations;

namespace VisitMyCities.DataModel.Migrations
{
    public partial class ChampDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionVille",
                table: "Ville",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionListe",
                table: "ListeDeVoyage",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionVille",
                table: "Ville");

            migrationBuilder.DropColumn(
                name: "DescriptionListe",
                table: "ListeDeVoyage");
        }
    }
}
