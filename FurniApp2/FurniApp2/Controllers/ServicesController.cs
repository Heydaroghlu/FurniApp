using Microsoft.AspNetCore.Mvc;

namespace FurniApp2.Controllers
{
	public class ServicesController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
