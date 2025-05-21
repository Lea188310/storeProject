using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.services
{
    public interface IShoppingDetailDAL
    {
        public List<ShoppingDetail> GetAll();
        public bool Add(ShoppingDetail s);

    }
}
