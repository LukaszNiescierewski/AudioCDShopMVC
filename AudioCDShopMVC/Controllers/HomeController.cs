﻿using AudioCDShopMVC.DAL;
using AudioCDShopMVC.Models;
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
            /*
            Genre newGenre = new Genre { Name = "Rock", Description = "Opis gatunku", IconFilename = "1.png" };
            db.Genres.Add(newGenre);
            db.SaveChanges();
            */
            return View();
        }


        public ActionResult StaticContent(string viewname)
        {
            return View(viewname);
            
        }
    }
} 