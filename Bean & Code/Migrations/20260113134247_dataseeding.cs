using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bean___Code.Migrations
{
    /// <inheritdoc />
    public partial class dataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryConnectionId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryConnectionId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryConnectionId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CategoryKeyId",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Varma drycker" },
                    { 2, "Kalla drycker" },
                    { 3, "Bakverk" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "En stark italiensk kaffespecialitet", "Espresso", 25m },
                    { 2, 1, "Svart bryggt kaffe", "Coffe", 20m },
                    { 3, 1, "Mild kaffedrink med mycket mjölk", "Latte", 40m },
                    { 4, 1, "English breakfast", "Te", 15m },
                    { 5, 3, "En klassiker direkt från New York", "Cheesecake", 45m },
                    { 6, 2, "En fruktig och kall svensk ikon", "Trocadero", 20m },
                    { 7, 3, "Det bästa bakverket", "Kanelbulle", 40m },
                    { 8, 3, "Klassisk fabrikat chokladboll", "Delicatoboll", 25m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "CategoryKeyId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryConnectionId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryConnectionId",
                table: "Products",
                column: "CategoryConnectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryConnectionId",
                table: "Products",
                column: "CategoryConnectionId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
