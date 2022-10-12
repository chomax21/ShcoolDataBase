using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolNumber2.Migrations
{
    public partial class AddingMarkTeacherCours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "marked",
                table: "TeacherCourses",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "marked",
                table: "TeacherCourses");
        }
    }
}
