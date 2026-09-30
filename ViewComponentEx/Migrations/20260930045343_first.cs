using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ViewComponentEx.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });

            migrationBuilder.CreateTable(
                name: "Emps",
                columns: table => new
                {
                    EmpID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emps", x => x.EmpID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MfgName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "Author", "BookName", "Price" },
                values: new object[,]
                {
                    { 1L, "Yeshwant Kanetkar", "Let us C", 500m },
                    { 2L, "Steve Gothic", "Complete Ref C", 550m }
                });

            migrationBuilder.InsertData(
                table: "Emps",
                columns: new[] { "EmpID", "DeptName", "EmpName", "Salary" },
                values: new object[,]
                {
                    { 121L, "Computer", "Sunil", 12000m },
                    { 122L, "Computer", "Amit", 56000m },
                    { 123L, "Sales", "Manish", 21000m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "MfgName", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1L, "Intex", 950m, "Mouse" },
                    { 2L, "Logitech", 1150m, "Keyboard" },
                    { 3L, "LG", 2950m, "Monitor" },
                    { 4L, "cello", 450m, "Bottle" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Emps");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
