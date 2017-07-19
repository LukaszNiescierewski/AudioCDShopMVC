using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AudioCDShopMVC.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int AlbumId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // właściwości nawigacyjne
        public virtual Album Album { get; set; }
        public virtual Order Order { get; set; }
    }
}