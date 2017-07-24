using AudioCDShopMVC.DAL;
using AudioCDShopMVC.Models;
using MvcSiteMapProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AudioCDShopMVC.Infrastructure
{
    public class ProductListDynamicNodeProvider : DynamicNodeProviderBase
    {
        private StoreContext db = new StoreContext();

        public override IEnumerable<DynamicNode> GetDynamicNodeCollection(ISiteMapNode node)
        {
            var returnValue = new List<DynamicNode>();
            foreach (Genre album in db.Genres)
            {
                DynamicNode n = new DynamicNode();
                n.Title = album.Name;
                n.Key = "Genre_" + album.GenreId; // klucz potrzebny do dodatkowych zagnieżdzęń        
                n.RouteValues.Add("genrename", album.Name);
                returnValue.Add(n);
            }

            return returnValue;
        }
    }
}