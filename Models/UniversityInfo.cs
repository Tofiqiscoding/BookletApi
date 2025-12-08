using System;

namespace BookletApi.Models
{
    public class UniversityInfo
    {
        public Guid Id { get; set; }
        
        // Əsas bölmələr
        public string AboutUniversity { get; set; } = string.Empty;
        public string GeneralTerms { get; set; } = string.Empty;
        public string StudentOrientedSystem { get; set; } = string.Empty;
        public string CourseOrganization { get; set; } = string.Empty;
        public string IndividualCurriculum { get; set; } = string.Empty;
        public string SummerSemester { get; set; } = string.Empty;
        
        // Qiymətləndirmə
        public string LectureAssessment { get; set; } = string.Empty;
        public string SeminarLabAssessment { get; set; } = string.Empty;
        public string ColloquiumAssessment { get; set; } = string.Empty;
        
        // İmtahan
        public string ExamRules { get; set; } = string.Empty;
        public string TheoreticalCriteria { get; set; } = string.Empty;
        public string PracticalCriteria { get; set; } = string.Empty;
        public string PracticalTasks { get; set; } = string.Empty;
        public string PracticeOrganization { get; set; } = string.Empty;
        
        // Status dəyişikliyi
        public string ChangeSpecialty { get; set; } = string.Empty;
        public string TemporarySuspension { get; set; } = string.Empty;
        public string InstitutionExpulsion { get; set; } = string.Empty;
        public string Reinstatement { get; set; } = string.Empty;
        
        // Hüquq və vəzifələr
        public string RightsDuties { get; set; } = string.Empty;
        public string DisciplineResp { get; set; } = string.Empty;
        public string WarningCases { get; set; } = string.Empty;
        public string ReprimandCases { get; set; } = string.Empty;
        public string SevereReprimandCases { get; set; } = string.Empty;
        public string ExpulsionCases { get; set; } = string.Empty;
        public string DisciplineProcedure { get; set; } = string.Empty;
        
        // Kitabxana
        public string LibraryServiceRules { get; set; } = string.Empty;
        public string LibraryRightsDuties { get; set; } = string.Empty;
        public string ReadersRightsDuties { get; set; } = string.Empty;
        
        // Dəstək və təşviq
        public string Encouragement { get; set; } = string.Empty;
        public string Scholarships { get; set; } = string.Empty;
        public string ExchangePrograms { get; set; } = string.Empty;
        public string StudentLoan { get; set; } = string.Empty;
        public string SocialSupport { get; set; } = string.Empty;
        
        // Digər
        public string Credits { get; set; } = string.Empty;
        public string Concepts { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}