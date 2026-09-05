namespace VenkataSaiNadhResume.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string LongDescription { get; set; } = string.Empty;

        public string Icon { get; set; } = string.Empty;

        public List<string> Technologies { get; set; } = new();

        public List<string> Features { get; set; } = new();

        public string? GithubUrl { get; set; }

        public string? DemoUrl { get; set; }

        public bool IsFeatured { get; set; }

        public string? ImageUrl { get; set; }
    }
}