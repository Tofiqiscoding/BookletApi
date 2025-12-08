using System;

namespace BookletApi.Models
{
    public class Section
    {
        public Guid Id { get; set; }
        public string Key { get; set; } = null!;
        public string DefaultTitle { get; set; } = "";
        public string DefaultContent { get; set; } = "";
        public bool IsPublished { get; set; } = false;
        public DateTime UpdatedAt { get; set; }
    }
}
