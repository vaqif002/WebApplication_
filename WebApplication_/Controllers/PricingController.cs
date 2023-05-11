using Microsoft.AspNetCore.Mvc;
using WebApplication_.DAL;

namespace WebApplication_.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _appcontext;
        public PricingController(AppDbContext appcontext) { _appcontext = appcontext; }
        public IActionResult Index()
        {
            return View();
        }
    }
}
