using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ActualOCDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddAffiliation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Affiliation",
                table: "OriginalCharacter",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Affiliation",
                table: "OriginalCharacter");
        }
    }
}
