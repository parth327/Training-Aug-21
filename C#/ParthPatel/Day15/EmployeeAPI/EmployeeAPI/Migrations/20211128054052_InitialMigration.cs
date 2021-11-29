using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 240, nullable: true),
                    AddressLine2 = table.Column<string>(maxLength: 240, nullable: true),
                    AddressLine3 = table.Column<string>(maxLength: 240, nullable: true),
                    CitizenShipId = table.Column<long>(nullable: false),
                    CitizenShipLegislationCode = table.Column<string>(maxLength: 30, nullable: true),
                    CitizenShipStatus = table.Column<string>(maxLength: 30, nullable: true),
                    CitizenShipToDate = table.Column<DateTime>(nullable: false),
                    City = table.Column<string>(maxLength: 30, nullable: true),
                    CorrespondenceLangauge = table.Column<string>(maxLength: 30, nullable: true),
                    Country = table.Column<string>(maxLength: 60, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DisplayName = table.Column<string>(maxLength: 240, nullable: true),
                    DriversLicenseExpirationDate = table.Column<DateTime>(nullable: false),
                    DriversLicenseId = table.Column<long>(nullable: false),
                    DriversLicenseIssuingCountry = table.Column<string>(maxLength: 30, nullable: true),
                    EffectiveStartDate = table.Column<DateTime>(nullable: false),
                    Ethnicity = table.Column<string>(maxLength: 30, nullable: true),
                    FirstName = table.Column<string>(maxLength: 150, nullable: true),
                    Gender = table.Column<string>(maxLength: 30, nullable: true),
                    HireDate = table.Column<DateTime>(nullable: false),
                    HomeFaxAreaCode = table.Column<string>(maxLength: 30, nullable: true),
                    HomeFaxCountryCode = table.Column<string>(maxLength: 30, nullable: true),
                    HomeFaxExtension = table.Column<string>(maxLength: 60, nullable: true),
                    HomeFaxLegislationCode = table.Column<string>(maxLength: 4, nullable: true),
                    HomeFaxNumber = table.Column<string>(maxLength: 60, nullable: true),
                    HomePhoneAreaCode = table.Column<string>(maxLength: 30, nullable: true),
                    HomePhoneCountryCode = table.Column<string>(maxLength: 30, nullable: true),
                    HomePhoneExtension = table.Column<string>(maxLength: 60, nullable: true),
                    HomePhoneLegislationCode = table.Column<string>(maxLength: 4, nullable: true),
                    HomePhoneNumber = table.Column<string>(maxLength: 60, nullable: true),
                    Honors = table.Column<string>(maxLength: 80, nullable: true),
                    LastName = table.Column<string>(maxLength: 150, nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LegalEntityId = table.Column<long>(nullable: false),
                    LicenseNumber = table.Column<string>(maxLength: 150, nullable: true),
                    MaritalStatus = table.Column<string>(maxLength: 30, nullable: true),
                    MiddleName = table.Column<string>(maxLength: 80, nullable: true),
                    MilitaryVetStatus = table.Column<string>(maxLength: 30, nullable: true),
                    NameSuffix = table.Column<string>(maxLength: 80, nullable: true),
                    NationalID = table.Column<string>(maxLength: 30, nullable: true),
                    NationalIdCountry = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AssignmentId = table.Column<long>(nullable: false),
                    ActionCode = table.Column<string>(maxLength: 30, nullable: true),
                    ActionReasonCode = table.Column<string>(maxLength: 30, nullable: true),
                    ActualTerminationDate = table.Column<DateTime>(nullable: false),
                    AssignmentCategory = table.Column<string>(maxLength: 30, nullable: true),
                    AssignmentName = table.Column<string>(maxLength: 80, nullable: true),
                    AssignmentNumber = table.Column<string>(maxLength: 30, nullable: true),
                    AssignmentProjectEndDate = table.Column<DateTime>(nullable: false),
                    AssignmentStatus = table.Column<string>(maxLength: 30, nullable: true),
                    AssignmentStatusTypeId = table.Column<long>(nullable: false),
                    BuisnessUnitID = table.Column<long>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    DefualtExpenseAccount = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<long>(nullable: false),
                    EffectiveEndDate = table.Column<DateTime>(nullable: false),
                    EffectiveStartDate = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<string>(maxLength: 5, nullable: true),
                    Frequency = table.Column<string>(maxLength: 30, nullable: true),
                    FullPartTime = table.Column<string>(maxLength: 30, nullable: true),
                    GradeID = table.Column<long>(nullable: false),
                    GradeLadderId = table.Column<long>(nullable: false),
                    JobId = table.Column<long>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false),
                    LegalEntityID = table.Column<long>(nullable: false),
                    LocationID = table.Column<long>(nullable: false),
                    ManagerAssignmentId = table.Column<long>(nullable: false),
                    ManagerID = table.Column<long>(nullable: false),
                    EmployeeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_EmployeeId",
                table: "Assignments",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
