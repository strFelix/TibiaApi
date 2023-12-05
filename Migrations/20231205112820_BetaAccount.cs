using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TibiaApi.Migrations
{
    /// <inheritdoc />
    public partial class BetaAccount : Migration
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
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcessDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ACCOUNTS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_SKILLS",
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
                    Fishing = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_SKILLS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_CHARACTERS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    SkillsId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Vocation = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcessDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_TB_CHARACTERS_TB_SKILLS_SkillsId",
                        column: x => x.SkillsId,
                        principalTable: "TB_SKILLS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_ACCOUNTS",
                columns: new[] { "Id", "AcessDate", "CreationDate", "Email", "PasswordHash", "PasswordSalt", "PasswordString", "Username" },
                values: new object[] { 1, null, new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "beta.tester@gmail.com", new byte[] { 207, 116, 158, 21, 198, 199, 138, 187, 101, 62, 210, 248, 38, 8, 134, 138, 81, 177, 11, 65, 192, 196, 23, 101, 227, 144, 224, 172, 161, 77, 26, 6, 94, 200, 249, 141, 63, 48, 205, 148, 12, 45, 56, 203, 46, 125, 243, 190, 117, 66, 87, 232, 32, 87, 174, 131, 67, 0, 177, 151, 70, 205, 10, 199 }, new byte[] { 36, 46, 203, 65, 196, 253, 234, 251, 210, 113, 208, 57, 144, 111, 134, 166, 31, 227, 70, 125, 91, 45, 198, 21, 9, 82, 130, 45, 150, 251, 104, 97, 84, 25, 23, 252, 133, 81, 164, 246, 13, 228, 112, 189, 254, 70, 74, 155, 19, 10, 127, 227, 210, 58, 239, 239, 235, 99, 42, 142, 255, 221, 49, 82, 143, 136, 173, 190, 255, 92, 168, 214, 47, 7, 18, 24, 122, 59, 74, 56, 234, 189, 170, 43, 195, 212, 22, 223, 133, 229, 25, 167, 139, 82, 93, 10, 39, 224, 240, 99, 110, 91, 7, 53, 204, 129, 216, 20, 19, 28, 106, 68, 115, 216, 150, 186, 208, 62, 60, 78, 245, 57, 171, 92, 51, 87, 97, 20 }, "", "BetaTester" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_CHARACTERS_AccountId",
                table: "TB_CHARACTERS",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CHARACTERS_SkillsId",
                table: "TB_CHARACTERS",
                column: "SkillsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_CHARACTERS");

            migrationBuilder.DropTable(
                name: "TB_ACCOUNTS");

            migrationBuilder.DropTable(
                name: "TB_SKILLS");
        }
    }
}
