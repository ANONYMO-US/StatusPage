using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskmanagementApi.Migrations.IncidentsDb
{
    /// <inheritdoc />
    public partial class AddNewIncidentsDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListofIncidents",
                columns: table => new
                {
                    IncidentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ServiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    IncidentStatus = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListofIncidents", x => x.IncidentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListofIncidents");
        }
    }
}
