namespace VenkataSaiNadhResume.Models
{
    public class Skill
    {
        public int Id { get; set; }

        public string Category { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Icon { get; set; } = string.Empty;

        public List<string> Technologies { get; set; } = new();
    }
}