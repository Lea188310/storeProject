using DAL.Models;
using DAL.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.classes
{
    public class ShoppingDetailDAL: IShoppingDetailDAL
    {
        LEALE_VAINER_P_2025Context db=new LEALE_VAINER_P_2025Context(); 

        public bool Add(ShoppingDetail s)
        {
            try
            {
                db.Add(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ShoppingDetail> GetAll()
        {
            return db.ShoppingDetails.ToList();
        }

      
    }
}
