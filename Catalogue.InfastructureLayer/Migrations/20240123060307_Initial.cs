using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalogue.InfastructureLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProdutcId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "ImgUrl", "ProductDescription", "ProductName", "ProdutcId", "SubCategory" },
                values: new object[,]
                {
                    { new Guid("117d947f-31e4-4a96-b2c2-1e2df09ef429"), "OnePlus", "TV.jpj", "it is user friendly", "Tv", 149, "OnePlus9pro" },
                    { new Guid("2d3264b3-1ba4-4f6b-b020-7aa1df3ee3b9"), "Samsung", "TV.jpj", "it is user friendly", "Tv", 148, "Samsung9pro" },
                    { new Guid("391a17f9-a053-46e5-b0c8-71138939f197"), "Sony", "TV.jpj", "it is user friendly", "Tv", 130, "SonyBravia" },
                    { new Guid("4bdf41b9-db10-4923-bdb2-c68a3d4c91d2"), "OnePlus", "TV.jpj", "it is user friendly", "Tv", 145, "OnePlus9pro" },
                    { new Guid("8691edd4-40e2-4c48-b64d-a13dc02109ad"), "Redmi", "mobile.jpj", "it is user friendly", "Mobiles", 145, "Redmi7pro" },
                    { new Guid("9245fe4a-d402-451c-b9ed-9c1a04247482"), "Realme", "mobile.jpj", "it is user friendly", "Mobiles", 146, "Realme10pro" },
                    { new Guid("defd41d0-2529-4294-86f6-8ba3879fe1fe"), "Iphone", "mobile.jpj", "it is user friendly", "Mobiles", 11, "Iphone14pro" },
                    { new Guid("fc794bfc-4fea-48a3-be89-17c71265a9a8"), "Realme", "TV.jpj", "it is user friendly", "Tv", 150, "Realme10pro" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
