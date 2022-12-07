using AdminPanel.Interfaces;
using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class TeachersController : Controller, ICRUDController
    {
        ApplicationContext _context;
        public TeachersController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var result = _context.Teachers.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                _context.Teachers.Remove(result);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id) => View(await _context.Teachers.FirstOrDefaultAsync(x => x.Id == id));

        public async Task<IActionResult> Edit(int id) => View(await _context.Teachers.FirstOrDefaultAsync(x => x.Id == id));

        [HttpPost]
        public async Task<IActionResult> Edit(Teachers model)
        {
            if (ModelState.IsValid)
            {
                var result = await _context.Teachers.SingleOrDefaultAsync(x => x.Id == model.Id);
                if (result != null)
                {
                   result.Description = model.Description;
                   result.Name = model.Name;
                   result.TeachersPictures = model.TeachersPictures;
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit", new {id = model.Id});
            }
            return View(model);
        }

        public async Task<IActionResult> Index() => View(await _context.Teachers.ToListAsync());
    }

}
