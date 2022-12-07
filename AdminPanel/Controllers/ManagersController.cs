using AdminPanel.Interfaces;
using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class ManagersController : Controller, ICRUDController
    {
        ApplicationContext _context;
        public ManagersController(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Delete(int id)
        {
            var record = _context.Managers.FirstOrDefault(x => x.Id == id);
            if (record != null)
            {
                _context.Managers.Remove(record);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Details(int id) => View(await _context.Managers.Where(x=>x.Id == id).ToListAsync());

        [HttpGet]
        public async Task<IActionResult> Edit(int id) => View(await _context.Managers.FirstOrDefaultAsync(x => x.Id == id));

        [HttpPost]
        public async Task<IActionResult> Edit(Managers managers)
        {
            var record = _context.Managers.SingleOrDefault(x => x.Id == managers.Id);
            if (record != null)
            {
                //var man = new Managers()
                //{
                record.Description = managers.Description;
                record.Name = managers.Name;
                record.NameImage = managers.NameImage;
                record.PathImage = managers.PathImage;               
                try
                { 
                    await _context.SaveChangesAsync();
                }
                catch
                {
                    ModelState.AddModelError("", "Unable to save changes. " +
                "Try again, and if the problem persists, " +
                "see your system administrator.");
                }
            }
             return RedirectToAction("Index", new { id = managers.Id });
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Managers.ToListAsync());
        }

    }
}
