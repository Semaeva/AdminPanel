using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Controllers
{
    public class PartnerserController : Controller
    {
        // GET: PartnerserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PartnerserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PartnerserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PartnerserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartnerserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PartnerserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartnerserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PartnerserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
