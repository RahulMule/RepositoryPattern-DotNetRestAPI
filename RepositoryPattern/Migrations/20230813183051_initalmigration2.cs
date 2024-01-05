using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryPattern.Migrations
{
    /// <inheritdoc />
    public partial class initalmigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "email",
                table: "employees",
                newName: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "employees",
                newName: "email");
        }
    }
}
