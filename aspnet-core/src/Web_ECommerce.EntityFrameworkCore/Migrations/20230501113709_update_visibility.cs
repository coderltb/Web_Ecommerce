using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebECommerce.Migrations
{
    /// <inheritdoc />
    public partial class update_visibility : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Visiblity",
                table: "AppProducts",
                newName: "Visibility");

            migrationBuilder.AddColumn<int>(
                name: "EntityVersion",
                table: "AbpUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityVersion",
                table: "AbpTenants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityVersion",
                table: "AbpRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EntityVersion",
                table: "AbpOrganizationUnits",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntityVersion",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "EntityVersion",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "EntityVersion",
                table: "AbpRoles");

            migrationBuilder.DropColumn(
                name: "EntityVersion",
                table: "AbpOrganizationUnits");

            migrationBuilder.RenameColumn(
                name: "Visibility",
                table: "AppProducts",
                newName: "Visiblity");
        }
    }
}
