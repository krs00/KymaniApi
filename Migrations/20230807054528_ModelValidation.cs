using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KymaniApi.Migrations
{
    public partial class ModelValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kymanis",
                keyColumn: "Mood",
                keyValue: null,
                column: "Mood",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Mood",
                table: "Kymanis",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Kymanis",
                columns: new[] { "KymaniId", "Mood", "PowerLevel" },
                values: new object[] { 2, "Cool", 9001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kymanis",
                keyColumn: "KymaniId",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Mood",
                table: "Kymanis",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
