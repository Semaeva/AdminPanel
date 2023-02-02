using AdminPanel.Models;
using AdminPanel.Models.CollectionData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static System.Reflection.Metadata.BlobBuilder;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext _context;
        public HomeController(ApplicationContext context)
        {
            _context = context;
        }

        [Authorize]
       public IActionResult Index()
        {
            var model = new CollectionDataModel();
            model.News = _context.News.ToList();
            model.Managers = _context.Managers.ToList();
            return View(model);
        }

        public IActionResult LessonTuple()
        {
            var news = _context.News.ToList();
            var managers = _context.Managers.ToList();
            var model = new Tuple<List<News>, List<Managers>>(news, managers);
            return View(model);
        }

       
    }
}