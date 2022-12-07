using AdminPanel.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class TeachersController : Controller, ICRUDController, IPictiresCRUD
    {
        public Task<IActionResult> AllPictures()
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> DeletePicture(int id)
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

        public Task<IActionResult> SetMainPicture(int id, string path)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> ICRUDController.Index()
        {
            throw new NotImplementedException();
        }
    }
}
