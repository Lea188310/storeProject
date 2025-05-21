using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ShoppingDTO
    {
        public int ShoppingId { get; set; }
        public int? CustemerId { get; set; }
        public DateTime? DateShopping { get; set; }
        public int? SumShopping { get; set; }
    }
}
