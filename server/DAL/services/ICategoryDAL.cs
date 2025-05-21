using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.services
{
    public interface ICategoryDAL
    {
      
        public List<Category> GetCategories();
        public bool AddCategory(Category c);
        public bool RemoveCategory(int id);
        public bool Update(int id,Category c);

    }
}
