using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32e6f556-498b-4ffe-86bb-2473fb09f9f5", "b8b66999-3068-4d94-8670-3c8fa03a9cb5", "Admin", "ADMIN" },
                    { "a7815ce1-a608-4e42-bd58-db2ac9878597", "271f8078-009c-4667-8bb4-80e3af479d14", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32e6f556-498b-4ffe-86bb-2473fb09f9f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7815ce1-a608-4e42-bd58-db2ac9878597");
        }
    }
}
