using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_Recruitment.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobPosting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryTasks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryTasks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHrApproved = table.Column<bool>(type: "bit", nullable: true),
                    IsDirApproved = table.Column<bool>(type: "bit", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPosting", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobPosting");
        }
    }
}
