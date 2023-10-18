using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TibiaApi.Migrations
{
    /// <inheritdoc />
    public partial class CreateSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skill_TB_CHARACTERS_CharacterId",
                table: "Skill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skill",
                table: "Skill");

            migrationBuilder.RenameTable(
                name: "Skill",
                newName: "TB_SKILLS");

            migrationBuilder.RenameIndex(
                name: "IX_Skill_CharacterId",
                table: "TB_SKILLS",
                newName: "IX_TB_SKILLS_CharacterId");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "TB_SKILLS",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_SKILLS",
                table: "TB_SKILLS",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "TB_ACCOUNTS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 190, 163, 235, 11, 232, 6, 243, 222, 47, 192, 14, 99, 153, 10, 12, 6, 96, 134, 127, 75, 143, 78, 169, 244, 220, 5, 76, 134, 83, 110, 214, 39, 103, 232, 250, 4, 98, 251, 14, 140, 189, 196, 22, 87, 162, 167, 242, 43, 217, 144, 100, 166, 26, 161, 159, 210, 111, 68, 92, 90, 83, 138, 213, 217 }, new byte[] { 169, 78, 123, 76, 62, 193, 7, 74, 96, 132, 63, 97, 162, 214, 36, 60, 236, 239, 96, 28, 61, 172, 151, 13, 112, 27, 55, 113, 23, 57, 222, 221, 142, 180, 177, 58, 113, 178, 199, 185, 147, 126, 5, 235, 84, 32, 158, 54, 244, 169, 180, 127, 15, 143, 147, 2, 87, 137, 133, 189, 154, 162, 246, 166, 227, 89, 126, 147, 8, 159, 1, 112, 234, 195, 234, 45, 155, 15, 76, 119, 167, 215, 79, 59, 12, 199, 244, 94, 63, 220, 103, 34, 158, 180, 239, 101, 239, 143, 252, 52, 56, 210, 104, 179, 247, 184, 23, 137, 127, 62, 7, 65, 176, 84, 196, 187, 123, 209, 45, 117, 31, 81, 171, 146, 130, 16, 215, 34 } });

            migrationBuilder.InsertData(
                table: "TB_SKILLS",
                columns: new[] { "Id", "AxeFigthing", "CharacterId", "ClubFigthing", "DistanceFigthing", "Fishing", "FistFigthing", "Level", "MagicLevel", "Shielding", "SwordFigthing" },
                values: new object[] { 1, 10, 1, 10, 10, 10, 10, 8, 1, 10, 10 });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_SKILLS_TB_CHARACTERS_CharacterId",
                table: "TB_SKILLS",
                column: "CharacterId",
                principalTable: "TB_CHARACTERS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_SKILLS_TB_CHARACTERS_CharacterId",
                table: "TB_SKILLS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_SKILLS",
                table: "TB_SKILLS");

            migrationBuilder.DeleteData(
                table: "TB_SKILLS",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "TB_SKILLS",
                newName: "Skill");

            migrationBuilder.RenameIndex(
                name: "IX_TB_SKILLS_CharacterId",
                table: "Skill",
                newName: "IX_Skill_CharacterId");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "Skill",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skill",
                table: "Skill",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "TB_ACCOUNTS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 40, 177, 216, 197, 121, 89, 105, 113, 116, 235, 250, 218, 40, 216, 199, 232, 154, 89, 214, 163, 43, 242, 5, 155, 28, 109, 29, 191, 64, 52, 181, 110, 122, 66, 137, 61, 224, 204, 60, 249, 129, 226, 62, 63, 42, 220, 135, 225, 40, 87, 113, 99, 214, 237, 56, 67, 196, 122, 54, 162, 243, 14, 51, 2 }, new byte[] { 124, 64, 227, 145, 170, 18, 8, 47, 25, 1, 226, 165, 52, 82, 203, 53, 174, 103, 239, 64, 55, 193, 255, 183, 196, 228, 9, 92, 216, 162, 62, 182, 143, 71, 33, 160, 188, 11, 122, 166, 192, 183, 140, 251, 109, 44, 9, 22, 113, 226, 4, 197, 163, 125, 138, 158, 170, 47, 139, 248, 215, 4, 19, 70, 81, 11, 113, 121, 177, 208, 93, 255, 100, 179, 70, 190, 14, 203, 5, 166, 37, 59, 13, 16, 109, 210, 172, 107, 146, 15, 18, 103, 84, 30, 228, 110, 121, 48, 223, 70, 27, 85, 41, 72, 146, 24, 203, 184, 212, 168, 83, 88, 254, 69, 154, 54, 85, 26, 181, 207, 118, 1, 21, 72, 244, 34, 164, 73 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_TB_CHARACTERS_CharacterId",
                table: "Skill",
                column: "CharacterId",
                principalTable: "TB_CHARACTERS",
                principalColumn: "Id");
        }
    }
}
