using AudioCDShopMVC.Migrations;
using AudioCDShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace AudioCDShopMVC.DAL
{
    public class StoreInitializer :MigrateDatabaseToLatestVersion<StoreContext, Configuration>
    {
      /*  protected override void Seed(StoreContext context)
        {
            SeedStoreData(context);

            base.Seed(context);
        }*/

        public static void SeedStoreData (StoreContext context)
        {
            var genres = new List<Genre>
            {
                new Genre() { GenreId = 1, Name = "Rock", IconFilename = "rock.png" },
                new Genre() { GenreId = 2, Name = "Metal", IconFilename = "metal.png" },
                new Genre() { GenreId = 3, Name = "Jazz", IconFilename = "jazz.png" },
                new Genre() { GenreId = 4, Name = "Hip Hop", IconFilename = "hiphop.png" },
                new Genre() { GenreId = 5, Name = "R&B", IconFilename = "rnb.png" },
                new Genre() { GenreId = 6, Name = "Pop", IconFilename = "pop.png" },
                new Genre() { GenreId = 7, Name = "Reggae", IconFilename = "reagge.png" },
                new Genre() { GenreId = 8, Name = "Alternative", IconFilename = "alternative.png" },
                new Genre() { GenreId = 9, Name = "Electronic", IconFilename = "electro.png" },
                new Genre() { GenreId = 10, Name = "Classical", IconFilename = "classics.png" },
                new Genre() { GenreId = 11, Name = "Inne", IconFilename = "other.png" },
                new Genre() { GenreId = 12, Name = "Promocje", IconFilename = "promos.png" }
            };

            genres.ForEach(g => context.Genres.AddOrUpdate(g));
            /*foreach (Models.Genre g in genres)
            {
                context.Genres.Add(g);
            }*/
            context.SaveChanges();

            var albums = new List<Album>
            {
                new Album() { AlbumId = 1, ArtistName = "Led Zeppelin", AlbumTitle = "Led Zeppelin I", Price = 99, CoverFileName = "1.jpg", IsBestseller = true, DateAdded = new DateTime(2014, 02, 1), GenreId = 1 },
                new Album() { AlbumId = 2, ArtistName = "Led Zeppelin", AlbumTitle = "Led Zeppelin II", Price = 54, CoverFileName = "2.jpg", IsBestseller = true, DateAdded = new DateTime(2013, 08, 15), GenreId = 1 },
                new Album() { AlbumId = 3, ArtistName = "Led Zeppelin", AlbumTitle = "Led Zeppelin III", Price = 102, CoverFileName = "3.jpg", IsBestseller = true, DateAdded = new DateTime(2014, 01, 5), GenreId = 1 },
                new Album() { AlbumId = 4, ArtistName = "Led Zeppelin", AlbumTitle = "Led Zeppelin IV", Price = 25, CoverFileName = "4.jpg", IsBestseller = true, DateAdded = new DateTime(2014, 03, 11), GenreId = 1 },
                new Album() { AlbumId = 5, ArtistName = "Led Zeppelin", AlbumTitle = "Physical Graffiti", Price = 28, CoverFileName = "5.jpg", IsBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreId = 1 },
                new Album() { AlbumId = 6, ArtistName = "Led Zeppelin", AlbumTitle = "Coda", Price = 30, CoverFileName = "6.jpg", IsBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreId = 1 },
                new Album() { AlbumId = 7, ArtistName = "System of a down", AlbumTitle = "Steal this Album", Price = 35, CoverFileName = "7.jpg", IsBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreId = 2 },
                new Album() { AlbumId = 8, ArtistName = "System of a down", AlbumTitle = "Hypnotize", Price = 21, CoverFileName = "8.jpg", IsBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreId = 2 },
                new Album() { AlbumId = 9, ArtistName = "The Offspring", AlbumTitle = "Greatest Hits", Price = 25, CoverFileName = "9.jpg", IsBestseller = false, DateAdded = new DateTime(2014, 04, 2), GenreId = 2 }
            };

            albums.ForEach(a => context.Albums.AddOrUpdate(a));
            context.SaveChanges();

        }
    }
}