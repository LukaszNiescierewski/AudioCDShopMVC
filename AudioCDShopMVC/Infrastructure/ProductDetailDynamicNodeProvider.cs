using AudioCDShopMVC.DAL;
using AudioCDShopMVC.Models;
using MvcSiteMapProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AudioCDShopMVC.Infrastructure
{
    public class ProductDetailDynamicNodeProvider : DynamicNodeProviderBase
    {
        private StoreContext db = new StoreContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var returnValue = new List<DynamicNode>();
            foreach (Album album in db.Albums)
            {
                DynamicNode n = new DynamicNode();
                n.Title = album.AlbumTitle;
                n.Key = "Album_" + album.AlbumId; // klucz potrzebny do dodatkowych zagnieżdzęń
                n.ParentKey = "Genre_" + album.GenreId; // potrzebny tylko wtedy gdy ojcem jest element dynamiczny
                n.RouteValues.Add("id", album.AlbumId);
                returnValue.Add(n);
            }

            return returnValue;
        }
    }
}