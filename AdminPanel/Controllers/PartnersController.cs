using AdminPanel.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class PartnersController : Controller, ICRUDController
    {
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

        public IActionResult Index()
        {
            return View();
        }

        Task<IActionResult> ICRUDController.Index()
        {
            throw new NotImplementedException();
        }
    }
}
