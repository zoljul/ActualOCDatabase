using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActualOCDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddNickName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "OriginalCharacter",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NickName",
                table: "OriginalCharacter");
        }
    }
}
