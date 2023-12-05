using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TibiaApi.Migrations
{
    /// <inheritdoc />
    public partial class CharacterSkills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_CHARACTERS_TB_SKILLS_SkillsId",
                table: "TB_CHARACTERS");

            migrationBuilder.DropIndex(
                name: "IX_TB_CHARACTERS_SkillsId",
                table: "TB_CHARACTERS");

            migrationBuilder.DropColumn(
                name: "SkillsId",
                table: "TB_CHARACTERS");

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "TB_SKILLS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ACCOUNTS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 206, 63, 207, 173, 32, 117, 60, 225, 183, 32, 126, 188, 56, 109, 15, 22, 55, 66, 245, 123, 105, 65, 218, 128, 125, 216, 221, 167, 227, 43, 169, 94, 190, 80, 16, 145, 57, 212, 200, 161, 134, 36, 254, 124, 119, 145, 105, 84, 37, 185, 169, 192, 241, 44, 82, 40, 221, 67, 137, 75, 192, 161, 149, 45 }, new byte[] { 198, 47, 249, 115, 253, 255, 186, 236, 3, 202, 100, 63, 188, 228, 116, 113, 245, 81, 103, 242, 142, 251, 97, 144, 157, 203, 234, 180, 213, 51, 73, 65, 238, 53, 9, 134, 250, 200, 204, 12, 219, 148, 145, 25, 54, 146, 247, 30, 68, 65, 193, 205, 87, 233, 251, 217, 128, 178, 173, 74, 155, 242, 72, 142, 209, 131, 43, 138, 38, 142, 44, 101, 186, 107, 54, 31, 111, 121, 159, 139, 242, 35, 89, 42, 193, 99, 187, 131, 173, 191, 128, 139, 121, 109, 214, 60, 84, 177, 11, 39, 22, 199, 5, 138, 43, 53, 167, 169, 237, 52, 144, 46, 77, 18, 83, 20, 236, 131, 37, 252, 152, 100, 1, 189, 141, 50, 209, 82 } });

            migrationBuilder.InsertData(
                table: "TB_SKILLS",
                columns: new[] { "Id", "AxeFigthing", "CharacterId", "ClubFigthing", "DistanceFigthing", "Fishing", "FistFigthing", "Level", "MagicLevel", "Shielding", "SwordFigthing" },
                values: new object[] { 1, 10, 1, 10, 10, 10, 10, 8, 1, 10, 10 });

            migrationBuilder.CreateIndex(
                name: "IX_TB_SKILLS_CharacterId",
                table: "TB_SKILLS",
                column: "CharacterId",
                unique: true);

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

            migrationBuilder.DropIndex(
                name: "IX_TB_SKILLS_CharacterId",
                table: "TB_SKILLS");

            migrationBuilder.DeleteData(
                table: "TB_SKILLS",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "TB_SKILLS");

            migrationBuilder.AddColumn<int>(
                name: "SkillsId",
                table: "TB_CHARACTERS",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TB_ACCOUNTS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 209, 245, 106, 177, 27, 69, 196, 175, 149, 171, 2, 186, 66, 208, 242, 254, 168, 181, 166, 54, 207, 152, 84, 77, 158, 252, 169, 130, 67, 167, 226, 216, 41, 232, 90, 66, 253, 114, 89, 75, 210, 175, 156, 109, 44, 132, 76, 0, 67, 248, 209, 31, 136, 247, 52, 170, 82, 185, 227, 185, 133, 212, 167, 221 }, new byte[] { 91, 194, 131, 249, 188, 92, 250, 92, 127, 153, 49, 9, 44, 153, 54, 241, 174, 39, 8, 37, 74, 225, 167, 111, 203, 236, 249, 67, 5, 107, 253, 150, 245, 253, 192, 27, 46, 215, 201, 194, 39, 137, 66, 82, 154, 204, 38, 71, 196, 18, 122, 112, 184, 166, 65, 129, 222, 122, 45, 124, 47, 147, 21, 146, 171, 57, 175, 28, 211, 236, 141, 204, 80, 223, 58, 114, 247, 214, 111, 241, 140, 155, 33, 83, 96, 211, 97, 48, 90, 151, 121, 248, 6, 224, 54, 183, 135, 183, 48, 42, 98, 70, 186, 214, 59, 15, 200, 211, 232, 117, 16, 36, 85, 58, 205, 77, 19, 160, 31, 79, 122, 196, 202, 45, 105, 88, 78, 85 } });

            migrationBuilder.UpdateData(
                table: "TB_CHARACTERS",
                keyColumn: "Id",
                keyValue: 1,
                column: "SkillsId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_TB_CHARACTERS_SkillsId",
                table: "TB_CHARACTERS",
                column: "SkillsId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_CHARACTERS_TB_SKILLS_SkillsId",
                table: "TB_CHARACTERS",
                column: "SkillsId",
                principalTable: "TB_SKILLS",
                principalColumn: "Id");
        }
    }
}
