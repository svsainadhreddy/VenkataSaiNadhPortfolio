namespace VenkataSaiNadhResume.Models
{
    public class Education
    {
        public int Id { get; set; }

        public string Year { get; set; } = string.Empty;

        public string Degree { get; set; } = string.Empty;

        public string Institution { get; set; } = string.Empty;

        public string? Grade { get; set; }
    }
}