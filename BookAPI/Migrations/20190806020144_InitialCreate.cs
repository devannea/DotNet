using Microsoft.EntityFrameworkCore.Migrations;

namespace BookAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(maxLength: 250, nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "Author", "Category", "Title" },
                values: new object[] { 1, "John Steinbeck", "Historical Fiction", "The Grapes of Wrath" });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "Author", "Category", "Title" },
                values: new object[] { 2, "John Steinbeck", "Historical Fiction", "Cannery Row" });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "Author", "Category", "Title" },
                values: new object[] { 3, "Stephen King", "Horror", "The Shining" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");
        }
    }
}
