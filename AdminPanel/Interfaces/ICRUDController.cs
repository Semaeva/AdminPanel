using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminPanel.Interfaces
{
    public interface ICRUDController
    {

        public Task<IActionResult> Index();
        public Task<IActionResult> Details(string id);
        public Task<IActionResult> Delete(int id);
        public Task<IActionResult> Edit(int id);
     
    }
}
