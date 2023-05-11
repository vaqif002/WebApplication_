using Microsoft.AspNetCore.Mvc;
using WebApplication_.DAL;

namespace WebApplication_.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _appcontext;
        public WorkController(AppDbContext appcontext) { _appcontext = appcontext; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
