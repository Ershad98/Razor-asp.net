using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pizaaweb.Migrations
{
    /// <inheritdoc />
    public partial class addedpizzaorder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pizzaorders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pizaaname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pizzaprice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pizzaorders", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pizzaorders");
        }
    }
}
