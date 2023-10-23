using Microsoft.AspNetCore.Mvc;

namespace FurniApp2.Controllers
{
	public class TestController : Controller
	{
		public IActionResult Index()
		{
			return View("~/Views/Home/Index.cshtml");
		}
	}
}
