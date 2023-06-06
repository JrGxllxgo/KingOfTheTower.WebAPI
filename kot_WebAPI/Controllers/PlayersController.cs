using Microsoft.AspNetCore.Mvc;

namespace kot_WebAPI.Controllers
{
    public class PlayersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
