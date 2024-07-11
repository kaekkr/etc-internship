using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETC_internship.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    FullNameKZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullNameRU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortNameKZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortNameRU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIODatPadejKZ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FIODatPadejRU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActivated = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HashedPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
