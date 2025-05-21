using DAL.Models;
using DAL.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.classes
{
    public class CategoryDAL : ICategoryDAL
    {
        LEALE_VAINER_P_2025Context db=new LEALE_VAINER_P_2025Context(); 
        public bool AddCategory(Category c)
        {
            try
            {
                db.Categories.Add(c);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;   
            }
        }

        public List<Category> GetCategories()
        {
            return db.Categories.ToList();
        }

        public bool RemoveCategory(int  id)
        {
            try
            {
                Category c = db.Categories.FirstOrDefault(x => x.CategorId == id);
                db.Categories.Remove(c);
                db.SaveChanges();
                return true;
            }
            catch { 
                return false; 
            } 
        }

        public bool Update(int id, Category c)
        {
            try
            {
                db.Categories.FirstOrDefault(x => x.CategorId == id).CategoryName = c.CategoryName;
                db.SaveChanges();
                return true;
            }
            catch 
            {
                return false;
            }
        }

    }
}
