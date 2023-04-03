using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JoycePieShop.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsInStock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Pies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Pies");
        }
    }
}
