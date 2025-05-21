using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Shopping
    {
        public Shopping()
        {
            ShoppingDetails = new HashSet<ShoppingDetail>();
        }

        public int ShoppingId { get; set; }
        public int? CustemerId { get; set; }
        public DateTime? DateShopping { get; set; }
        public int? SumShopping { get; set; }

        public virtual Custemer? Custemer { get; set; }
        public virtual ICollection<ShoppingDetail> ShoppingDetails { get; set; }
    }
}
