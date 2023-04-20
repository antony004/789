using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _789.Migrations
{
    public partial class Fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrueCount",
                table: "Quizzes",
                newName: "Question25");

            migrationBuilder.AddColumn<int>(
                name: "Question11",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question12",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question13",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question14",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question15",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question16",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question17",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question18",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question19",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question20",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question21",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question22",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question23",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Question24",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "UserProfileId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserProfileId",
                table: "AspNetUsers",
                column: "UserProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Profiles_UserProfileId",
                table: "AspNetUsers",
                column: "UserProfileId",
                principalTable: "Profiles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Profiles_UserProfileId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserProfileId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Question11",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question12",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question13",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question14",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question15",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question16",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question17",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question18",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question19",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question20",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question21",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question22",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question23",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Question24",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "UserProfileId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Question25",
                table: "Quizzes",
                newName: "TrueCount");
        }
    }
}
