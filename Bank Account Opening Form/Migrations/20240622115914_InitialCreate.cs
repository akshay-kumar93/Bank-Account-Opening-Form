using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bank_Account_Opening_Form.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountOpeningForms",
                columns: table => new
                {
                    FormNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormFillingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormFillingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CustTitle = table.Column<int>(type: "int", nullable: false),
                    CustFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustSex = table.Column<int>(type: "int", nullable: false),
                    CustDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustAge = table.Column<int>(type: "int", nullable: false),
                    CustStdCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustTelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustEmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustStateCode = table.Column<int>(type: "int", nullable: false),
                    CustCityCode = table.Column<int>(type: "int", nullable: false),
                    CustBranchCode = table.Column<int>(type: "int", nullable: false),
                    CustAccountType = table.Column<int>(type: "int", nullable: false),
                    CustPreferredLanguage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountOpeningForms", x => x.FormNumber);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateCode);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityStateCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityCode);
                    table.ForeignKey(
                        name: "FK_Cities_States_CityStateCode",
                        column: x => x.CityStateCode,
                        principalTable: "States",
                        principalColumn: "StateCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchCityCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchCode);
                    table.ForeignKey(
                        name: "FK_Branches_Cities_BranchCityCode",
                        column: x => x.BranchCityCode,
                        principalTable: "Cities",
                        principalColumn: "CityCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_BranchCityCode",
                table: "Branches",
                column: "BranchCityCode");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CityStateCode",
                table: "Cities",
                column: "CityStateCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountOpeningForms");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "States");
        }
    }
}
