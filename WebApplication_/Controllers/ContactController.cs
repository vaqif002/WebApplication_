using Microsoft.AspNetCore.Mvc;
using WebApplication_.DAL;

namespace WebApplication_.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _appcontext;
        public ContactController(AppDbContext appcontext) { _appcontext = appcontext; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
