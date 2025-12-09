using System;
using BookletApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookletApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<SectionTranslation> SectionTranslations { get; set; }
        public DbSet<UniversityInfo> UniversityInfos { get; set; }  
    }
}