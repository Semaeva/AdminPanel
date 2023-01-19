using AdminPanel.Interfaces;
using AdminPanel.Models;
using AdminPanel.Models.PicturesModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class AchievementsController : Controller, ICRUDController, IPictiresCRUD
    {
        ApplicationContext _context;
        IWebHostEnvironment _environment;

       public AchievementsController(ApplicationContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task<IActionResult> AllPictures() => View(await _context.AchievementsPictures.ToListAsync());
       
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var achievement = await _context.Achievements.FindAsync(id);
            _context.Achievements.Remove(achievement);
            _context.SaveChanges();
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

        public async Task<IActionResult> Details(int id)
        {
            var achievements = await _context.Achievements.Where(x=>x.Id==id).ToListAsync();
            return View(achievements);
        }

        public Task<IActionResult> Edit(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Index() => View(await _context.Achievements.ToListAsync());

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

        public IActionResult Create() => View();
        public async Task<IActionResult> Create(string newsName, string descriptionName, IFormFileCollection uploadedFiles)
        {
            var achievements = new Achievements { Name = newsName, Description = descriptionName };
            await _context.Achievements.AddAsync(achievements);
            _context.SaveChanges();
            if (uploadedFiles != null)
            {
                foreach (var uploadedFile in uploadedFiles)
                {
                    var path = "/pictures/" + uploadedFile.FileName;
                    using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }
                    AchievementsPictures pic = new AchievementsPictures() { Name = uploadedFile.FileName, Path = path, Achievements = achievements };
                    await _context.AchievementsPictures.AddAsync(pic);
                    await _context.SaveChangesAsync();
                }
                var res = _context.Achievements.SingleOrDefault(x => x.Id == achievements.Id);
                if (res != null)
                {
                    var lastRecord = await _context.NewsPictures.OrderByDescending(p => p.Path).FirstOrDefaultAsync();
                    res.MainPicturePath = lastRecord?.Path;
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
