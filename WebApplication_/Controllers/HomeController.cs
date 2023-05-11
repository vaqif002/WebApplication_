using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication_.DAL;
using WebApplication_.Models;

namespace WebApplication_.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDbContext _appcontext;
		public HomeController(AppDbContext appcontext) { _appcontext = appcontext; }
		public async Task <IActionResult> Index()
		{
			List<Sliders> sliders = await _appcontext.Sliders.ToListAsync();
			return View(sliders);
		}
	}
}
