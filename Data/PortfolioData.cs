using VenkataSaiNadhResume.Models;

namespace VenkataSaiNadhResume.Data
{
    public static class PortfolioData
    {
        // =====================================================
        // PROJECTS
        // =====================================================

        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Id = 1,

                    Title = "School Management System",

                    Category = "WEB APPLICATION",

                    Description =
                        "A web-based school management system for managing student records with CRUD operations and database integration.",

                    LongDescription =
                        "The School Management System is a web-based application developed using ASP.NET Core MVC and C#. The application is designed to manage student records through an MVC architecture with Entity Framework Core and SQL Server for database integration.",

                    Icon = "bi-mortarboard-fill",

                    Technologies = new List<string>
                    {
                        "ASP.NET Core MVC",
                        "C#",
                        "Entity Framework Core",
                        "SQL Server"
                    },

                    Features = new List<string>
                    {
                        "Student record management",

                        "Create, read, update and delete operations",

                        "MVC architecture",

                        "Entity Framework Core database integration",

                        "SQL Server database"

                    },

                    IsFeatured = true,

                    GithubUrl = "#",

                    DemoUrl = "#",

                    ImageUrl = "/images/projects/school-management.jpg"
                },


                new Project
                {
                    Id = 2,

                    Title = "Face Recognition & Detection",

                    Category = "MACHINE LEARNING",

                    Description =
                        "Machine Learning based student attendance project involving model comparison and evaluation using Python and datasets.",

                    LongDescription =
                        "A Machine Learning based student attendance project developed using Python. Different Machine Learning approaches were compared to identify the best-performing model using datasets obtained from Kaggle.",

                    Icon = "bi-person-bounding-box",

                    Technologies = new List<string>
                    {
                        "Python",
                        "Machine Learning",
                        "Kaggle"
                    },

                    Features = new List<string>
                    {
                        "Face recognition and detection",

                        "Student attendance use case",

                        "Machine Learning model comparison",

                        "Model performance evaluation",

                        "Kaggle dataset usage"

                    },

                    IsFeatured = false,

                    GithubUrl = "#",

                    DemoUrl = "#",

                    ImageUrl = "/images/projects/face-recognition.jpg"
                },


                new Project
                {
                    Id = 3,

                    Title = "POPC",

                    Category = "MOBILE APPLICATION",

                    Description =
                        "Android application designed for doctors to manage Anesthesia scores and levels.",

                    LongDescription =
                        "POPC is an Android mobile application developed to help doctors manage Anesthesia scores and levels. The application uses Android Studio for the frontend, Django for the backend and MySQL for data storage.",

                    Icon = "bi-phone",

                    Technologies = new List<string>
                    {
                        "Android Studio",
                        "Django",
                        "MySQL"
                    },

                    Features = new List<string>
                    {
                        "Android mobile interface",

                        "Anesthesia score management",

                        "Anesthesia level management",

                        "Django backend",

                        "MySQL database"

                    },

                    IsFeatured = false,

                    GithubUrl = "#",

                    DemoUrl = "#",

                    ImageUrl = "/images/projects/popc.jpg"
                }
            };
        }


        // =====================================================
        // FIND PROJECT BY ID
        // =====================================================

        public static Project? GetProjectById(int id)
        {
            return GetProjects()
                .FirstOrDefault(project => project.Id == id);
        }
    }
}