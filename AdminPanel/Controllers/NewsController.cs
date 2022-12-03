using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{

    public class NewsController : Controller
    {
        ApplicationContext _context;
        IWebHostEnvironment _environment;

        public NewsController(ApplicationContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;   
        }   
        //test
        public async Task<IActionResult>Index()
        {
            var newsList = await _context.News.Include(p => p.Pictures).ToListAsync();
            return View(newsList);
        }

       //test
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string newsName, string newsDescription, IFormFileCollection uploadedFiles)
        {
            var news = new News {  Name = newsName, Description = newsDescription };
            await _context.News.AddAsync(news);
            _context.SaveChanges();
            if(uploadedFiles!= null)
            {
                foreach (var uploadedFile in uploadedFiles)
                {
                    var path = "/pictures/" + uploadedFile.FileName;
                    using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }
                    NewsPictures pic = new NewsPictures() { Name = uploadedFile.FileName, Path = path, News = news };
                    await _context.Pictures.AddAsync(pic);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
