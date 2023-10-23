using Microsoft.AspNetCore.Mvc;

namespace FurniApp2.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
