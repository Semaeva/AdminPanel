using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminPanel.Interfaces
{
    public interface IPictiresCRUD
    {
        [HttpPut]
        public Task<IActionResult> SetMainPicture(int id, string path);

        public Task<IActionResult> AllPictures();

        [HttpDelete]
        public Task<IActionResult> DeletePicture(int id);
    }
}
