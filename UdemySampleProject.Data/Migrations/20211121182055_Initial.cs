using Microsoft.EntityFrameworkCore.Migrations;

namespace UdemySampleProject.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categpries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categpries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    decimal182 = table.Column<decimal>(name: "decimal(18,2)", type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    InnerBarcode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categpries_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categpries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categpries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Kalemler" });

            migrationBuilder.InsertData(
                table: "Categpries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Defterler" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "InnerBarcode", "IsDeleted", "Name", "decimal(18,2)", "Stock" },
                values: new object[,]
                {
                    { 1, 1, null, false, "Pilot Kalem", 12.50m, 100 },
                    { 2, 1, null, false, "Kurşun Kalem", 40.50m, 200 },
                    { 3, 1, null, false, "Tükenmez Kalem", 500m, 300 },
                    { 4, 2, null, false, "Küçük Boy Defter", 12.50m, 100 },
                    { 5, 2, null, false, "Orta Boy Defter", 12.50m, 100 },
                    { 6, 2, null, false, "Büyük Boy Defter", 12.50m, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categpries");
        }
    }
}
