using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SayaraCar.DAL;
using SayaraCar.Models;
using System.Threading.Tasks;

namespace SayaraCar.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _db;
        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = await _db.Bios.FirstOrDefaultAsync();
            return View(bio);
        }
    }
}
