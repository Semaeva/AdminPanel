using AdminPanel.Interfaces;
using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class AchievementsController : Controller, ICRUDController, IPictiresCRUD
    {
        ApplicationContext _context;

       public AchievementsController(ApplicationContext context)
        {
            _context = context;
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
    }
}
