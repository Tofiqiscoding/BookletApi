using System;
using System.Linq;
using System.Threading.Tasks;
using BookletApi.Data;
using BookletApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookletApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniversityController : ControllerBase
    {
        private readonly AppDbContext _context;
        
        public UniversityController(AppDbContext context)
        {
            _context = context;
        }
        
        // GET: api/university
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var info = await _context.UniversityInfos
                .OrderByDescending(x => x.UpdatedAt)
                .FirstOrDefaultAsync();
            
            if (info == null)
            {
                return Ok(new UniversityInfo());
            }
            
            return Ok(info);
        }
        
        // POST: api/university
        [HttpPost]
        public async Task<IActionResult> Save([FromBody] UniversityInfo info)
        {
            var existing = await _context.UniversityInfos.FirstOrDefaultAsync();
            
            if (existing == null)
            {
                info.Id = Guid.NewGuid();
                info.CreatedAt = DateTime.UtcNow;
                info.UpdatedAt = DateTime.UtcNow;
                _context.UniversityInfos.Add(info);
            }
            else
            {
                // Bütün sahələri yenilə
                existing.AboutUniversity = info.AboutUniversity;
                existing.GeneralTerms = info.GeneralTerms;
                existing.StudentOrientedSystem = info.StudentOrientedSystem;
                existing.CourseOrganization = info.CourseOrganization;
                existing.IndividualCurriculum = info.IndividualCurriculum;
                existing.SummerSemester = info.SummerSemester;
                
                existing.LectureAssessment = info.LectureAssessment;
                existing.SeminarLabAssessment = info.SeminarLabAssessment;
                existing.ColloquiumAssessment = info.ColloquiumAssessment;
                
                existing.ExamRules = info.ExamRules;
                existing.TheoreticalCriteria = info.TheoreticalCriteria;
                existing.PracticalCriteria = info.PracticalCriteria;
                existing.PracticalTasks = info.PracticalTasks;
                existing.PracticeOrganization = info.PracticeOrganization;
                
                existing.ChangeSpecialty = info.ChangeSpecialty;
                existing.TemporarySuspension = info.TemporarySuspension;
                existing.InstitutionExpulsion = info.InstitutionExpulsion;
                existing.Reinstatement = info.Reinstatement;
                
                existing.RightsDuties = info.RightsDuties;
                existing.DisciplineResp = info.DisciplineResp;
                existing.WarningCases = info.WarningCases;
                existing.ReprimandCases = info.ReprimandCases;
                existing.SevereReprimandCases = info.SevereReprimandCases;
                existing.ExpulsionCases = info.ExpulsionCases;
                existing.DisciplineProcedure = info.DisciplineProcedure;
                
                existing.LibraryServiceRules = info.LibraryServiceRules;
                existing.LibraryRightsDuties = info.LibraryRightsDuties;
                existing.ReadersRightsDuties = info.ReadersRightsDuties;
                
                existing.Encouragement = info.Encouragement;
                existing.Scholarships = info.Scholarships;
                existing.ExchangePrograms = info.ExchangePrograms;
                existing.StudentLoan = info.StudentLoan;
                existing.SocialSupport = info.SocialSupport;
                
                existing.Credits = info.Credits;
                existing.Concepts = info.Concepts;
                
                existing.UpdatedAt = DateTime.UtcNow;
            }
            
            await _context.SaveChangesAsync();
            
            return Ok(new { message = "Məlumat yadda saxlanıldı", success = true });
        }
    }
}