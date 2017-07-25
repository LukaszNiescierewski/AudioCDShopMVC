using AudioCDShopMVC.DAL;
using AudioCDShopMVC.Infrastructure;
using AudioCDShopMVC.Models;
using AudioCDShopMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AudioCDShopMVC.Controllers
{
    public class HomeController : Controller
    {
        private StoreContext db = new StoreContext();
        // GET: Home
        public ActionResult Index()
        {
            var genres = db.Genres.ToList();

            ICacheProvider cache = new DefaultCacheProvider();

            List<Album> newArrivals = new List<Album>();

            if (cache.IsSet(Consts.NewItemsCacheKey))
            {
                newArrivals = cache.Get(Consts.NewItemsCacheKey) as List<Album>;
            }
            else
            {
                newArrivals = db.Albums.Where(a => !a.IsHidden).OrderByDescending(a => a.DateAdded).Take(3).ToList();
                cache.Set(Consts.NewItemsCacheKey, newArrivals, 30);
            }

            
            var bessellers = db.Albums.Where(a => !a.IsHidden && a.IsBestseller).OrderBy(g => Guid.NewGuid()).Take(3).ToList();

            var vm = new HomeViewModel()
            { Bestsellers = bessellers, Genres = genres, NewArrivals = newArrivals };

            return View(vm);
        }
       
        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);

        }
    }
}