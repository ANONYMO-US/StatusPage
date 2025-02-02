using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskmanagementApi.Migrations.IncidentsDb
{
    /// <inheritdoc />
    public partial class UpdateCompanyServicesDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IncidentDescription",
                table: "ListofIncidents",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncidentDescription",
                table: "ListofIncidents");
        }
    }
}
