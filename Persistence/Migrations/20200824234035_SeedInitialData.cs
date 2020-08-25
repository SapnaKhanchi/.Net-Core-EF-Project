using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Values" },
                values: new object[] { 1, "Som" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Values" },
                values: new object[] { 2, "Vidu" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Values" },
                values: new object[] { 3, "Sapna" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
