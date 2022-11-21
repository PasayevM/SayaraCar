using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SayaraCar.DAL;
using SayaraCar.Models;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace SayaraCar.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public HeaderViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = await _db.Bios.FirstOrDefaultAsync();
            return View (bio);
        }
       
    }
}
