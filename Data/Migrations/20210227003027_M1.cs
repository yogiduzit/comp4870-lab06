using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab6.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "517dff9f-57fb-4332-a8ea-9945bc21e660", "Jane", "Smith", "Medicine" },
                    { "bee24b85-4244-469f-a1c4-199976fb2f4f", "John", "Fisher", "Engineering" },
                    { "9b089397-05ec-4454-b593-ad7e02cbb66d", "Pamela", "Baker", "Food Science" },
                    { "f904b5a4-4528-47c4-9c75-c7f7e83034a9", "Peter", "Taylor", "Mining" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
