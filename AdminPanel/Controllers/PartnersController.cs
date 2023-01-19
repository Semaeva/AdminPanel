using AdminPanel.Interfaces;
using AdminPanel.Models;
using AdminPanel.Models.PicturesModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class PartnersController : Controller, ICRUDController
    {
        ApplicationContext _context;
        IWebHostEnvironment _environment;

        public PartnersController(ApplicationContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult Create() => View();

        public async Task<IActionResult> Create(string newsName, string descriptionName, IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                var path = "/pictures/" + uploadedFile.FileName;
                using (var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                Partners par = new Partners() { Name = uploadedFile.FileName, PathImage = path, NameImage = uploadedFile.FileName, Description = descriptionName   };
                await _context.Partners.AddAsync(par);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _context.Partners.FirstOrDefaultAsync(x => x.Id == id);
            if (result != null)
            {
                _context.Remove(result);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id) => View(await _context.Partners.FirstOrDefaultAsync(x => x.Id == id));


        public async Task<IActionResult> Edit(int id) => View(await _context.Partners.FirstOrDefaultAsync(x => x.Id == id));

        [HttpPost]
       
        public async Task<IActionResult> Edit(Partners model)
        {
            if (ModelState.IsValid)
            {
                var result = await _context.Partners.SingleOrDefaultAsync(x => x.Id == model.Id);
                if (result != null)
                {
                    result.Description = model.Description;
                    result.Name = model.Name;
                    result.PathImage = model.PathImage;
                    result.NameImage = model.NameImage;
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit", new { id = model.Id });
            }
            return View(model);
        }

        public async Task<IActionResult> Index()=> View(await _context.Partners.ToListAsync());

    }
}
