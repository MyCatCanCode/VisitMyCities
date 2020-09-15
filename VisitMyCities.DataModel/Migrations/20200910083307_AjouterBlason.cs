using Microsoft.EntityFrameworkCore.Migrations;

namespace VisitMyCities.DataModel.Migrations
{
    public partial class AjouterBlason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListeDeVoyage_Ville_VilleId",
                table: "ListeDeVoyage");

            migrationBuilder.AddColumn<string>(
                name: "Blason",
                table: "Ville",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VilleId",
                table: "ListeDeVoyage",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URLBlason",
                table: "ListeDeVoyage",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ListeDeVoyage_Ville_VilleId",
                table: "ListeDeVoyage",
                column: "VilleId",
                principalTable: "Ville",
                principalColumn: "VilleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListeDeVoyage_Ville_VilleId",
                table: "ListeDeVoyage");

            migrationBuilder.DropColumn(
                name: "Blason",
                table: "Ville");

            migrationBuilder.DropColumn(
                name: "URLBlason",
                table: "ListeDeVoyage");

            migrationBuilder.AlterColumn<int>(
                name: "VilleId",
                table: "ListeDeVoyage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ListeDeVoyage_Ville_VilleId",
                table: "ListeDeVoyage",
                column: "VilleId",
                principalTable: "Ville",
                principalColumn: "VilleId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
