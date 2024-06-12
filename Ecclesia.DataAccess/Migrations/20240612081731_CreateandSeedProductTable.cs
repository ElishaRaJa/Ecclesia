using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecclesia.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateandSeedProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ISBN", "ListPrice", "Title" },
                values: new object[,]
                {
                    { 1, "Lorem seas at watch the weategres", "SWD999999901", 5000.0, "Sea" },
                    { 2, "Lorem Fields at watch the weategres loret, toem die . et em Buire", "SWD599499201", 8000.0, "Field" },
                    { 3, "Lorem Fields at watch the weategres loret, toem die . et em Buire", "SWD5942369201", 18000.0, "Mounatin" },
                    { 4, "Lorem Fields at watch the weategres loret, toem die . et em Buire", "SWD599499201", 8000.0, "Field" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
