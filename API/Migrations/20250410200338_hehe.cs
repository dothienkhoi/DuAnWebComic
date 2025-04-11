using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class hehe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Comic" },
                    { 2, "Electronic" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?", "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg", "Dc Versus Marvel Omnibus", 125m, 10 },
                    { 2, 1, "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?", "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg", "Dc Versus Marvel Omnibus", 125m, 10 },
                    { 3, 1, "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?", "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg", "Dc Versus Marvel Omnibus", 125m, 10 },
                    { 4, 1, "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?", "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg", "Dc Versus Marvel Omnibus", 125m, 10 },
                    { 5, 1, "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?", "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg", "Dc Versus Marvel Omnibus", 125m, 10 },
                    { 6, 1, "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?", "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg", "Dc Versus Marvel Omnibus", 125m, 10 },
                    { 7, 1, "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?", "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg", "Dc Versus Marvel Omnibus", 125m, 10 },
                    { 8, 1, "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?", "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg", "Dc Versus Marvel Omnibus", 125m, 10 },
                    { 9, 1, "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?", "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg", "Dc Versus Marvel Omnibus", 125m, 10 },
                    { 10, 1, "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?", "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg", "Dc Versus Marvel Omnibus", 125m, 10 },
                    { 11, 1, "Superman vs. Spider-Man? Batman vs. Captain America? The X-Men meeting the Teen Titans?", "/Images/Comic/Book/Dc Versus Marvel Omnibus.jpg", "Dc Versus Marvel Omnibus", 125m, 10 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "a" },
                    { 2, "b" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
