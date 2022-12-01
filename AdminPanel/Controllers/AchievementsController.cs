using AdminPanel.Interfaces;
using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class AchievementsController : Controller, ICRUDController
    {
        ApplicationContext _context;

       public AchievementsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            var achievement = await _context.Achievements.FindAsync(id);
            _context.Achievements.Remove(achievement);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(string id)
        {
            var achievements = await _context.Achievements.Where(x=>x.Id.Equals(id)).ToListAsync();
            return View(achievements);
        }

        public Task<IActionResult> Edit(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Index() => View(await _context.Achievements.ToListAsync());
        
    }
}
