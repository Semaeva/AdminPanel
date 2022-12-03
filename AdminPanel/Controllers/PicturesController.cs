using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class PicturesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
