using SayaraCar.Models;
using System.Collections.Generic;

namespace SayaraCar.ViewModel
{
    public class HomeVM
    {
        public Banner Banners { get; set; }    
        public List<BannerModel> BannerModels { get; set; }    
        public List<BannerType> BannerTypes { get; set; }    
        public List<BannerColor> BannerColors { get; set; }    
        public List<Service> Services { get; set; }    
        public List<Preview> Previews { get; set; }    
        public List<Product> Products { get; set; }    
        public List<Blog> Blogs { get; set; }    
        public List<Bio> Bios { get; set; }    
    }
}
