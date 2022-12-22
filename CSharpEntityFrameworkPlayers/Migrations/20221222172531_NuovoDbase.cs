using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSharpEntityFrameworkPlayers.Migrations
{
    /// <inheritdoc />
    public partial class NuovoDbase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "team",
                columns: table => new
                {
                    teamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    città = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    allenatore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    colori = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_team", x => x.teamId);
                });

            migrationBuilder.CreateTable(
                name: "players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    punteggio = table.Column<double>(type: "float", nullable: false),
                    partitegiocate = table.Column<int>(name: "partite_giocate", type: "int", nullable: false),
                    partitevinte = table.Column<int>(name: "partite_vinte", type: "int", nullable: false),
                    teamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_players_team_teamId",
                        column: x => x.teamId,
                        principalTable: "team",
                        principalColumn: "teamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_players_teamId",
                table: "players",
                column: "teamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "players");

            migrationBuilder.DropTable(
                name: "team");
        }
    }
}
