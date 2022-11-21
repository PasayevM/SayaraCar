using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SayaraCar.DAL;
using SayaraCar.Models;
using SayaraCar.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SayaraCar.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
       
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
               BannerColors = _db.BannerColors.ToList(),
               BannerTypes = _db.BannerTypes.ToList(),
               Banners = _db.Banners.FirstOrDefault(),
               BannerModels = _db.BannerModels.ToList(),
               Services = _db.Services.ToList(),    
               Previews = _db.Previews.ToList(),
               Products = _db.Products.OrderByDescending(x=>x.Id).ToList(),
               Blogs = _db.Blogs.OrderByDescending(x=>x.Id).ToList(),
            };
            return View(homeVM);
        }

       
        public IActionResult Error()
        {
            return View();
        }
    }
}
