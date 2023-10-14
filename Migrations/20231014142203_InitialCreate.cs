using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TibiaApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ACCOUNTS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcessDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ACCOUNTS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_ACCOUNTS",
                columns: new[] { "Id", "AcessDate", "CreationDate", "Email", "PasswordHash", "PasswordSalt", "PasswordString", "Username" },
                values: new object[] { 1, null, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "beta.tester@gmail.com", new byte[] { 14, 96, 206, 248, 203, 31, 135, 32, 52, 237, 43, 178, 117, 248, 9, 46, 232, 11, 23, 226, 198, 137, 166, 137, 189, 161, 42, 212, 221, 28, 54, 120, 241, 172, 77, 52, 190, 185, 254, 182, 141, 205, 4, 8, 133, 252, 35, 223, 104, 238, 51, 253, 119, 150, 255, 89, 156, 157, 93, 134, 109, 27, 252, 150 }, new byte[] { 232, 78, 252, 109, 165, 176, 47, 117, 101, 61, 72, 215, 108, 190, 144, 227, 176, 236, 13, 195, 50, 117, 126, 65, 18, 225, 86, 163, 74, 99, 49, 229, 77, 78, 148, 42, 160, 79, 177, 68, 70, 91, 78, 82, 102, 107, 78, 199, 224, 174, 129, 190, 132, 199, 13, 47, 88, 208, 166, 125, 102, 115, 154, 195, 220, 136, 222, 182, 85, 92, 229, 17, 20, 172, 70, 101, 66, 182, 28, 194, 1, 238, 135, 34, 144, 55, 178, 39, 109, 2, 70, 94, 77, 83, 231, 64, 96, 94, 137, 138, 89, 78, 239, 240, 149, 26, 240, 156, 220, 248, 230, 28, 105, 109, 95, 11, 229, 145, 159, 199, 105, 57, 117, 114, 227, 10, 5, 201 }, "", "BetaTester" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ACCOUNTS");
        }
    }
}
