using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TibiaApi.Migrations
{
    /// <inheritdoc />
    public partial class BetaCharacter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CHARACTERS_TB_SKILLS_SkillsId",
                table: "TB_CHARACTERS");

            migrationBuilder.AlterColumn<int>(
                name: "SkillsId",
                table: "TB_CHARACTERS",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "TB_ACCOUNTS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 209, 245, 106, 177, 27, 69, 196, 175, 149, 171, 2, 186, 66, 208, 242, 254, 168, 181, 166, 54, 207, 152, 84, 77, 158, 252, 169, 130, 67, 167, 226, 216, 41, 232, 90, 66, 253, 114, 89, 75, 210, 175, 156, 109, 44, 132, 76, 0, 67, 248, 209, 31, 136, 247, 52, 170, 82, 185, 227, 185, 133, 212, 167, 221 }, new byte[] { 91, 194, 131, 249, 188, 92, 250, 92, 127, 153, 49, 9, 44, 153, 54, 241, 174, 39, 8, 37, 74, 225, 167, 111, 203, 236, 249, 67, 5, 107, 253, 150, 245, 253, 192, 27, 46, 215, 201, 194, 39, 137, 66, 82, 154, 204, 38, 71, 196, 18, 122, 112, 184, 166, 65, 129, 222, 122, 45, 124, 47, 147, 21, 146, 171, 57, 175, 28, 211, 236, 141, 204, 80, 223, 58, 114, 247, 214, 111, 241, 140, 155, 33, 83, 96, 211, 97, 48, 90, 151, 121, 248, 6, 224, 54, 183, 135, 183, 48, 42, 98, 70, 186, 214, 59, 15, 200, 211, 232, 117, 16, 36, 85, 58, 205, 77, 19, 160, 31, 79, 122, 196, 202, 45, 105, 88, 78, 85 } });

            migrationBuilder.InsertData(
                table: "TB_CHARACTERS",
                columns: new[] { "Id", "AccountId", "AcessDate", "CreationDate", "Gender", "Name", "SkillsId", "Vocation" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "BetaCharacter", null, 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CHARACTERS_TB_SKILLS_SkillsId",
                table: "TB_CHARACTERS",
                column: "SkillsId",
                principalTable: "TB_SKILLS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CHARACTERS_TB_SKILLS_SkillsId",
                table: "TB_CHARACTERS");

            migrationBuilder.DeleteData(
                table: "TB_CHARACTERS",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "SkillsId",
                table: "TB_CHARACTERS",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TB_ACCOUNTS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 207, 116, 158, 21, 198, 199, 138, 187, 101, 62, 210, 248, 38, 8, 134, 138, 81, 177, 11, 65, 192, 196, 23, 101, 227, 144, 224, 172, 161, 77, 26, 6, 94, 200, 249, 141, 63, 48, 205, 148, 12, 45, 56, 203, 46, 125, 243, 190, 117, 66, 87, 232, 32, 87, 174, 131, 67, 0, 177, 151, 70, 205, 10, 199 }, new byte[] { 36, 46, 203, 65, 196, 253, 234, 251, 210, 113, 208, 57, 144, 111, 134, 166, 31, 227, 70, 125, 91, 45, 198, 21, 9, 82, 130, 45, 150, 251, 104, 97, 84, 25, 23, 252, 133, 81, 164, 246, 13, 228, 112, 189, 254, 70, 74, 155, 19, 10, 127, 227, 210, 58, 239, 239, 235, 99, 42, 142, 255, 221, 49, 82, 143, 136, 173, 190, 255, 92, 168, 214, 47, 7, 18, 24, 122, 59, 74, 56, 234, 189, 170, 43, 195, 212, 22, 223, 133, 229, 25, 167, 139, 82, 93, 10, 39, 224, 240, 99, 110, 91, 7, 53, 204, 129, 216, 20, 19, 28, 106, 68, 115, 216, 150, 186, 208, 62, 60, 78, 245, 57, 171, 92, 51, 87, 97, 20 } });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CHARACTERS_TB_SKILLS_SkillsId",
                table: "TB_CHARACTERS",
                column: "SkillsId",
                principalTable: "TB_SKILLS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
