using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GameDTO
    {
        public int GameId { get; set; }
        public string? ProductName { get; set; }
        public int? CategorId { get; set; }
        public int? Price { get; set; }
        public string? Pecture { get; set; }
        public int? Quantity { get; set; }

    }
}
