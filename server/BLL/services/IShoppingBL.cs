using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.services
{
    public interface IShoppingBL
    {
        public List<ShoppingDTO> GetAll();
        public int SvaeShopping(ShoppingDTO s);
        
    }
}
