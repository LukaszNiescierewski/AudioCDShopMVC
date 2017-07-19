using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AudioCDShopMVC.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description {get; set;}
        public string IconFilename { get; set; }

        // właściwośc nawigacyjna
        public virtual ICollection<Album> Albums { get; set; }
    }
}