namespace VenkataSaiNadhResume.Models
{
    public class HomeViewModel
    {
        public string Name { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string LinkedInUrl { get; set; } = string.Empty;

        public string GithubUrl { get; set; } = string.Empty;

        public List<string> PrimaryTechnologies { get; set; } = new();

        public List<Project> Projects { get; set; } = new();

        public List<Skill> Skills { get; set; } = new();

        public List<Education> Education { get; set; } = new();

        public List<Certification> Certifications { get; set; } = new();
    }
}