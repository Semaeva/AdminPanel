using AdminPanel.Interfaces;
using AdminPanel.Models;
using AdminPanel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Controllers
{
    public class CalendarController : Controller, ICRUDController
    {
        ApplicationContext _context;

        public CalendarController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Create() => View(_context.Calendars.Include(e => e.Events).ToList());

        [HttpPost]
        public async Task<IActionResult> Create(string dateEvent, string nameEvent)
        {
            string year = dateEvent.Split('-')[0];
            string month = dateEvent.Split('-')[1];
            string day = dateEvent.Split('-')[2]; 
            
            
            Calendar calendar = new Calendar() { Month = month, Year = year };
            await _context.AddAsync(calendar);
            await _context.SaveChangesAsync();
            Events ev = new Events() { Calendar = calendar, Name = nameEvent, Day = day, FullDate = dateEvent};
            await _context.AddAsync(ev);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Details(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Edit(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Index()=>View(await _context.Calendars.Include(e=>e.Events).ToListAsync());



    }
}
