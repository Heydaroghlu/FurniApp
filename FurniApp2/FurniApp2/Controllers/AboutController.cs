using Microsoft.AspNetCore.Mvc;

namespace FurniApp2.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
