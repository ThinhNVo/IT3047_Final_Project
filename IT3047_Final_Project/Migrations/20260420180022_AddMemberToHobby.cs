using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT3047_Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddMemberToHobby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Frequency",
                table: "Hobbies",
                newName: "MemberId");

            migrationBuilder.AddColumn<string>(
                name: "HowOften",
                table: "Hobbies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_MemberId",
                table: "Hobbies",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_Members_MemberId",
                table: "Hobbies",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_Members_MemberId",
                table: "Hobbies");

            migrationBuilder.DropIndex(
                name: "IX_Hobbies_MemberId",
                table: "Hobbies");

            migrationBuilder.DropColumn(
                name: "HowOften",
                table: "Hobbies");

            migrationBuilder.RenameColumn(
                name: "MemberId",
                table: "Hobbies",
                newName: "Frequency");
        }
    }
}
