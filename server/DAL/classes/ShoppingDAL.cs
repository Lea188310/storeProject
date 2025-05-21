using DAL.Models;
using DAL.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.classes
{
    public class ShoppingDAL : IShoppingDAL
    {
        LEALE_VAINER_P_2025Context db=new LEALE_VAINER_P_2025Context();
       
        
        
        public bool AddNew(Shopping s)
        {
            try
            {
                db.Shoppings.Add(s);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Shopping> GetAllShoppings()
        {
            return db.Shoppings.ToList();   
        }
    }
}
