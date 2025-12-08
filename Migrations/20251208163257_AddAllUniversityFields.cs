using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookletApi.Migrations
{
    /// <inheritdoc />
    public partial class AddAllUniversityFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClassParticipation",
                table: "UniversityInfos",
                newName: "WarningCases");

            migrationBuilder.AddColumn<string>(
                name: "ChangeSpecialty",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ColloquiumAssessment",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Concepts",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Credits",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DisciplineProcedure",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DisciplineResp",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Encouragement",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExamRules",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExchangePrograms",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExpulsionCases",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InstitutionExpulsion",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LectureAssessment",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LibraryRightsDuties",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LibraryServiceRules",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PracticalCriteria",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PracticalTasks",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PracticeOrganization",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReadersRightsDuties",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Reinstatement",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReprimandCases",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RightsDuties",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Scholarships",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SeminarLabAssessment",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SevereReprimandCases",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SocialSupport",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentLoan",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TemporarySuspension",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TheoreticalCriteria",
                table: "UniversityInfos",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChangeSpecialty",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "ColloquiumAssessment",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "Concepts",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "Credits",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "DisciplineProcedure",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "DisciplineResp",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "Encouragement",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "ExamRules",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "ExchangePrograms",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "ExpulsionCases",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "InstitutionExpulsion",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "LectureAssessment",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "LibraryRightsDuties",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "LibraryServiceRules",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "PracticalCriteria",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "PracticalTasks",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "PracticeOrganization",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "ReadersRightsDuties",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "Reinstatement",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "ReprimandCases",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "RightsDuties",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "Scholarships",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "SeminarLabAssessment",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "SevereReprimandCases",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "SocialSupport",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "StudentLoan",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "TemporarySuspension",
                table: "UniversityInfos");

            migrationBuilder.DropColumn(
                name: "TheoreticalCriteria",
                table: "UniversityInfos");

            migrationBuilder.RenameColumn(
                name: "WarningCases",
                table: "UniversityInfos",
                newName: "ClassParticipation");
        }
    }
}
