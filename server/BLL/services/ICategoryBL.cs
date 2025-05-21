using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.services
{
    public interface ICategoryBL
    {
        public List<CategoryDTO> GetAllCategories();
       public CategoryDTO GetCategoryByID(int id);
       public bool AddCAtegory(CategoryDTO c);
        public bool Update(int id,CategoryDTO c);
        public bool Delete(int id);
    }
}
