﻿using AudioCDShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AudioCDShopMVC.DAL
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base ("StoreContext")
        {
             
        }
        static StoreContext()
        {
            Database.SetInitializer<StoreContext>(new StoreInitializer());
        }
        //reprezentacja tabel w bazie danych
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}