using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class PicturesController : Controller
    {
        ApplicationContext context;
        public PicturesController(ApplicationContext context)
        {
            this.context = context; 

        }

        public IActionResult Index()
        {
            return View();
        }

      
    }
}
