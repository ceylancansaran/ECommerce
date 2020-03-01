using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ECommerce.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Surname = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 350, nullable: false),
                    Password = table.Column<string>(maxLength: 40, nullable: false),
                    Admin = table.Column<bool>(nullable: false),
                    AutoLoginKey = table.Column<Guid>(nullable: true),
                    TitleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Active", "CreateDate", "Deleted", "Name", "UpdateDate" },
                values: new object[] { 1, true, new DateTime(2020, 3, 1, 15, 20, 4, 747, DateTimeKind.Utc), false, "Müşteri", null });

            migrationBuilder.InsertData(
                table: "Titles",
                columns: new[] { "Id", "Active", "CreateDate", "Deleted", "Name", "UpdateDate" },
                values: new object[] { 2, true, new DateTime(2020, 3, 1, 15, 20, 4, 748, DateTimeKind.Utc), false, "Yönetici", null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Active", "Admin", "AutoLoginKey", "CreateDate", "Deleted", "Email", "Name", "Password", "Surname", "TitleId", "UpdateDate" },
                values: new object[] { 1, true, true, null, new DateTime(2020, 3, 1, 15, 20, 4, 748, DateTimeKind.Utc), false, "admin@admin.com", "Admin", "7C222FB2927D828AF22F592134E8932480637C0D", "Admin", 2, null });

            migrationBuilder.CreateIndex(
                name: "IX_Users_TitleId",
                table: "Users",
                column: "TitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Titles");
        }
    }
}
