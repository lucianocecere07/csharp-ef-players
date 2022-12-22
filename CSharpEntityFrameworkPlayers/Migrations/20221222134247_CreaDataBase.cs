using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class CreaDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    punteggio = table.Column<int>(type: "int", nullable: false),
                    partitegiocate = table.Column<int>(name: "partite_giocate", type: "int", nullable: false),
                    partitevinte = table.Column<int>(name: "partite_vinte", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_players", x => x.PlayerId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "players");
        }
    }
}
