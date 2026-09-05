using Microsoft.AspNetCore.Mvc;
using VenkataSaiNadhResume.Data;
using VenkataSaiNadhResume.Models;

namespace VenkataSaiNadhResume.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Name = "Venkata Sai Nadh",

                Role = "ASP.NET Core Developer",

                Description =
                    "Computer Science graduate focused on building practical web applications using C#, ASP.NET Core, Entity Framework Core and SQL Server, with additional experience in Python and Machine Learning.",

                Email = "svsai798@gmail.com",

                LinkedInUrl =
                    "https://linkedin.com/in/venkatasainadhreddysanikommu798",

                GithubUrl =
                    "https://github.com/",

                PrimaryTechnologies = new List<string>
                {
                    "C#",
                    "ASP.NET Core",
                    "SQL Server",
                    "Python"
                },

                Projects = PortfolioData.GetProjects(),

                Skills = GetSkills(),

                Education = GetEducation(),

                Certifications = GetCertifications()
            };

            return View(model);
        }


        // =====================================================
        // SKILLS
        // =====================================================

        private List<Skill> GetSkills()
        {
            return new List<Skill>
            {
                new Skill
                {
                    Id = 1,

                    Category = "BACKEND",

                    Title = "Backend Development",

                    Description =
                        "Building server-side applications and MVC-based web solutions.",

                    Icon = "bi-code-square",

                    Technologies = new List<string>
                    {
                        "C#",
                        "ASP.NET Core",
                        "LINQ",
                        "Entity Framework Core"
                    }
                },


                new Skill
                {
                    Id = 2,

                    Category = "FRONTEND",

                    Title = "Frontend Development",

                    Description =
                        "Creating responsive and user-friendly web interfaces.",

                    Icon = "bi-window-stack",

                    Technologies = new List<string>
                    {
                        "HTML",
                        "CSS",
                        "Bootstrap",
                        "JavaScript"
                    }
                },


                new Skill
                {
                    Id = 3,

                    Category = "DATABASE",

                    Title = "Database",

                    Description =
                        "Working with relational databases and application data.",

                    Icon = "bi-database",

                    Technologies = new List<string>
                    {
                        "SQL Server",
                        "MySQL"
                    }
                },


                new Skill
                {
                    Id = 4,

                    Category = "PYTHON & ML",

                    Title = "Python & Machine Learning",

                    Description =
                        "Exploring Machine Learning through practical projects and datasets.",

                    Icon = "bi-cpu",

                    Technologies = new List<string>
                    {
                        "Python",
                        "Machine Learning"
                    }
                }
            };
        }


        // =====================================================
        // EDUCATION
        // =====================================================

        private List<Education> GetEducation()
        {
            return new List<Education>
            {
                new Education
                {
                    Id = 1,

                    Year = "2026",

                    Degree =
                        "B.Tech — Computer Science & Engineering",

                    Institution =
                        "Saveetha School of Engineering College, Chennai"
                },


                new Education
                {
                    Id = 2,

                    Year = "2022",

                    Degree =
                        "Class XII — Intermediate",

                    Institution =
                        "Sri Pratibha Junior College, Andhra Pradesh",

                    Grade = "91.6%"
                },


                new Education
                {
                    Id = 3,

                    Year = "2020",

                    Degree =
                        "Class X — SSC",

                    Institution =
                        "Honey High School, Andhra Pradesh",

                    Grade = "100%"
                }
            };
        }


        // =====================================================
        // CERTIFICATIONS
        // =====================================================

        private List<Certification> GetCertifications()
        {
            return new List<Certification>
            {
                new Certification
                {
                    Id = 1,

                    Title =
                        "Oracle Database SQL Certified Specialist",

                    Issuer =
                        "Oracle University",

                    Description =
                        "Oracle Database SQL certification.",

                    Icon = "bi-database-check"
                },


                new Certification
                {
                    Id = 2,

                    Title =
                        "Internet of Things",

                    Issuer =
                        "NPTEL — SWAYAM",

                    Description =
                        "12-week course delivered by IIT faculty.",

                    Icon = "bi-cpu"
                }
            };
        }
    }
}