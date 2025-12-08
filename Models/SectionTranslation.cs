using System;

namespace BookletApi.Models
{
    public class SectionTranslation
    {
        public Guid Id { get; set; }
        public Guid SectionId { get; set; }
        public Section? Section { get; set; }
        public string Locale { get; set; } = "en";
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";
        public DateTime UpdatedAt { get; set; }
    }
}
