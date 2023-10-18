using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TibiaApi.Migrations
{
    /// <inheritdoc />
    public partial class CreateCharacter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CHARACTERS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Vocation = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcessDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CHARACTERS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_CHARACTERS_TB_ACCOUNTS_AccountId",
                        column: x => x.AccountId,
                        principalTable: "TB_ACCOUNTS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    MagicLevel = table.Column<int>(type: "int", nullable: false),
                    FistFigthing = table.Column<int>(type: "int", nullable: false),
                    ClubFigthing = table.Column<int>(type: "int", nullable: false),
                    SwordFigthing = table.Column<int>(type: "int", nullable: false),
                    AxeFigthing = table.Column<int>(type: "int", nullable: false),
                    DistanceFigthing = table.Column<int>(type: "int", nullable: false),
                    Shielding = table.Column<int>(type: "int", nullable: false),
                    Fishing = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skill_TB_CHARACTERS_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "TB_CHARACTERS",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "TB_ACCOUNTS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 40, 177, 216, 197, 121, 89, 105, 113, 116, 235, 250, 218, 40, 216, 199, 232, 154, 89, 214, 163, 43, 242, 5, 155, 28, 109, 29, 191, 64, 52, 181, 110, 122, 66, 137, 61, 224, 204, 60, 249, 129, 226, 62, 63, 42, 220, 135, 225, 40, 87, 113, 99, 214, 237, 56, 67, 196, 122, 54, 162, 243, 14, 51, 2 }, new byte[] { 124, 64, 227, 145, 170, 18, 8, 47, 25, 1, 226, 165, 52, 82, 203, 53, 174, 103, 239, 64, 55, 193, 255, 183, 196, 228, 9, 92, 216, 162, 62, 182, 143, 71, 33, 160, 188, 11, 122, 166, 192, 183, 140, 251, 109, 44, 9, 22, 113, 226, 4, 197, 163, 125, 138, 158, 170, 47, 139, 248, 215, 4, 19, 70, 81, 11, 113, 121, 177, 208, 93, 255, 100, 179, 70, 190, 14, 203, 5, 166, 37, 59, 13, 16, 109, 210, 172, 107, 146, 15, 18, 103, 84, 30, 228, 110, 121, 48, 223, 70, 27, 85, 41, 72, 146, 24, 203, 184, 212, 168, 83, 88, 254, 69, 154, 54, 85, 26, 181, 207, 118, 1, 21, 72, 244, 34, 164, 73 } });

            migrationBuilder.InsertData(
                table: "TB_CHARACTERS",
                columns: new[] { "Id", "AccountId", "AcessDate", "CreationDate", "Gender", "Name", "Vocation" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "BetaCharacter", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Skill_CharacterId",
                table: "Skill",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CHARACTERS_AccountId",
                table: "TB_CHARACTERS",
                column: "AccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "TB_CHARACTERS");

            migrationBuilder.UpdateData(
                table: "TB_ACCOUNTS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 14, 96, 206, 248, 203, 31, 135, 32, 52, 237, 43, 178, 117, 248, 9, 46, 232, 11, 23, 226, 198, 137, 166, 137, 189, 161, 42, 212, 221, 28, 54, 120, 241, 172, 77, 52, 190, 185, 254, 182, 141, 205, 4, 8, 133, 252, 35, 223, 104, 238, 51, 253, 119, 150, 255, 89, 156, 157, 93, 134, 109, 27, 252, 150 }, new byte[] { 232, 78, 252, 109, 165, 176, 47, 117, 101, 61, 72, 215, 108, 190, 144, 227, 176, 236, 13, 195, 50, 117, 126, 65, 18, 225, 86, 163, 74, 99, 49, 229, 77, 78, 148, 42, 160, 79, 177, 68, 70, 91, 78, 82, 102, 107, 78, 199, 224, 174, 129, 190, 132, 199, 13, 47, 88, 208, 166, 125, 102, 115, 154, 195, 220, 136, 222, 182, 85, 92, 229, 17, 20, 172, 70, 101, 66, 182, 28, 194, 1, 238, 135, 34, 144, 55, 178, 39, 109, 2, 70, 94, 77, 83, 231, 64, 96, 94, 137, 138, 89, 78, 239, 240, 149, 26, 240, 156, 220, 248, 230, 28, 105, 109, 95, 11, 229, 145, 159, 199, 105, 57, 117, 114, 227, 10, 5, 201 } });
        }
    }
}
