using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eps.Booking.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class setfullname_doctor_patient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Doctors");
        }
    }
}
