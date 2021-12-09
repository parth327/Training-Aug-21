using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeAPI.Migrations
{
    public partial class Ini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    AssignmentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionCode = table.Column<string>(nullable: true),
                    ActionReasonCode = table.Column<string>(nullable: true),
                    ActualTerminationDate = table.Column<DateTime>(nullable: true),
                    AssignmentCategory = table.Column<string>(nullable: true),
                    assignmentDFF = table.Column<string>(nullable: true),
                    assignmentExtraInformation = table.Column<int>(nullable: true),
                    AssignmentName = table.Column<string>(nullable: true),
                    AssignmentNumber = table.Column<string>(nullable: true),
                    AssignmentProjectedEndDate = table.Column<DateTime>(nullable: true),
                    AssignmentStatus = table.Column<string>(nullable: true),
                    AssignmentStatusTypeId = table.Column<long>(nullable: true),
                    BusinessUnitId = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    DefaultExpenseAccount = table.Column<string>(nullable: true),
                    DepartmentId = table.Column<long>(nullable: true),
                    EffectiveEndDate = table.Column<DateTime>(nullable: true),
                    EffectiveStartDate = table.Column<DateTime>(nullable: true),
                    empreps = table.Column<string>(nullable: true),
                    EndTime = table.Column<string>(nullable: true),
                    Frequency = table.Column<string>(nullable: true),
                    FullPartTime = table.Column<string>(nullable: true),
                    GradeId = table.Column<long>(nullable: true),
                    GradeLadderId = table.Column<long>(nullable: true),
                    JobId = table.Column<long>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: true),
                    LegalEntityId = table.Column<long>(nullable: true),
                    links = table.Column<string>(nullable: true),
                    LocationId = table.Column<long>(nullable: true),
                    ManagerAssignmentId = table.Column<long>(nullable: true),
                    ManagerId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.AssignmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    CitizenshipId = table.Column<long>(nullable: true),
                    CitizenshipLegislationCode = table.Column<string>(nullable: true),
                    CitizenshipStatus = table.Column<string>(nullable: true),
                    CitizenshipToDate = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    CorrespondenceLanguage = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    directReports = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    DriversLicenseExpirationDate = table.Column<DateTime>(nullable: true),
                    DriversLicenseId = table.Column<long>(nullable: true),
                    DriversLicenseIssuingCountry = table.Column<string>(nullable: true),
                    EffectiveStartDate = table.Column<DateTime>(nullable: true),
                    Ethnicity = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: true),
                    HomeFaxAreaCode = table.Column<string>(nullable: true),
                    HomeFaxCountryCode = table.Column<string>(nullable: true),
                    HomeFaxExtension = table.Column<string>(nullable: true),
                    HomeFaxLegislationCode = table.Column<string>(nullable: true),
                    HomeFaxNumber = table.Column<string>(nullable: true),
                    HomePhoneAreaCode = table.Column<string>(nullable: true),
                    HomePhoneCountryCode = table.Column<string>(nullable: true),
                    HomePhoneExtension = table.Column<string>(nullable: true),
                    HomePhoneLegislationCode = table.Column<string>(nullable: true),
                    HomePhoneNumber = table.Column<string>(nullable: true),
                    Honors = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    LastUpdateDate = table.Column<DateTime>(nullable: true),
                    LegalEntityId = table.Column<long>(nullable: true),
                    LicenseNumber = table.Column<string>(nullable: true),
                    links = table.Column<string>(nullable: true),
                    MaritalStatus = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    MilitaryVetStatus = table.Column<string>(nullable: true),
                    NameSuffix = table.Column<string>(nullable: true),
                    NationalId = table.Column<string>(nullable: true),
                    NationalIdCountry = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Assignments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(nullable: false),
                    AssignmentId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Assignments_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Assignments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Assignments_AssignmentId",
                table: "Employee_Assignments",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Assignments_EmployeeId",
                table: "Employee_Assignments",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Assignments");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
