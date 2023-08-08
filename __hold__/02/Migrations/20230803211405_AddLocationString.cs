using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorOffice.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FloorRoom",
                table: "Locations",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FloorRoom",
                table: "Locations");
        }
    }
}
