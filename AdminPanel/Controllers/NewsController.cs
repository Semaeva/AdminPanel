using AdminPanel.Models;
using AdminPanel.Models.PicturesModel;
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

        public async Task<IActionResult>Index()
        {
            var newsList = await _context.News.Include(p => p.NewsPictures).ToListAsync();
            return View(newsList);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(string newsName, string descriptionName, IFormFileCollection uploadedFiles)
        {
            var news = new News {  Name = newsName, Description = descriptionName };
            await _context.News.AddAsync(news);
            _context.SaveChanges();
            /*NewsPictures pic;*/
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
                    await _context.NewsPictures.AddAsync(pic);
                    await _context.SaveChangesAsync();
                }
                //news.MainPicturePath = _context.NewsPictures.Last().Path;
                var res = _context.News.SingleOrDefault(x => x.Id == news.Id);
                if (res != null)
                {
                    var lastRecord = _context.NewsPictures.OrderByDescending(p => p.Path).FirstOrDefault().Name;
                    res.MainPicturePath = lastRecord ;
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePicture(int id)
        {
            var record = _context.NewsPictures.Where(x => x.Id == id).FirstOrDefault();
            if (record != null)
            {
                _context.NewsPictures.Remove(record);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("AllPictures");
        }


        [HttpPut]
        public async Task<IActionResult> SetMainPicture(int id, string path)
        {
            var result = _context.Achievements.SingleOrDefault((p => p.Id == id));
            if (result != null)
            {
                result.MainPicturePath = path;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AllPictures() => View(await _context.NewsPictures.ToListAsync()); 
    }
}
