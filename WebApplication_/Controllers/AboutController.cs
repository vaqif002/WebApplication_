using Microsoft.AspNetCore.Mvc;
using WebApplication_.DAL;

namespace WebApplication_.Controllers
{
    public class AboutController : Controller
    {

        private readonly AppDbContext _appcontext;
        public AboutController(AppDbContext appcontext) { _appcontext = appcontext; }

        public IActionResult Index()
        {
            return View();
        }
    }
}
