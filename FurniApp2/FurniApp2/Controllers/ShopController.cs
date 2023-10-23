using Microsoft.AspNetCore.Mvc;

namespace FurniApp2.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
