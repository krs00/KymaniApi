using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KymaniApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Kymanis",
                columns: new[] { "KymaniId", "Mood", "PowerLevel" },
                values: new object[] { 1, "Happy", 12 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kymanis",
                keyColumn: "KymaniId",
                keyValue: 1);
        }
    }
}
