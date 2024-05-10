using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBook.DataAcess.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 0, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 0, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 0, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 0, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 0, "" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 0, "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 1012, "https://images-na.ssl-images-amazon.com/images/I/51ZJ2qJ3JNL._SX331_BO1,204,203,200_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 1009, "https://images-na.ssl-images-amazon.com/images/I/51ZJ2qJ3JNL._SX331_BO1,204,203,200_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 1009, "https://images-na.ssl-images-amazon.com/images/I/51ZJ2qJ3JNL._SX331_BO1,204,203,200_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 1009, "https://images-na.ssl-images-amazon.com/images/I/51ZJ2qJ3JNL._SX331_BO1,204,203,200_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 1011, "https://images-na.ssl-images-amazon.com/images/I/51ZJ2qJ3JNL._SX331_BO1,204,203,200_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "ImageUrl" },
                values: new object[] { 1012, "https://images-na.ssl-images-amazon.com/images/I/51ZJ2qJ3JNL._SX331_BO1,204,203,200_.jpg" });
        }
    }
}
