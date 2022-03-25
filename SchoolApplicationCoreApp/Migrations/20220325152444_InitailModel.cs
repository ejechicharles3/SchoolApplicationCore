using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolApplicationCoreApp.Migrations
{
    public partial class InitailModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthDate", "Class", "Name" },
                values: new object[] { new Guid("6e27dd8e-ef2d-450b-b12d-0f18f2ce7bff"), new DateTime(1982, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "SS III", "Ejechi Charles" });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthDate", "Class", "Name" },
                values: new object[] { new Guid("a0a530c5-4c4b-4fde-b35c-ef20a7b31554"), new DateTime(2011, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "SS II", "Emmanuel Okokon" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
