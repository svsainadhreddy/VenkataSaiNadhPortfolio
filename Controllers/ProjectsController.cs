using Microsoft.AspNetCore.Mvc;
using VenkataSaiNadhResume.Data;

namespace VenkataSaiNadhResume.Controllers
{
    public class ProjectsController : Controller
    {
        // =====================================================
        // PROJECT LIST
        // =====================================================

        public IActionResult Index()
        {
            var projects = PortfolioData.GetProjects();

            return View(projects);
        }


        // =====================================================
        // PROJECT DETAILS
        // =====================================================

        public IActionResult Details(int id)
        {
            var project = PortfolioData.GetProjectById(id);

            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }
    }
}