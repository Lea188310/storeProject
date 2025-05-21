using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Custemer
    {
        public Custemer()
        {
            Shoppings = new HashSet<Shopping>();
        }

        public int CustemerId { get; set; }
        public string? CustName { get; set; }
        public string? CustPassword { get; set; }
        public string? CreditDetails { get; set; }

        public virtual ICollection<Shopping> Shoppings { get; set; }
    }
}
