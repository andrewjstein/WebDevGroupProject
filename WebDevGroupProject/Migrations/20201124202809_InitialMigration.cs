using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDevGroupProject.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Applicant",
                columns: table => new
                {
                    ApplicantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantFirstName = table.Column<string>(nullable: true),
                    ApplicantLastName = table.Column<string>(nullable: true),
                    ApplicantMiddleInitial = table.Column<string>(nullable: true),
                    ApplicantCountry = table.Column<string>(nullable: true),
                    ApplicantStreetAddress = table.Column<string>(nullable: true),
                    ApplicantCity = table.Column<string>(nullable: true),
                    ApplicantZip = table.Column<string>(nullable: true),
                    ApplicantPhone = table.Column<string>(nullable: true),
                    ApplicantEmail = table.Column<string>(nullable: true),
                    ApplicantBirthDate = table.Column<DateTime>(nullable: false),
                    ApplicantPrimaryCitizenship = table.Column<string>(nullable: true),
                    EthnicOrigin = table.Column<string>(nullable: true),
                    HispanicLatino = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applicant", x => x.ApplicantID);
                });

            migrationBuilder.CreateTable(
                name: "BillingViewModel",
                columns: table => new
                {
                    CreditCardNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BillingExpiration = table.Column<string>(maxLength: 5, nullable: false),
                    BillingCVV = table.Column<string>(maxLength: 4, nullable: false),
                    BillingName = table.Column<string>(nullable: false),
                    BillingAddress = table.Column<string>(nullable: false),
                    BillingCity = table.Column<string>(nullable: false),
                    BillingState = table.Column<string>(maxLength: 2, nullable: false),
                    BillingZip = table.Column<string>(nullable: false),
                    Signature = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingViewModel", x => x.CreditCardNumber);
                });

            migrationBuilder.CreateTable(
                name: "FamilyRole",
                columns: table => new
                {
                    FamilyRoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyRole", x => x.FamilyRoleID);
                });

            migrationBuilder.CreateTable(
                name: "SortedApplicantsReport",
                columns: table => new
                {
                    ApplicantID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    GPA = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SortedApplicantsReport", x => x.ApplicantID);
                });

            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    ApplicationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationDate = table.Column<DateTime>(nullable: false),
                    ApplicantID = table.Column<int>(nullable: true),
                    HighSchoolName = table.Column<string>(nullable: true),
                    CEEBCode = table.Column<int>(nullable: false),
                    GPA = table.Column<int>(nullable: false),
                    SAT = table.Column<int>(nullable: false),
                    ACT = table.Column<int>(nullable: false),
                    HighSchoolTranscriptPath = table.Column<string>(nullable: true),
                    PreferredMajor = table.Column<string>(nullable: true),
                    PreferredMinor = table.Column<string>(nullable: true),
                    InterestedInHonors = table.Column<bool>(nullable: false),
                    StudentType = table.Column<string>(nullable: true),
                    ResidentialStatus = table.Column<string>(nullable: true),
                    FamilyRoleID = table.Column<int>(nullable: true),
                    ChurchName = table.Column<string>(nullable: true),
                    ChurchAddress = table.Column<string>(nullable: true),
                    ChurchCity = table.Column<string>(nullable: true),
                    ChurchState = table.Column<string>(nullable: true),
                    ChurchZip = table.Column<string>(nullable: true),
                    PastorName = table.Column<string>(nullable: true),
                    PastorEmail = table.Column<string>(nullable: true),
                    ProfessionOfFaith = table.Column<bool>(nullable: false),
                    SpiritualJourney = table.Column<string>(nullable: true),
                    PolicyHolder = table.Column<string>(nullable: true),
                    ProviderName = table.Column<string>(nullable: true),
                    MemberID = table.Column<string>(nullable: true),
                    PolicyGroupNumber = table.Column<string>(nullable: true),
                    InsuranceCardFrontPath = table.Column<string>(nullable: true),
                    InsuranceCardBackPath = table.Column<string>(nullable: true),
                    ImmunizationFilePath = table.Column<string>(nullable: true),
                    PhysicianName = table.Column<string>(nullable: true),
                    PracticeName = table.Column<string>(nullable: true),
                    PracticePhoneNumber = table.Column<string>(nullable: true),
                    ContactFirstName = table.Column<string>(nullable: true),
                    ContactLastName = table.Column<string>(nullable: true),
                    ContactEmailAddress = table.Column<string>(nullable: true),
                    ContactPhoneNumber = table.Column<string>(nullable: true),
                    ContactRelationship = table.Column<string>(nullable: true),
                    ReferenceFirstName = table.Column<string>(nullable: true),
                    ReferenceLastName = table.Column<string>(nullable: true),
                    ReferenceRelationship = table.Column<string>(nullable: true),
                    ReferenceEmailAddress = table.Column<string>(nullable: true),
                    ReferencePhoneNumber = table.Column<string>(nullable: true),
                    CreditCardNumber = table.Column<int>(nullable: false),
                    BillingExpiration = table.Column<string>(nullable: true),
                    BillingCVV = table.Column<string>(nullable: true),
                    BillingName = table.Column<string>(nullable: true),
                    BillingAddress = table.Column<string>(nullable: true),
                    BillingCity = table.Column<string>(nullable: true),
                    BillingState = table.Column<string>(nullable: true),
                    BillingZip = table.Column<string>(nullable: true),
                    Signature = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.ApplicationID);
                    table.ForeignKey(
                        name: "FK_Application_Applicant_ApplicantID",
                        column: x => x.ApplicantID,
                        principalTable: "Applicant",
                        principalColumn: "ApplicantID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Application_FamilyRole_FamilyRoleID",
                        column: x => x.FamilyRoleID,
                        principalTable: "FamilyRole",
                        principalColumn: "FamilyRoleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Guardian",
                columns: table => new
                {
                    GuardianID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuardianFirstName = table.Column<string>(nullable: true),
                    GuardianLastName = table.Column<string>(nullable: true),
                    GuardianEmail = table.Column<string>(nullable: true),
                    ApplicationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guardian", x => x.GuardianID);
                    table.ForeignKey(
                        name: "FK_Guardian_Application_ApplicationID",
                        column: x => x.ApplicationID,
                        principalTable: "Application",
                        principalColumn: "ApplicationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PastUniversity",
                columns: table => new
                {
                    PastUniversityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PastUniversityName = table.Column<string>(nullable: true),
                    PastUniversityTranscriptPath = table.Column<string>(nullable: true),
                    ApplicationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PastUniversity", x => x.PastUniversityID);
                    table.ForeignKey(
                        name: "FK_PastUniversity_Application_ApplicationID",
                        column: x => x.ApplicationID,
                        principalTable: "Application",
                        principalColumn: "ApplicationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sibling",
                columns: table => new
                {
                    SiblingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiblingFirstName = table.Column<string>(nullable: true),
                    SiblingLastName = table.Column<string>(nullable: true),
                    SiblingAge = table.Column<string>(nullable: true),
                    ApplicationID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sibling", x => x.SiblingID);
                    table.ForeignKey(
                        name: "FK_Sibling_Application_ApplicationID",
                        column: x => x.ApplicationID,
                        principalTable: "Application",
                        principalColumn: "ApplicationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Application_ApplicantID",
                table: "Application",
                column: "ApplicantID");

            migrationBuilder.CreateIndex(
                name: "IX_Application_FamilyRoleID",
                table: "Application",
                column: "FamilyRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Guardian_ApplicationID",
                table: "Guardian",
                column: "ApplicationID");

            migrationBuilder.CreateIndex(
                name: "IX_PastUniversity_ApplicationID",
                table: "PastUniversity",
                column: "ApplicationID");

            migrationBuilder.CreateIndex(
                name: "IX_Sibling_ApplicationID",
                table: "Sibling",
                column: "ApplicationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillingViewModel");

            migrationBuilder.DropTable(
                name: "Guardian");

            migrationBuilder.DropTable(
                name: "PastUniversity");

            migrationBuilder.DropTable(
                name: "Sibling");

            migrationBuilder.DropTable(
                name: "SortedApplicantsReport");

            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "Applicant");

            migrationBuilder.DropTable(
                name: "FamilyRole");
        }
    }
}
