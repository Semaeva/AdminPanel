using AdminPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AdminPanel.Interfaces
{
    public interface ICRUDController
    {
        public Task<IActionResult> Index();
        public Task<IActionResult> Details(int id);
        public Task<IActionResult> Delete(int id);
        public Task<IActionResult> Edit(int id );
        public IActionResult Create();

     
    }
}
