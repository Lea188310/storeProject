using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class ShoppingDetail
    {
        public int ShoppingDetailsId { get; set; }
        public int? ShoppingId { get; set; }
        public int? GameId { get; set; }
        public int? Quantity { get; set; }

        public virtual Game? Game { get; set; }
        public virtual Shopping? Shopping { get; set; }
    }
}
