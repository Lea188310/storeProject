﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ShoppingDetailDTO
    {
        public int ShoppingDetailsId { get; set; }
        public int? ShoppingId { get; set; }
        public int? GameId { get; set; }
        public int? Quantity { get; set; }
    }
}
