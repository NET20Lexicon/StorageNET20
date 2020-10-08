using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StorageNET20.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Shelf = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "OrderDate", "Price", "Shelf" },
                values: new object[,]
                {
                    { 1, "Mobile", 156, "Stupid", "Iphone", new DateTime(2020, 10, 2, 13, 55, 3, 993, DateTimeKind.Local).AddTicks(1902), 15600, "4B" },
                    { 2, "Mobile", 98, "Better", "S10", new DateTime(2020, 9, 15, 13, 55, 3, 996, DateTimeKind.Local).AddTicks(5499), 12450, "4C" },
                    { 3, "Computers", 23, "Stupid", "MacBook", new DateTime(2020, 10, 3, 13, 55, 3, 996, DateTimeKind.Local).AddTicks(5563), 45600, "4C" },
                    { 4, "Computer", 32, "Stupid", "Suface X", new DateTime(2020, 8, 29, 13, 55, 3, 996, DateTimeKind.Local).AddTicks(5722), 26850, "5C" },
                    { 5, "Office Supplies", 15651, "Stupid", "Pen", new DateTime(2020, 10, 2, 13, 55, 3, 996, DateTimeKind.Local).AddTicks(5725), 1, "45W" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
