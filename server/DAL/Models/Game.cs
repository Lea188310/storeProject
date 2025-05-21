using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Game
    {
        public Game()
        {
            ShoppingDetails = new HashSet<ShoppingDetail>();
        }

        public int GameId { get; set; }
        public string? ProductName { get; set; }
        public int? CategorId { get; set; }
        public int? Price { get; set; }
        public string? Pecture { get; set; }
        public int? Quantity { get; set; }

        public virtual Category? Categor { get; set; }
        public virtual ICollection<ShoppingDetail> ShoppingDetails { get; set; }
    }
}
