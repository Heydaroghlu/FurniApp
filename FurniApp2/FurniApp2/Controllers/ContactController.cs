using Microsoft.AspNetCore.Mvc;

namespace FurniApp2.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
