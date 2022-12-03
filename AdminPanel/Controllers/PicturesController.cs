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


        //установка главнойr
        public async Task<IActionResult> SetMainPicture(int id, string path)
        {
            var result = context.Achievements.SingleOrDefault((p => p.Id == id));
            if (result != null)
            {
                result.MainPicturePath = path;
                await context.SaveChangesAsync();
            }
            return RedirectToAction("Index");

        }
    }
}
