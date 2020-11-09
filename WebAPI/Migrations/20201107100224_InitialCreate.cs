using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    FirstName = table.Column<string>(type: "char(10)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    DOB = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
