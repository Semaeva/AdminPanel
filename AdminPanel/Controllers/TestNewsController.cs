using AdminPanel.Interfaces;
using AdminPanel.Models;
using AdminPanel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Net;

namespace AdminPanel.Controllers
{
    public class TestNewsController : Controller, ICRUDController
    {
      
        ApplicationContext _context;

        public TestNewsController(ApplicationContext context)
        {
            _context = context;
        }

        public Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Details(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Edit(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.News.ToListAsync());
        }
    }
}
