using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MotorcycleRacing.Migrations
{
    /// <inheritdoc />
    public partial class add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "motos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Leader = table.Column<int>(type: "int", nullable: true),
                    Previous = table.Column<int>(type: "int", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AME = table.Column<int>(type: "int", nullable: true),
                    ARA = table.Column<int>(type: "int", nullable: true),
                    ARG = table.Column<int>(type: "int", nullable: true),
                    AUS = table.Column<int>(type: "int", nullable: true),
                    AUT = table.Column<int>(type: "int", nullable: true),
                    CAT = table.Column<int>(type: "int", nullable: true),
                    FRA = table.Column<int>(type: "int", nullable: true),
                    GBR = table.Column<int>(type: "int", nullable: true),
                    GER = table.Column<int>(type: "int", nullable: true),
                    INA = table.Column<int>(type: "int", nullable: true),
                    ITA = table.Column<int>(type: "int", nullable: true),
                    JPN = table.Column<int>(type: "int", nullable: true),
                    MAL = table.Column<int>(type: "int", nullable: true),
                    NED = table.Column<int>(type: "int", nullable: true),
                    POR = table.Column<int>(type: "int", nullable: true),
                    QAT = table.Column<int>(type: "int", nullable: true),
                    RSM = table.Column<int>(type: "int", nullable: true),
                    SPA = table.Column<int>(type: "int", nullable: true),
                    THA = table.Column<int>(type: "int", nullable: true),
                    VAL = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "motos");
        }
    }
}
